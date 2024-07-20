using QasrUy.Api.Models.Houses;

namespace QasrUy.Api.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<House> InsertHouseAsync(House house); 
        IQueryable<House> SelectAllHouses();
        ValueTask<House> SelectHouseByIdAsync(int houseId);
        ValueTask<House> UpdateHouseAsync(House house);
        ValueTask<House> DeleteHouseAsync(House house);
    }
}
