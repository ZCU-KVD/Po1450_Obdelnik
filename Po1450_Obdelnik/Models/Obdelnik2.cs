namespace Po1450_Obdelnik.Models
{
	public class Obdelnik2
	{
		private int stranaA;
		private int stranaB;

		public int StranaA
		{
			get => stranaA; 
			set
			{
				if (stranaA != value)
				{
					if (value >= 0)
					{
						stranaA = value;

					}
				}
				
			}
		}
		public int StranaB { get => stranaB; set => stranaB = Math.Abs(value); }

		public int Obvod => 2 * (StranaA + StranaB);
		public int Obsah => StranaA * StranaB;
		public double Uhlopricka => Math.Sqrt(StranaA * StranaA + StranaB * StranaB);

	}
}
