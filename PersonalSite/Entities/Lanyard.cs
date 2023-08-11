#nullable disable

using System.Text.Json.Serialization;

namespace Sudokoko.PersonalSite.Entities;

[Serializable]
public class Lanyard
{
    [JsonPropertyName("data")]
    public LanyardData Data { get; set; }

    [Serializable]
    public class LanyardData
    {
        [JsonPropertyName("activities")]
        public List<LanyardActivity> Activities { get; set; }
    }
}

[Serializable]
public class LanyardActivity
{
    [JsonPropertyName("application_id")]
    public string ApplicationId { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("state")]
    public string State { get; set; }

    [JsonPropertyName("details")]
    public string Details { get; set; }

    [JsonPropertyName("assets")]
    public LanyardActivityAssets Assets { get; set; }

    [Serializable]
    public class LanyardActivityAssets
    {
        [JsonPropertyName("large_image")]
        public string LargeImage { get; set; }
    }
}