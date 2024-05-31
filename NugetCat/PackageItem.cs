using Newtonsoft.Json;

public class PackageItem : Resource {
	[JsonProperty("@type")]
	public string Type { get; set; } = String.Empty;

	[JsonProperty("nuget:id")]
	public string PackageId { get; set; }
	[JsonProperty("nuget:version")]
	public string PackageVersion { get; set; }
}
