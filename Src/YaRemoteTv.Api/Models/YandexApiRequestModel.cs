using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace YaRemoteTv.Api.Models
{
    public class Screen
    {
    }

    public class AccountLinking
    {
    }

    public class Interfaces
    {
        [JsonPropertyName("screen")]
        public Screen Screen { get; set; }

        [JsonPropertyName("account_linking")]
        public AccountLinking AccountLinking { get; set; }
    }

    public class Meta
    {
        [JsonPropertyName("locale")]
        public string Locale { get; set; }

        [JsonPropertyName("timezone")]
        public string Timezone { get; set; }

        [JsonPropertyName("client_id")]
        public string ClientId { get; set; }

        [JsonPropertyName("interfaces")]
        public Interfaces Interfaces { get; set; }
    }

    public class Markup
    {
        [JsonPropertyName("dangerous_context")]
        public bool DangerousContext { get; set; }
    }

    public class Tokens
    {
        [JsonPropertyName("start")]
        public int Start { get; set; }

        [JsonPropertyName("end")]
        public int End { get; set; }
    }

    public class Entity
    {
        [JsonPropertyName("tokens")]
        public Tokens Tokens { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("value")]
        public object Value { get; set; }
    }

    public class Nlu
    {
        [JsonPropertyName("tokens")]
        public List<string> Tokens { get; set; }

        [JsonPropertyName("entities")]
        public List<Entity> Entities { get; set; }
    }

    public class Request
    {
        [JsonPropertyName("command")]
        public string Command { get; set; }

        [JsonPropertyName("original_utterance")]
        public string OriginalUtterance { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("markup")]
        public Markup Markup { get; set; }

        [JsonPropertyName("payload")]
        public Payload Payload { get; set; }

        [JsonPropertyName("nlu")]
        public Nlu Nlu { get; set; }
    }

    public class User
    {
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }
    }

    public class Application
    {
        [JsonPropertyName("application_id")]
        public string ApplicationId { get; set; }
    }

    public class Session
    {
        [JsonPropertyName("message_id")]
        public int MessageId { get; set; }

        [JsonPropertyName("session_id")]
        public string SessionId { get; set; }

        [JsonPropertyName("skill_id")]
        public string SkillId { get; set; }

        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        [JsonPropertyName("user")]
        public User User { get; set; }

        [JsonPropertyName("application")]
        public Application Application { get; set; }

        [JsonPropertyName("new")]
        public bool New { get; set; }
    }

    public class YandexApiRequestModel
    {
        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }

        [JsonPropertyName("request")]
        public Request Request { get; set; }

        [JsonPropertyName("session")]
        public Session Session { get; set; }

        [JsonPropertyName("version")]
        public string Version { get; set; }
    }
}