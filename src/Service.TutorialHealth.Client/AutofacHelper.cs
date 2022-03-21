using Autofac;
using Microsoft.Extensions.Logging;
using Service.Grpc;
using Service.TutorialHealth.Grpc;

// ReSharper disable UnusedMember.Global

namespace Service.TutorialHealth.Client
{
	public static class AutofacHelper
	{
		public static void RegisterTutorialHealthClient(this ContainerBuilder builder, string grpcServiceUrl, ILogger logger)
		{
			var factory = new TutorialHealthClientFactory(grpcServiceUrl, logger);

			builder.RegisterInstance(factory.GetTutorialHealthService()).As<IGrpcServiceProxy<ITutorialHealthService>>().SingleInstance();
		}
	}
}
