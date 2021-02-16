using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace YaRemoteTv.Api.Models
{
    public class Payload
    {
        // TODO: Unused yet.
    }

    public class Button
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("payload")]
        public Payload Payload { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("hide")]
        public bool Hide { get; set; }
    }

    public class Response
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("tts")]
        public string Tts { get; set; }

        [JsonPropertyName("buttons")]
        public List<Button> Buttons { get; set; }

        [JsonPropertyName("end_session")]
        public bool EndSession { get; set; }
    }

    public class YandexApiResponseModel
    {
        [JsonPropertyName("response")]
        public Response Response { get; set; }

        [JsonPropertyName("version")]
        public string Version { get; set; }
    }
}