using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;

namespace ApiFundamentals.API.Controllers
{
    [Route("api/files")]
    [ApiController]
    [Authorize]
    public class FilesController : ControllerBase
    {
        private readonly FileExtensionContentTypeProvider _fileExtensionContentTypeProvider;

        public FilesController(FileExtensionContentTypeProvider fileExtensionContentTypeProvider)
        {
            _fileExtensionContentTypeProvider = fileExtensionContentTypeProvider 
                ?? throw new System.ArgumentNullException(
                    nameof(fileExtensionContentTypeProvider));
        }


        [HttpGet("{fileId}")]
        public ActionResult GetFile(string fileId)
        {
            var filePath = "fileToDownload.txt";

            if (!System.IO.File.Exists(filePath))
            {
                return NotFound();
            }

            //Gets the contentType of the file to return
            if (!_fileExtensionContentTypeProvider.TryGetContentType(filePath, out var contentType))
            {
                contentType = "application/octet-stream";
            }

            var bytes = System.IO.File.ReadAllBytes(filePath);

            return File(bytes, contentType, Path.GetFileName(filePath));
        }
    }
}
