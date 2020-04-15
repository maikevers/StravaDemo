using Microsoft.AspNetCore.Mvc;
using StravaDemo.StravaClients.Upload;

namespace StravaDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UploadTcxController : ControllerBase
    {
        private readonly UploadClient _uploadClient;

        public UploadTcxController(UploadClient uploadClient)
        {
            _uploadClient = uploadClient;
        }

        [HttpPost]
        public UploadStatusDto Upload([FromBody] ActivityUploadDto activityUploadDto)
        {
            return _uploadClient.UploadFile(activityUploadDto);
        }
    }
}
