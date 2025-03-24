using QasrUy.Api.Brokers.Storages;
using QasrUy.Api.Models.Pictures;

namespace QasrUy.Api.Services.Foundations.PictureServices
{
    public class PictureService: IPictureService
    {
        private readonly IStorageBroker storageBroker;

        public PictureService(IStorageBroker storageBroker)
        {
            this.storageBroker = storageBroker;
        }

        public async ValueTask<Picture> AddPictureAsync(Picture picture)=>
            await this.storageBroker.InsertPictureAsync(picture);

        public IQueryable<Picture> RetrieveAllPictures()=>
            storageBroker.SelectAllPicture();
       
        public async ValueTask<Picture> RetrievePictureByIdAsync(int pictureId)=>
            await this.storageBroker.SelectByIdPictureAsync(pictureId);
       
        public async ValueTask<Picture> ModifyPictureAsync(Picture picture) =>
            await this.storageBroker.UpdatePictureAsync(picture);
      
        public async ValueTask<Picture> RemovePictureAsync(int pictureId)
        {
            Picture picture =
                await this.storageBroker.SelectByIdPictureAsync(pictureId);

            return await this.storageBroker.DeletePictureAsync(picture);
        }
    }
}
