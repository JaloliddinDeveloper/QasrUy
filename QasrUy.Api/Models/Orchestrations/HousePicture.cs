using QasrUy.Api.Models.Houses;
using QasrUy.Api.Models.Pictures;

namespace QasrUy.Api.Models.Orchestrations
{
    public class HousePicture
    {
        public House House { get; set; }
        public List<Picture>  Pictures { get; set; }    
    }
}
