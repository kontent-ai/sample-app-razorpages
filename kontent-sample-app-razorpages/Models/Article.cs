using System;
using System.Collections.Generic;
using Kentico.Kontent.Delivery.Abstractions;
using Newtonsoft.Json;

namespace kontent_sample_app_razorpages.Models
{
    public partial class Article
    {
        [JsonProperty("body_copy")]
        public string BodyCopyString { get; set; }
    }
}