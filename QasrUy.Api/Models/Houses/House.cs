using QasrUy.Api.Models.Pictures;
using System.Text.Json.Serialization;

namespace QasrUy.Api.Models.Houses
{
    public class House
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string HomeType { get; set; }
        public int SelectedRoom { get; set; }
        public int HomeSquare { get; set; }
        public int HomeFloor { get; set; }
        public int HomeAllFloor { get; set; }
        public string SelectedAmenities { get; set; }
        public string HomePrice { get; set; }
        public string HomeRegion { get; set; }
        public string HomeDistrict { get; set; }
        public string HomeAddress { get; set; }
        public string HomeSituation { get; set; }
        public string HomeLocationAddress { get; set; }
        public string HomeLocationLatLng { get; set; }
        public string PhoneNumber { get; set; }

        [JsonIgnore]
        public ICollection<Picture>? Pictures { get; set; } 
    }
}
