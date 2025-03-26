using QasrUy.Api.Models.Orchestrations;
using QasrUy.Api.Services.Foundations.HouseServices;
using QasrUy.Api.Services.Foundations.PictureServices;
using System.Drawing;

namespace QasrUy.Api.Services.Orchestrations
{
    public class HouseOrchestrationService : IHouseOrchestrationService
    {
        private readonly IHouseService houseService;
        private readonly IPictureService pictureService;

        public HouseOrchestrationService(
            IHouseService houseService, 
            IPictureService pictureService)
        {
            this.houseService = houseService;
            this.pictureService = pictureService;
        }

        public IQueryable<HousePicture> ProcessHouseWithPicturesAsync()
        {
            // Fetch all groups and students separately
            var groups = (this.houseService.RetrieveAllHouses()).ToList();
            var students = (this.pictureService.RetrieveAllPictures()).ToList();

            // Link students to their respective groups in memory
            var groupStudents = groups.Select(group => new HousePicture
            {
                House = group,
                Pictures = students.Where(student => student.HouseId == group.Id).ToList()
            });

            return groupStudents.AsQueryable();
        }
    }
}
