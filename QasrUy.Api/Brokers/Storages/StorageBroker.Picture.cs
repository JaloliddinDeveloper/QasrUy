using Microsoft.EntityFrameworkCore;
using QasrUy.Api.Models.Pictures;

namespace QasrUy.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Picture> Pictures { get; set; }

        public async ValueTask<Picture> InsertPictureAsync(Picture picture)=>
            await InsertAsync(picture);
       
        public IQueryable<Picture> SelectAllPicture()=>
            SelectAll<Picture>();
       
        public async ValueTask<Picture> SelectByIdPictureAsync(int pictureId)=>
            await SelectAsync<Picture>(pictureId);
       
        public async ValueTask<Picture> UpdatePictureAsync(Picture picture)=>
            await UpdateAsync(picture);
      
        public async ValueTask<Picture> DeletePictureAsync(Picture picture)=>
            await DeleteAsync(picture);  
    }
}
