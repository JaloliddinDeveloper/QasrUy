using Microsoft.EntityFrameworkCore;
using QasrUy.Api.Models.Houses;

namespace QasrUy.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<House> Houses { get; set; }

        public async ValueTask<House> InsertHouseAsync(House house)=>
            await InsertAsync(house);
      
        public IQueryable<House> SelectAllHouses()=>
            SelectAll<House>();
       
        public async ValueTask<House> SelectHouseByIdAsync(int houseId)=>
            await SelectAsync<House>(houseId);
        
        public async ValueTask<House> UpdateHouseAsync(House house)=>
            await UpdateAsync(house);
  
        public async ValueTask<House> DeleteHouseAsync(House house)=>
            await DeleteAsync(house);
    }
}
