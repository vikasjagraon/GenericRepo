using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CodeWithParveenYadav.Models
{
    public class CompletionRequest
    {
        [JsonPropertyName("model")]
        public string? Model
        {
            get;
            set;
        }

        [JsonPropertyName("prompt")]
        public string? Prompt
        {
            get;
            set;
        }

        [JsonPropertyName("max_tokens")]
        public int? MaxTokens
        {
            get;
            set;
        }
    }
}
