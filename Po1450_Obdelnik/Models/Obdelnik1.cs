namespace Po1450_Obdelnik.Models
{
	public class Obdelnik1
	{
		public int StranaA { get; set; }
		public int StranaB { get; set; }

		public int Obvod;
		public int Obsah;
		public double Uhlopricka;
		private void VypocetObvod()
		{
			Obvod = 2 * (StranaA + StranaB);
		}
		private void VypocetObsah()
		{
			Obsah = StranaA * StranaB;
		}
		private void VypocetUhlopricka()
		{
			Uhlopricka = Math.Sqrt(StranaA * StranaA + StranaB * StranaB);
		}
		public void Vypocet()
		{
			VypocetObsah();
			VypocetObvod();
			VypocetUhlopricka();
		}

	}
}
