using QasrUy.Api.Models.Orchestrations;

namespace QasrUy.Api.Services.Orchestrations
{
    public interface IHouseOrchestrationService
    {
        IQueryable<HousePicture> ProcessHouseWithPicturesAsync();
    }
}