using Kentico.Kontent.Delivery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KenticoKontentModels
{
    public class FactAboutUs
    {
        public const string Codename = "fact_about_us";
        public const string DescriptionCodename = "description";
        public const string TitleCodename = "title";
        public const string ImageCodename = "image";

        public IRichTextContent Description { get; set; }
        public string Title { get; set; }
        public IEnumerable<Asset> Image { get; set; }
        public ContentItemSystemAttributes System { get; set; }
    }
}
