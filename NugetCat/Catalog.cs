using Newtonsoft.Json;

public class Catalog : Resource {
	[JsonProperty("@type")]
	public string[] Type { get; set; } = [];
	public int Count { get; set; }
	public DateTimeOffset LastCreated { get; set; }
	public DateTimeOffset LastDeleted { get; set; }
	public DateTimeOffset LastEdited { get; set; }

	public List<Page> Items { get; set; }
}
