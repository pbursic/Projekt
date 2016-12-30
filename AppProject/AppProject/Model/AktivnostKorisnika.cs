using System;
namespace AppProject
{
	public class AktivnostKorisnika
	{
		private int id;
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

		public int Id
		{
			get
			{
				return id;
			}

			set
			{
				id = value;
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
