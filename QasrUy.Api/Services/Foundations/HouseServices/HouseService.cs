using QasrUy.Api.Brokers.Storages;
using QasrUy.Api.Models.Houses;

namespace QasrUy.Api.Services.Foundations.HouseServices
{
    public class HouseService : IHouseService
    {
        private readonly IStorageBroker storageBroker;

        public HouseService(IStorageBroker storageBroker) =>
            this.storageBroker = storageBroker;

        public async ValueTask<House> AddHouseAsync(House house) =>
            await this.storageBroker.InsertHouseAsync(house);

        public IQueryable<House> RetrieveAllHouses() =>
            this.storageBroker.SelectAllHouses();

        public async ValueTask<House> RetrieveHouseByIdAsync(int houseId) =>
            await this.storageBroker.SelectHouseByIdAsync(houseId);

        public async ValueTask<House> ModifyHouseAsync(House house) =>
            await this.storageBroker.UpdateHouseAsync(house);

        public async ValueTask<House> RemoveHouseAsync(int houseId)
        {
            House maybeHouse = await this.storageBroker.SelectHouseByIdAsync(houseId);

            return await this.storageBroker.DeleteHouseAsync(maybeHouse);
        }
    }
}
