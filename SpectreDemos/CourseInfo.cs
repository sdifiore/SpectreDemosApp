namespace SpectreDemos
{
	public record CourseInfo(
		string CourseName = "",
		int CourseLessonCount = 0,
		double CourseLengthInHours = 0,
		int Level = 0,
		int Duration = 0);
}
