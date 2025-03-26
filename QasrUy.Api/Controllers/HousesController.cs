using Microsoft.AspNetCore.Mvc;
using QasrUy.Api.Models.Houses;
using QasrUy.Api.Models.Orchestrations;
using QasrUy.Api.Services.Foundations.HouseServices;
using QasrUy.Api.Services.Orchestrations;
using RESTFulSense.Controllers;

namespace QasrUy.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HousesController : RESTFulController
    {
        private readonly IHouseService houseService;
        private readonly IHouseOrchestrationService 
            houseOrchestrationService;

        public HousesController(
            IHouseService houseService,
            IHouseOrchestrationService 
                houseOrchestrationService)
        {
            this.houseService = houseService;
            this.houseOrchestrationService = 
                houseOrchestrationService;
        }

        [HttpPost]
        public async ValueTask<ActionResult<House>> PostHouseAsync(House house)
        {
            try
            {
                House storageHouse =
                    await this.houseService.AddHouseAsync(house);

                return Created(storageHouse);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpGet]
        public ActionResult<IQueryable<HousePicture>> GetAllHousesWithPictures()
        {
            try
            {
                IQueryable<HousePicture> allHouseswithPictures = this.houseOrchestrationService.ProcessHouseWithPicturesAsync();

                return Ok(allHouseswithPictures);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{houseId}")]
        public async ValueTask<ActionResult<House>> GetHouseAsync(int houseId)
        {
            try
            {
                House storageHouse =
                    await this.houseService.RetrieveHouseByIdAsync(houseId);
                return Ok(storageHouse);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpDelete("{houseId}")]
        public async ValueTask<ActionResult<House>> DeleteHouseAsync(int houseId)
        {
            try
            {
                House storageHouse =
                    await this.houseService.RemoveHouseAsync(houseId);
                return Ok(storageHouse);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }
    }
}
