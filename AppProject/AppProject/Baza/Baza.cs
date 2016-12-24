using System;
using System.Data.SQLite;

namespace AppProject
{
	public static class Baza
	{
		static SQLiteConnection konekcija = new SQLiteConnection("Data Source=baza.db");

		//Skripta za stvaranje tablice sa korisnicima
		public static void Db()
		{
			konekcija.Open();
			string kreiraj = "CREATE TABLE IF NOT EXISTS korisnici (id integer primary key autoincrement, " +
				"ime nvarchar(20), prezime nvarchar(30), datum_rodjenja datetime, visina integer, tezina integer)";
			SQLiteCommand createcmd = new SQLiteCommand(kreiraj, konekcija);
			createcmd.ExecuteNonQuery();
			konekcija.Close();
		}

		//Spremi novog korisnika u bazu
		public static void DbSpremiKorisnik(string ime, string prezime, DateTime datum_rodjenja, int visina, int tezina)
		{
			konekcija.Open();
			string unesiKorisnika = @"INSERT INTO korisnici (ime,prezime,datum_rodjenja,visina,tezina) VALUES ('" + ime +
				"','" + prezime + "'," + datum_rodjenja.ToFileTime() + "," + visina + "," + tezina + ")";
			SQLiteCommand createcmd = new SQLiteCommand(unesiKorisnika, konekcija);
			createcmd.ExecuteNonQuery();
			konekcija.Close();
		}
	}
}
