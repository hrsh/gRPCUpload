using Grpc.Core;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using UploadFileServer;

namespace Server.Services
{
    public class UploadService : FileUploade.FileUploadeBase
    {
        private readonly ILogger<UploadService> _logger;

        public UploadService(ILogger<UploadService> logger)
        {
            _logger = logger;
        }

        public override Task<UploadResponse> SaveFile(UploadRequest request, ServerCallContext context)
        {
            _logger.LogInformation("Start uploading file ...");
            return Task.FromResult(new UploadResponse
            {
                Filename = "",
                Filepath = "",
                Result = true,
                ResultType = UploadResponse.Types.UploadResultType.Saved
            });
        }
    }
}
