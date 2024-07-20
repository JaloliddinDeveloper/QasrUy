using QasrUy.Api.Models.Houses;

namespace QasrUy.Api.Services.Foundations.HouseServices
{
    public interface IHouseService
    {
        ValueTask<House> AddHouseAsync(House house);    
        IQueryable<House> RetrieveAllHouses();
        ValueTask<House> RetrieveHouseByIdAsync(int houseId);
        ValueTask<House> ModifyHouseAsync(House house);
        ValueTask<House> RemoveHouseAsync(House house); 
    }
}
