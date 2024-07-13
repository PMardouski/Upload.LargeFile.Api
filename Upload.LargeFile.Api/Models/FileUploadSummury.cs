namespace Upload.LargeFile.Api.Models
{
    public class FileUploadSummury
    {
        public int TotalFilesUploaded { get; set; }
        public string? TotalSizeUploaded { get; set; }
        public List<string>? FilePaths { get; set; }
        public List<string>? NotUploadedFiles { get; set; }
    }
}
