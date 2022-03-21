using Service.Education.Structure;

namespace Service.TutorialHealth.Helper
{
	public static class TutorialHelper
	{
		public static readonly EducationTutorial Tutorial = EducationTutorial.HealthAndFinance;

		public static readonly EducationStructureTutorial StructureTutorial = EducationStructure.Tutorials[Tutorial];
	}
}