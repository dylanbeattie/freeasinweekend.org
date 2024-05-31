using Newtonsoft.Json;
using System.Data.SqlClient;
using FastMember;
using System.Diagnostics;

const string SQL_CONNECTION_STRING
	= @"Server=localhost;User ID=sa;Password=p@ssw0rd;"
	+ "Database=Packages;MultipleActiveResultSets=True;";

const string LOCAL_CACHE_FOLDER = @"E:\pages\";
var sw = new Stopwatch();
sw.Start();

var http = new HttpClient();
var catalogUrl = "https://api.nuget.org/v3/catalog0/index.json";
var catalogJson = await http.GetStringAsync(catalogUrl);
var catalog = JsonConvert.DeserializeObject<Catalog>(catalogJson)!;
var conn = new SqlConnection(SQL_CONNECTION_STRING);
conn.Open();
var count = 0;
var po = new ParallelOptions { MaxDegreeOfParallelism = 32 };
var threshold = new DateTimeOffset(2023, 1, 1, 0, 0, 0, TimeSpan.Zero);
var pages = catalog.Items;
Console.WriteLine($"Fetching metadata for {pages.Sum(p => p.Count)} package events");
using var bcp = new SqlBulkCopy(conn);
bcp.DestinationTableName = "Packages";
string[] columns = [ "Id", "CommitId", "PackageId",
	"PackageVersion", "CommitTimestamp", "Type" ];
foreach (var item in pages) {
	var cachedPageFile = Path.Combine(LOCAL_CACHE_FOLDER, item.Id.Split('/').Last());
	if (!File.Exists(cachedPageFile)) {
		File.WriteAllText(cachedPageFile, await http.GetStringAsync(item.Id));
	}
	var pageJson = await File.ReadAllTextAsync(cachedPageFile);
	var page = JsonConvert.DeserializeObject<Page>(pageJson)!;
	using (var reader
		= ObjectReader.Create(page.Items, columns)) {
		try {
			bcp.WriteToServer(reader);
		} catch(SqlException ex) {
			Console.WriteLine(ex.Message);
			Console.WriteLine(cachedPageFile);
		}
	}
	Interlocked.Add(ref count, page.Items.Count);
	Console.WriteLine($"Inserted {count} package events");
}
Console.WriteLine($"Completed in {sw.ElapsedMilliseconds}ms");
