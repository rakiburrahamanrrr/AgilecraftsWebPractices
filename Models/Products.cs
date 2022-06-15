using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AgilecraftsWebPractices.Models
{
    public class Products
    {
        public string Id { get; set; }
        public string Maker { get; set; }
        [JsonPropertyName("img")]
        public string Image { get; set; }
        public string URL { get; set; }
        public string Title { get; set; }
        public string Descriptions { get; set; }
        public int[] Ratings { get; set; }

         public override string ToString() => JsonSerializer.Serialize<Products>(this);
    }
}
