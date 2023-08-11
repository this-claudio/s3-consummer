using Amazon.S3;
using Amazon.S3.Model;
using Microsoft.AspNetCore.Mvc;

namespace s3_consumer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IAmazonS3 amazonS3;

        public WeatherForecastController(IAmazonS3 amazonS3) 
        { 
            this.amazonS3 = amazonS3;
        }


        [HttpGet(Name = "/GetImage")]
        public async Task<IActionResult> GetImage([FromQuery] string imageName)
        {
            var Request = new GetObjectRequest()
            {
                BucketName = "seu-bucket",
                Key = imageName
            };

            var response = await this.amazonS3.GetObjectAsync(Request);
            var responseStream = response.ResponseStream;
            var stream = new MemoryStream();
            await responseStream.CopyToAsync(stream);
            stream.Position = 0;

            return new FileStreamResult(stream, response.Headers["Content-type"])
            {
                FileDownloadName = imageName
            };
        }
    }
}