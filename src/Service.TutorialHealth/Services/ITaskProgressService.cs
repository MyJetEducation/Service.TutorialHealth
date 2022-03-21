using System;
using System.Threading.Tasks;
using Service.Education.Structure;
using Service.TutorialHealth.Grpc.Models.State;
using Service.TutorialHealth.Grpc.Models.Task;
using Service.TutorialHealth.Models;

namespace Service.TutorialHealth.Services
{
	public interface ITaskProgressService
	{
		ValueTask<TestScoreGrpcResponse> SetTaskProgressAsync(Guid? userId, EducationStructureUnit unit, EducationStructureTask task, bool isRetry, TimeSpan duration, int? progress = null);

		ValueTask<StateGrpcModel> GetUnitProgressAsync(Guid? userId, int unit);

		ValueTask<TaskTypeProgressInfo> GetTotalProgressAsync(Guid? userId, int? unit = null);
	}
}
