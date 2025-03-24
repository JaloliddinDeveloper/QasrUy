using QasrUy.Api.Models.Pictures;

namespace QasrUy.Api.Services.Foundations.PictureServices
{
    public interface IPictureService
    {
        ValueTask<Picture> AddPictureAsync(Picture picture);
        IQueryable<Picture> RetrieveAllPictures();
        ValueTask<Picture> RetrievePictureByIdAsync(int pictureId);
        ValueTask<Picture> ModifyPictureAsync(Picture picture);
        ValueTask<Picture> RemovePictureAsync(int pictureId);
    }
}
