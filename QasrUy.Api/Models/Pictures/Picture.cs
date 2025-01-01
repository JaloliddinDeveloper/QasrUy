using QasrUy.Api.Models.Houses;

namespace QasrUy.Api.Models.Pictures
{
    public class Picture
    {
        public int Id { get; set; }
        public string PictureUrl { get; set; }
        public int HouseId { get; set; }
        public House House { get; set; }    
    }
}
