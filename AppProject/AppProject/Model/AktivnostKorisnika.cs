using System;
namespace AppProject
{
	public class AktivnostKorisnika
	{
		private int id;
		private int k_id;
		private int ta_id;
		private String naziv;
		private String tip;
		private DateTime datum;
		private DateTime vrijeme_pocetka, vrijeme_kraja;
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

		public int K_id
		{
			get
			{
				return k_id;
			}

			set
			{
				k_id = value;
			}
		}

		public int Ta_id
		{
			get
			{
				return ta_id;
			}

			set
			{
				ta_id = value;
			}
		}

		public DateTime Vrijeme_kraja
		{
			get
			{
				return vrijeme_kraja;
			}

			set
			{
				vrijeme_kraja = value;
			}
		}

		public DateTime Vrijeme_pocetka
		{
			get
			{
				return vrijeme_pocetka;
			}

			set
			{
				vrijeme_pocetka = value;
			}
		}

		public String Tip
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

		public AktivnostKorisnika(int id,int k_id, int ta_id, string naziv, DateTime datum, DateTime vrijeme_pocetka, 
		                          DateTime vrijeme_kraja, double potrosnja)
		{
			this.Id = id;
			this.K_id = k_id;
			this.Ta_id = ta_id;
			this.Naziv = naziv;
			this.Datum = datum;
			this.Vrijeme_pocetka = vrijeme_pocetka;
			this.Vrijeme_kraja = vrijeme_kraja;
			this.Potrosnja = potrosnja;
		}
	}
}
