using System;
namespace AppProject
{
	public class Korisnik
	{
		private String ime;
		private String prezime;
		private DateTime datum_rodjenja;
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

		public DateTime Datum_rodjenja
		{
			get
			{
				return datum_rodjenja;
			}

			set
			{
				datum_rodjenja = value;
			}
		}

		public Korisnik(string ime, string prezime, DateTime datum_rodjenja, double visina, double tezina)
		{
			this.Ime = ime;
			this.Prezime = prezime;
			this.Datum_rodjenja = datum_rodjenja;
			this.Visina = visina;
			this.Tezina = tezina;
		}
	}
}
