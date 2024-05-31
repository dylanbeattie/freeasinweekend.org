using Newtonsoft.Json;

public class Page : Resource {
	[JsonProperty("@type")]
	public string Type { get; set; } = String.Empty;

	public int Count { get; set; }
	public List<PackageItem> Items { get; set; } = [];
}
