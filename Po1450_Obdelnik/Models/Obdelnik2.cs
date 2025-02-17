namespace Po1450_Obdelnik.Models
{
	public class Obdelnik2
	{
		public int StranaA { get; set; }
		public int StranaB { get; set; }

		public int Obvod => 2 * (StranaA + StranaB);
		public int Obsah => StranaA * StranaB;
		public double Uhlopricka => Math.Sqrt(StranaA * StranaA + StranaB * StranaB);

	}
}
