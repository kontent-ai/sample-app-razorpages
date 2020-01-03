using Kentico.Kontent.Delivery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KenticoKontentModels
{
    public class Cafe
    {
        public const string Codename = "cafe";
        public const string PhoneCodename = "phone";
        public const string CityCodename = "city";
        public const string PhotoCodename = "photo";
        public const string EmailCodename = "email";
        public const string CountryCodename = "country";
        public const string StreetCodename = "street";
        public const string StateCodename = "state";
        public const string ZipCodeCodename = "zip_code";

        public string Phone { get; set; }
        public string City { get; set; }
        public IEnumerable<Asset> Photo { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string Street { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public ContentItemSystemAttributes System { get; set; }
    }
}
