// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using MonkeyCache.Tests;
//
//    var data = Monkey.FromJson(jsonString);
//
namespace MonkeyCache.Tests
{
    using System;
    using System.Net;
    using System.Collections.Generic;
	using System.Text.Json;
	using System.Text.Json.Serialization;

	public partial class Monkey
    {
        [JsonPropertyName("Details")]
        public string Details { get; set; }

        [JsonPropertyName("Image")]
        public string Image { get; set; }

        [JsonPropertyName("Location")]
        public string Location { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("Population")]
        public long Population { get; set; }
    }

    public partial class Monkey
    {
        public static Monkey[] FromJson(string json) => JsonSerializer.Deserialize<Monkey[]>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Monkey[] self) => JsonSerializer.Serialize(self, Converter.Settings);
    }

    public class Converter
    {
        public static readonly JsonSerializerOptions Settings = new JsonSerializerOptions
        {
            //MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            //DateParseHandling = DateParseHandling.None,
        };
    }
}
