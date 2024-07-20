using QasrUy.Api.Models.Pictures;

namespace QasrUy.Api.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Picture> InsertPictureAsync(Picture picture); 
        IQueryable<Picture> SelectAllPicture();
        ValueTask<Picture> SelectByIdPictureAsync(int pictureId);
        ValueTask<Picture> UpdatePictureAsync(Picture picture);
        ValueTask<Picture> DeletePictureAsync(Picture picture);
    }
}
