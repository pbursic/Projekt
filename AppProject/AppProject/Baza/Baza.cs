using System;
using System.Data.SQLite;

namespace AppProject
{
	public static class Baza
	{
		static SQLiteConnection konekcija = new SQLiteConnection("Data Source=baza.db");
		public static void Db()
		{
			konekcija.Open();
			string kreiraj = "CREATE TABLE IF NOT EXISTS korisnici (id integer primary key autoincrement, " +
				"ime nvarchar(20), prezime nvarchar(30), datum_rodjenja date, visina integer, tezina integer)";
			SQLiteCommand createcmd = new SQLiteCommand(kreiraj, konekcija);
			createcmd.ExecuteNonQuery();
			konekcija.Close();
		}
	}
}
