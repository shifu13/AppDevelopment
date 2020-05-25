using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace testing.Data
{
    class Quote
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }
    }
}
