using MyJetWallet.Sdk.Service;
using MyYamlParser;

namespace Service.TutorialHealth.Settings
{
	public class SettingsModel
	{
		[YamlProperty("TutorialHealth.SeqServiceUrl")]
		public string SeqServiceUrl { get; set; }

		[YamlProperty("TutorialHealth.ZipkinUrl")]
		public string ZipkinUrl { get; set; }

		[YamlProperty("TutorialHealth.ElkLogs")]
		public LogElkSettings ElkLogs { get; set; }

		[YamlProperty("TutorialHealth.EducationProgressServiceUrl")]
		public string EducationProgressServiceUrl { get; set; }

		[YamlProperty("TutorialHealth.EducationRetryServiceUrl")]
		public string EducationRetryServiceUrl { get; set; }

		[YamlProperty("TutorialHealth.UserRewardServiceUrl")]
		public string UserRewardServiceUrl { get; set; }

		[YamlProperty("TutorialHealth.UserProgressServiceUrl")]
		public string UserProgressServiceUrl { get; set; }
	}
}