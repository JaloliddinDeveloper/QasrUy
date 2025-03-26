namespace QasrUy.Api.Models.Pictures
{
    public class Picture
    {
        public Guid Id { get; set; }= Guid.NewGuid();
        public string PictureUrl { get; set; }
        public int HouseId { get; set; }    
    }
}
