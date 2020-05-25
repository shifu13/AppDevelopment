using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace testing.Data
{
    public partial class Movie
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("resume")]
        public string Resume { get; set; }

        [JsonProperty("director")]
        public string Director { get; set; }

        [JsonProperty("writer")]
        public string Writers { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }
    }
}
