using JetBrains.Annotations;
using Microsoft.Extensions.Logging;
using Service.Grpc;
using Service.TutorialHealth.Grpc;

namespace Service.TutorialHealth.Client
{
	[UsedImplicitly]
	public class TutorialHealthClientFactory : GrpcClientFactory
	{
		public TutorialHealthClientFactory(string grpcServiceUrl, ILogger logger) : base(grpcServiceUrl, logger)
		{
		}

		public IGrpcServiceProxy<ITutorialHealthService> GetTutorialHealthService() => CreateGrpcService<ITutorialHealthService>();
	}
}