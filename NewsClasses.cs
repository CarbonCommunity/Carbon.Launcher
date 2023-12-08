using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Carbon.Launcher
{
    public class A10Link
    {
        [JsonProperty("@rel")]
        public string rel { get; set; }

        [JsonProperty("@href")]
        public string href { get; set; }
    }

    public class Channel
    {
        [JsonProperty("@xml:base")]
        public string xmlbase { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string lastBuildDate { get; set; }
        public List<Item> item { get; set; }
    }

    public class Guid
    {
        [JsonProperty("@isPermaLink")]
        public string isPermaLink { get; set; }

        [JsonProperty("#text")]
        public string text { get; set; }
    }

    public class Item
    {
        public Guid guid { get; set; }
        public string link { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string pubDate { get; set; }

        [JsonProperty("a10:link")]
        public A10Link a10link { get; set; }

        [JsonProperty("a10:updated")]
        public DateTime a10updated { get; set; }
    }

    public class Root
    {
        [JsonProperty("?xml")]
        public Xml xml { get; set; }
        public Rss rss { get; set; }
    }

    public class Rss
    {
        [JsonProperty("@xmlns:a10")]
        public string xmlnsa10 { get; set; }

        [JsonProperty("@version")]
        public string version { get; set; }
        public Channel channel { get; set; }
    }

    public class Xml
    {
        [JsonProperty("@version")]
        public string version { get; set; }

        [JsonProperty("@encoding")]
        public string encoding { get; set; }
    }
}
