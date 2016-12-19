using System;
namespace AppProject
{
	public class Korisnik
	{
		private String ime;
		private String prezime;
		private int dob;
		private double visina;
		private double tezina;

		public string Ime
		{
			get
			{
				return ime;
			}

			set
			{
				ime = value;
			}
		}

		public string Prezime
		{
			get
			{
				return prezime;
			}

			set
			{
				prezime = value;
			}
		}

		public int Dob
		{
			get
			{
				return dob;
			}

			set
			{
				dob = value;
			}
		}

		public double Visina
		{
			get
			{
				return visina;
			}

			set
			{
				visina = value;
			}
		}

		public double Tezina
		{
			get
			{
				return tezina;
			}

			set
			{
				tezina = value;
			}
		}

		public Korisnik(string ime, string prezime, int dob, double visina, double tezina)
		{
			this.Ime = ime;
			this.Prezime = prezime;
			this.Dob = dob;
			this.Visina = visina;
			this.Tezina = tezina;
		}
	}
}
