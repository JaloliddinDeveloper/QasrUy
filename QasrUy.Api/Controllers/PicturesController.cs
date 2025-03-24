using Microsoft.AspNetCore.Mvc;
using QasrUy.Api.Brokers.Storages;
using QasrUy.Api.Models.Pictures;
using QasrUy.Api.Services.Foundations.PictureServices;
using RESTFulSense.Controllers;

namespace QasrUy.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PicturesController : RESTFulController
    {
        private readonly IStorageBroker storageBroker;
        private readonly IPictureService pictureService;

        private readonly string uploadsFolder = "/var/www/files";
        private readonly string baseUrl = "http://165.232.173.157";

        public PicturesController(
            IStorageBroker storageBroker,
            IPictureService pictureService)
        {
            this.storageBroker = storageBroker;
            this.pictureService = pictureService;
        }

        [HttpPost]
        public async Task<IActionResult> PostPictureAsync([FromForm] Picture newModel, IFormFile newPicture)
        {
            try
            {
                if (newModel == null)
                    return BadRequest("New data is missing.");

                if (newPicture == null || newPicture.Length == 0)
                    return BadRequest("NewPicture is required.");

                if (!Directory.Exists(uploadsFolder))
                {
                    Directory.CreateDirectory(uploadsFolder);
                }

                string fileName = $"{Guid.NewGuid()}{Path.GetExtension(newPicture.FileName)}";
                string filePath = Path.Combine(uploadsFolder, fileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await newPicture.CopyToAsync(fileStream);
                }

                string fileUrl = $"{baseUrl}/files/{fileName}";
                newModel.PictureUrl = fileUrl;
              

                await this.pictureService.AddPictureAsync(newModel);

                return Created(newModel);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}