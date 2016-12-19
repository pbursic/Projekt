using System;
namespace AppProject
{
	public class AktivnostKorisnika
	{
		private String naziv;
		private DateTime datum;
		private DateTime vrijeme;
		private double potrosnja;

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

		public DateTime Datum
		{
			get
			{
				return datum;
			}

			set
			{
				datum = value;
			}
		}

		public DateTime Vrijeme
		{
			get
			{
				return vrijeme;
			}

			set
			{
				vrijeme = value;
			}
		}

		public double Potrosnja
		{
			get
			{
				return potrosnja;
			}

			set
			{
				potrosnja = value;
			}
		}

		public AktivnostKorisnika(string naziv, DateTime datum, DateTime vrijeme, double potrosnja)
		{
			this.Naziv = naziv;
			this.Datum = datum;
			this.Vrijeme = vrijeme;
			this.Potrosnja = potrosnja;
		}
	}
}
