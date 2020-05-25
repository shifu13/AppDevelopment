using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace testing.Data
{
    public partial class Welcome
    {
        [JsonProperty("docs")]
        public List<Doc> Docs { get; set; }

        [JsonProperty("pages")]
        public Pages Pages { get; set; }

        [JsonProperty("items")]
        public Items Items { get; set; }
    }

    public partial class Doc
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class Items
    {
        [JsonProperty("begin")]
        public object Begin { get; set; }

        [JsonProperty("end")]
        public object End { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }
    }

    public partial class Pages
    {
        [JsonProperty("current")]
        public long Current { get; set; }

        [JsonProperty("prev")]
        public long Prev { get; set; }

        [JsonProperty("hasPrev")]
        public bool HasPrev { get; set; }

        [JsonProperty("next")]
        public long Next { get; set; }

        [JsonProperty("hasNext")]
        public bool HasNext { get; set; }

        [JsonProperty("total")]
        public object Total { get; set; }
    }
}
