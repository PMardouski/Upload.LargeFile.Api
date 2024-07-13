using Microsoft.AspNetCore.Mvc;
using Upload.LargeFile.Api.Services;
using Upload.LargeFile.Api.Utilities;

namespace Upload.LargeFile.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FileController : Controller
    {
        private readonly IFileService fileService;

        public FileController(IFileService fileService)
        {
            this.fileService = fileService;
        }

        [HttpPost("upload-stream-multipartreader")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status415UnsupportedMediaType)]
        [MultipartFormData]
        [DisableFormValueModelBinding]
        public async Task<IActionResult> Upload()
        {
            var result = await this.fileService.UploadFileAsync(Request.Body, Request.ContentType!);

            return CreatedAtAction(nameof(Upload), result);
        }
    }
}
