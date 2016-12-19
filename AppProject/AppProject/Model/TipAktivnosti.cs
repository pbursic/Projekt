using System;
namespace AppProject
{
	public class TipAktivnosti
	{
		private String naziv;
		private String tip;
		private double kalorijeJedinica;

		public string Naziv
		{
			get
			{
				return naziv;
			}

			set
			{
				naziv = value;
			}
		}

		public string Tip
		{
			get
			{
				return tip;
			}

			set
			{
				tip = value;
			}
		}

		public double KalorijeJedinica
		{
			get
			{
				return kalorijeJedinica;
			}

			set
			{
				kalorijeJedinica = value;
			}
		}

		public TipAktivnosti(string naziv, string tip, double kalorijeJedinica)
		{
			this.Naziv = naziv;
			this.Tip = tip;
			this.KalorijeJedinica = kalorijeJedinica;
		}
	}
}
