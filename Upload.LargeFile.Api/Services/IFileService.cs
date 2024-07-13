using Upload.LargeFile.Api.Models;

namespace Upload.LargeFile.Api.Services
{
    public interface IFileService
    {
        Task<FileUploadSummury> UploadFileAsync(Stream fileStream, string contentType);
    }
}
