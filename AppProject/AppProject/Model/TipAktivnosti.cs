using System;
namespace AppProject
{
	public class TipAktivnosti
	{
		private int id;
		private String naziv;
		private String jedinicaMjere;
		private double kcalPoJediniciMjere;

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

		public string JedinicaMjere
		{
			get
			{
				return jedinicaMjere;
			}

			set
			{
				jedinicaMjere = value;
			}
		}

		public double KcalPoJediniciMjere
		{
			get
			{
				return kcalPoJediniciMjere;
			}

			set
			{
				kcalPoJediniciMjere = value;
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

		public TipAktivnosti(int id, string naziv, string jedinicaMjere, double kcalPoJediniciMjere)
		{
			this.Id = id;
			this.Naziv = naziv;
			this.JedinicaMjere = jedinicaMjere;
			this.KcalPoJediniciMjere = kcalPoJediniciMjere;
		}
	}
}
