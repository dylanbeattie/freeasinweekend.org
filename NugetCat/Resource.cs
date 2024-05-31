using Newtonsoft.Json;

public abstract class Resource {
	[JsonProperty("@id")]
	public string Id { get; set; } = String.Empty;

	public Guid CommitId { get; set; }
	public DateTimeOffset CommitTimestamp { get; set; }
}
