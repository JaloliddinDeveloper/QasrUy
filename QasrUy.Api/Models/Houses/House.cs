using QasrUy.Api.Models.Pictures;
using System.Text.Json.Serialization;

namespace QasrUy.Api.Models.Houses
{
    public class House
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PhoneNumber { get; set; }

        [JsonIgnore]
        public ICollection<Picture>? Pictures { get; set; } 
    }
}
