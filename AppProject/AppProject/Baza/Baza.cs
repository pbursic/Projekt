using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace AppProject
{
	public static class Baza
	{
		static SQLiteConnection konekcija = new SQLiteConnection("Data Source=baza.db");

		//Skripta za stvaranje tablice sa korisnicima, tipovima aktivnosti
		public static void Db()
		{
			konekcija.Open();

			//Tablica korisnici
			string korisnici = "CREATE TABLE IF NOT EXISTS korisnici (id integer primary key autoincrement, " +
				"ime nvarchar(20), prezime nvarchar(30), datum_rodjenja datetime, visina integer, tezina integer)";
			SQLiteCommand korisnicicreate = new SQLiteCommand(korisnici, konekcija);
			korisnicicreate.ExecuteNonQuery();

			//Tablica tipoviaktivnosti
			string tipakt= "CREATE TABLE IF NOT EXISTS tipoviaktivnosti (id integer primary key autoincrement," +
				"naziv nvarchar(35), jedinica_mjere nvarchar(10), potrosnja float)";
			SQLiteCommand tipaktcreate = new SQLiteCommand(tipakt, konekcija);
			tipaktcreate.ExecuteNonQuery();

			konekcija.Close();

			korisnicicreate.Dispose();
			tipaktcreate.Dispose();
		}

		//Spremi novog korisnika u bazu
		public static void DbSpremiKorisnik(Korisnik k)
		{
			konekcija.Open();
			string unesiKorisnika = @"INSERT INTO korisnici (ime,prezime,datum_rodjenja,visina,tezina) VALUES ('" +
				k.Ime +"','" + k.Prezime + "'," + k.Datum_rodjenja.ToFileTime() + "," + k.Visina + "," + k.Tezina + ")";
			SQLiteCommand createcmd = new SQLiteCommand(unesiKorisnika, konekcija);
			createcmd.ExecuteNonQuery();
			konekcija.Close();
			createcmd.Dispose();
		}

		//Učitavanje korisnika sa baze
		public static List<Korisnik> DbUcitajKorisnike()
		{
			konekcija.Open();
			string ucitajKorisnike = "SELECT * FROM korisnici";
			SQLiteCommand createcmd = new SQLiteCommand(ucitajKorisnike, konekcija);
			SQLiteDataReader reader = createcmd.ExecuteReader();
			List<Korisnik> listaKorisnika = new List<Korisnik>();
			while (reader.Read())
			{
				Korisnik k = new Korisnik(reader.GetString(1), reader.GetString(2), DateTime.FromFileTime(reader.GetInt64(3)),reader.GetDouble(4),reader.GetDouble(5));
				listaKorisnika.Add(k);
			}
			konekcija.Close();

			createcmd.Dispose();

			return listaKorisnika;
		}

		//Spremi novi tip aktivnosti u bazu
		public static void DbSpremiTipAktivnosti(TipAktivnosti ta)
		{
			konekcija.Open();
			string unesiTipAktivnosti = @"INSERT INTO tipoviaktivnosti (naziv,jedinica_mjere, potrosnja) VALUES ('" +
				ta.Naziv + "','" + ta.JedinicaMjere + "'," + ta.KcalPoJediniciMjere + ")";
			SQLiteCommand createcmd = new SQLiteCommand(unesiTipAktivnosti, konekcija);
			createcmd.ExecuteNonQuery();
			konekcija.Close();

			createcmd.Dispose();
		}

		//Učitavanje korisnika sa baze
		public static List<TipAktivnosti> DbUcitajTipAktivnosti()
		{
			konekcija.Open();
			string ucitajKorisnike = "SELECT * FROM tipoviaktivnosti";
			SQLiteCommand createcmd = new SQLiteCommand(ucitajKorisnike, konekcija);
			SQLiteDataReader reader = createcmd.ExecuteReader();
			List<TipAktivnosti> listaTipovaAktivnosti = new List<TipAktivnosti>();
			while (reader.Read())
			{
				TipAktivnosti ta = new TipAktivnosti(reader.GetString(1),reader.GetString(2),reader.GetDouble(3));
				listaTipovaAktivnosti.Add(ta);
			}
			konekcija.Close();

			createcmd.Dispose();

			return listaTipovaAktivnosti;
		}
	}
}
