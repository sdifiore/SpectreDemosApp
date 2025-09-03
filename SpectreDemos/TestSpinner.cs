using Spectre.Console;

namespace SpectreDemos
{
	public class TestSpinner : Spinner
	{
		public override TimeSpan Interval => TimeSpan.FromMilliseconds(200);

		public override bool IsUnicode => true;

		public override IReadOnlyList<string> Frames =>
			new[] { "Ooooo", "oOooo", "ooOoo", "oooOo", "ooooO" };
	}
}
