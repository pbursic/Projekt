using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace AppProject
{
	public static class Baza
	{
		static SQLiteConnection konekcija = new SQLiteConnection("Data Source=baza.db");

		//Skripta za stvaranje tablice sa korisnicima, tipovima aktivnosti, aktivnostima pojedinih korisnika
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

			//Tablica aktivnostikorisnika
			string aktivnostiKorisnika = "CREATE TABLE IF NOT EXISTS aktivnostikorisnika (id integer primary key autoincrement," +
				"k_id integer, ta_id integer,naziv nvarchar(35), datum datetime, vrijeme_pocetka datetime," +
				"vrijeme_kraja datetime,potrosnja float,FOREIGN KEY(k_id) REFERENCES korisnici(id), " +
				"FOREIGN KEY(ta_id) REFERENCES tipoviaktivnosti(id))";
			SQLiteCommand aktKorisnikaCreate = new SQLiteCommand(aktivnostiKorisnika, konekcija);
			aktKorisnikaCreate.ExecuteNonQuery();

			konekcija.Close();

			korisnicicreate.Dispose();
			tipaktcreate.Dispose();
			aktKorisnikaCreate.Dispose();
		}


		//KORISNICI

		//Spremi novog korisnika u bazu
		public static void DbSpremiKorisnik(Korisnik k)
		{
			konekcija.Open();
			string unesiKorisnika = @"INSERT INTO korisnici (ime,prezime,datum_rodjenja,visina,tezina) VALUES ('" +
				k.Ime +"','" + k.Prezime + "'," + k.Datum_rodjenja.ToFileTime() + "," + k.Visina + "," + k.Tezina + ")";
			SQLiteCommand createcmd = new SQLiteCommand(unesiKorisnika, konekcija);
			createcmd.ExecuteNonQuery();
			string getId = @"SELECT last_insert_rowid() as id FROM korisnici";
			SQLiteCommand cmdId = new SQLiteCommand(getId, konekcija);
			var id = cmdId.ExecuteScalar();
			k.Id = Int32.Parse(id.ToString());
			konekcija.Close();
			createcmd.Dispose();
			cmdId.Dispose();
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
				Korisnik k = new Korisnik(reader.GetInt32(0),reader.GetString(1), reader.GetString(2), DateTime.FromFileTime(reader.GetInt64(3)),reader.GetDouble(4),reader.GetDouble(5));
				listaKorisnika.Add(k);
			}
			konekcija.Close();

			createcmd.Dispose();

			return listaKorisnika;
		}

		//Provjera postojanja korisnika u bazi po Id-u
		public static bool DbProvjeriIdKorisnika(int id)
		{
			konekcija.Open();
			string provjeraIdKorisnika = @"SELECT COUNT(*) FROM korisnici WHERE id = " + id;
			SQLiteCommand cmd = new SQLiteCommand(provjeraIdKorisnika, konekcija);
			int x = Int32.Parse(cmd.ExecuteScalar().ToString());
			if (x > 0)
			{
				konekcija.Close();
				cmd.Dispose();
				return true;
			}
			else
			{
				konekcija.Close();
				cmd.Dispose();
				return false;
			}
		}

		//Slanje bazi promjene na korisnika
		public static void UpdateKorisnika(Korisnik k)
		{
			konekcija.Open();
			string updateKorisnika = @"UPDATE korisnici SET ime='" + k.Ime + "', prezime='" + k.Prezime + "', datum_rodjenja= " + 
			                                                         k.Datum_rodjenja.ToFileTime() + ", visina=" + k.Visina +
			                                                          ", tezina=" + k.Tezina + " WHERE id=" + k.Id;
			SQLiteCommand cmd = new SQLiteCommand(updateKorisnika, konekcija);
			cmd.ExecuteNonQuery();
			konekcija.Close();
			cmd.Dispose();
		}

		//Brisanje korisnika i svih aktivnosti tog korisnika sa baze
		public static void BrisiKorisnika(int id)
		{
			konekcija.Open();

			string brisiAktivnostKorisnika = @"DELETE FROM aktivnostikorisnika WHERE k_id = " + id;
			SQLiteCommand cmd1 = new SQLiteCommand(brisiAktivnostKorisnika, konekcija);
			cmd1.ExecuteNonQuery();

			string brisiKorisnika = @"DELETE FROM korisnici WHERE id = " + id;
			SQLiteCommand cmd2 = new SQLiteCommand(brisiKorisnika, konekcija);
			cmd2.ExecuteNonQuery();

			konekcija.Close();

			cmd1.Dispose();
			cmd2.Dispose();
		}


		//TIPOVI AKTIVNOSTI 

		//Spremi novi tip aktivnosti u bazu
		public static void DbSpremiTipAktivnosti(TipAktivnosti ta)
		{
			konekcija.Open();
			string unesiTipAktivnosti = @"INSERT INTO tipoviaktivnosti (naziv,jedinica_mjere, potrosnja) VALUES ('" +
				ta.Naziv + "','" + ta.JedinicaMjere + "'," + ta.KcalPoJediniciMjere + ")";
			SQLiteCommand createcmd = new SQLiteCommand(unesiTipAktivnosti, konekcija);
			createcmd.ExecuteNonQuery();
			string getId = @"SELECT last_insert_rowid() as id FROM tipoviaktivnosti";
			SQLiteCommand cmdId = new SQLiteCommand(getId, konekcija);
			var id = cmdId.ExecuteScalar();
			ta.Id = Int32.Parse(id.ToString());
			konekcija.Close();

			createcmd.Dispose();
			cmdId.Dispose();
		}

		//Učitavanje tipova aktivnosti sa baze
		public static List<TipAktivnosti> DbUcitajTipAktivnosti()
		{
			konekcija.Open();
			string ucitajTipoveAktivnosti = "SELECT * FROM tipoviaktivnosti";
			SQLiteCommand createcmd = new SQLiteCommand(ucitajTipoveAktivnosti, konekcija);
			SQLiteDataReader reader = createcmd.ExecuteReader();
			List<TipAktivnosti> listaTipovaAktivnosti = new List<TipAktivnosti>();
			while (reader.Read())
			{
				TipAktivnosti ta = new TipAktivnosti(reader.GetInt32(0),reader.GetString(1),reader.GetString(2),reader.GetDouble(3));
				listaTipovaAktivnosti.Add(ta);
			}
			konekcija.Close();

			createcmd.Dispose();

			return listaTipovaAktivnosti;
		}

		//Provjera postojanja tipa aktivnosti u bazi po Id-u
		public static bool DbProvjeriIdTipaAktivnosti(int id)
		{
			konekcija.Open();
			string provjeraIdTipaAktivnosti = @"SELECT COUNT(*) FROM tipoviaktivnosti WHERE id = " + id;
			SQLiteCommand cmd = new SQLiteCommand(provjeraIdTipaAktivnosti, konekcija);
			int x = Int32.Parse(cmd.ExecuteScalar().ToString());
			if (x > 0)
			{
				konekcija.Close();
				cmd.Dispose();
				return true;
			}
			else
			{
				konekcija.Close();
				cmd.Dispose();
				return false;
			}
		}

		//Slanje bazi promjene na tip aktivnosti
		public static void UpdateTipAktivnosti(TipAktivnosti ta)
		{
			konekcija.Open();
			string updateTipAktivnosti = @"UPDATE tipoviaktivnosti SET naziv='" + ta.Naziv + "', jedinica_mjere='" + ta.JedinicaMjere + "', potrosnja= " +
			                                                                    ta.KcalPoJediniciMjere +" WHERE id=" + ta.Id;
			SQLiteCommand cmd = new SQLiteCommand(updateTipAktivnosti, konekcija);
			cmd.ExecuteNonQuery();
			konekcija.Close();
			cmd.Dispose();
		}

		//Brisanje tipova aktivnosti iz baze i svih aktivnosti korisnika koji imaju taj tip aktivnosti
		public static void BrisiTipAktivnosti(int id)
		{
			konekcija.Open();

			string brisiAktivnostiKorisnika = @"DELETE FROM aktivnostikorisnika WHERE ta_id = " + id;
			SQLiteCommand cmd1 = new SQLiteCommand(brisiAktivnostiKorisnika, konekcija);
			cmd1.ExecuteNonQuery();

			string brisiTipAktivnosti = @"DELETE FROM tipoviaktivnosti WHERE id = " + id;
			SQLiteCommand cmd2 = new SQLiteCommand(brisiTipAktivnosti, konekcija);
			cmd2.ExecuteNonQuery();


			konekcija.Close();

			cmd1.Dispose();
			cmd2.Dispose();
		}

		//AKTIVNOSTI KORISNIKA

		//Spremanje aktivnosti korisnika u bazu
		public static void DbSpremiAktivnostKorisnika(AktivnostKorisnika ak)
		{
			konekcija.Open();
			string unesiAktivnostKorisnika = @"INSERT INTO aktivnostikorisnika (k_id,ta_id,naziv,datum,vrijeme_pocetka,vrijeme_kraja,potrosnja) VALUES ("
				+ ak.K_id + "," + ak.Ta_id + ",'" + ak.Naziv + "'," + ak.Datum.ToFileTime() + "," + ak.Vrijeme_pocetka.ToFileTime() + "," + 
			              ak.Vrijeme_kraja.ToFileTime() + "," + ak.Potrosnja + ")";
			SQLiteCommand createcmd = new SQLiteCommand(unesiAktivnostKorisnika, konekcija);
			createcmd.ExecuteNonQuery();

			string getId = @"SELECT last_insert_rowid() as id FROM aktivnostikorisnika";
			SQLiteCommand cmdId = new SQLiteCommand(getId, konekcija);
			var id = cmdId.ExecuteScalar();
			ak.Id = Int32.Parse(id.ToString());

			konekcija.Close();
			createcmd.Dispose();
			cmdId.Dispose();
		}

		//Učitavanje aktivnosti korisnika sa baze po pripadajucem id-u
		public static List<AktivnostKorisnika> DbUcitajAktivnostiKorisnika(int id)
		{
			konekcija.Open();
			string ucitajAktivnostiKorisnika = "SELECT * FROM aktivnostikorisnika WHERE k_id =" + id;
			SQLiteCommand createcmd = new SQLiteCommand(ucitajAktivnostiKorisnika, konekcija);
			SQLiteDataReader reader = createcmd.ExecuteReader();
			List<AktivnostKorisnika> listaAktivnostiKorisnika = new List<AktivnostKorisnika>();

			string getTip = @"SELECT tipoviaktivnosti.naziv FROM tipoviaktivnosti, aktivnostikorisnika WHERE tipoviaktivnosti.id = aktivnostikorisnika.ta_id AND aktivnostikorisnika.id=" + id;
			SQLiteCommand getTipCmd = new SQLiteCommand(getTip, konekcija);
			var tip = getTipCmd.ExecuteNonQuery().ToString();

			while (reader.Read())
			{
				
				AktivnostKorisnika ak = new AktivnostKorisnika(reader.GetInt32(0),reader.GetInt32(1),reader.GetInt32(2),reader.GetString(3),
				                                               DateTime.FromFileTime(reader.GetInt64(4)),DateTime.FromFileTime(reader.GetInt64(5)),
				                                               DateTime.FromFileTime(reader.GetInt64(6)),reader.GetDouble(7));
				listaAktivnostiKorisnika.Add(ak);
			}
			konekcija.Close();

			createcmd.Dispose();

			return listaAktivnostiKorisnika;
		}

		//Učitavanje aktivnosti korisnika sa baze po pripadajucem id-u i datumu
		public static List<AktivnostKorisnika> DbUcitajAktivnostiKorisnikaPoDatumu(int id, DateTime datum)
		{
			konekcija.Open();
			string ucitajAktivnostiKorisnika = "SELECT * FROM aktivnostikorisnika WHERE k_id =" + id + " AND datum = " + datum.ToFileTime();
			SQLiteCommand createcmd = new SQLiteCommand(ucitajAktivnostiKorisnika, konekcija);
			SQLiteDataReader reader = createcmd.ExecuteReader();
			List<AktivnostKorisnika> listaAktivnostiKorisnika = new List<AktivnostKorisnika>();

			string getTip = @"SELECT tipoviaktivnosti.naziv FROM tipoviaktivnosti, aktivnostikorisnika WHERE tipoviaktivnosti.id = aktivnostikorisnika.ta_id 
			AND aktivnostikorisnika.id=" + id;
			SQLiteCommand getTipCmd = new SQLiteCommand(getTip, konekcija);
			var tip = getTipCmd.ExecuteNonQuery().ToString();

			while (reader.Read())
			{

				AktivnostKorisnika ak = new AktivnostKorisnika(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetString(3),
															   DateTime.FromFileTime(reader.GetInt64(4)), DateTime.FromFileTime(reader.GetInt64(5)),
															   DateTime.FromFileTime(reader.GetInt64(6)), reader.GetDouble(7));
				listaAktivnostiKorisnika.Add(ak);
			}
			konekcija.Close();

			createcmd.Dispose();

			return listaAktivnostiKorisnika;
		}

		//Provjera postojanja aktivnosti korisnika u bazi po Id-u
		public static bool DbProvjeriIdAktivnostiKorisnika(int id)
		{
			konekcija.Open();
			string provjeraIdAktivnostiKorisnika = @"SELECT COUNT(*) FROM aktivnostikorisnika WHERE id = " + id;
			SQLiteCommand cmd = new SQLiteCommand(provjeraIdAktivnostiKorisnika, konekcija);
			int x = Int32.Parse(cmd.ExecuteScalar().ToString());
			if (x > 0)
			{
				konekcija.Close();
				cmd.Dispose();
				return true;
			}
			else
			{
				konekcija.Close();
				cmd.Dispose();
				return false;
			}
		}

		//Slanje promjena o aktivnosti korisnika bazi
		public static void UpdateAktivnostiKorisnika(AktivnostKorisnika ak)
		{
			konekcija.Open();
			string updateAktivnostKorisnika = @"UPDATE aktivnostikorisnika SET naziv='" + ak.Naziv + "', datum='" + ak.Datum.ToFileTime() 
			                                                                                + "', vrijeme_pocetka= " + ak.Vrijeme_pocetka.ToFileTime() 
			                                                                                + ", vrijeme_kraja=" + ak.Vrijeme_kraja.ToFileTime() 
			                                                                                + ", potrosnja= " + ak.Potrosnja + " WHERE id=" + ak.Id;
			SQLiteCommand cmd = new SQLiteCommand(updateAktivnostKorisnika, konekcija);
			cmd.ExecuteNonQuery();
			konekcija.Close();
			cmd.Dispose();
		}

		//Brisanje odabrane aktivnosti korisnika sa baze
		public static void BrisiAktivnostKorisnika(int id)
		{
			konekcija.Open();
			string brisiAktivnostKorisnika = @"DELETE FROM aktivnostikorisnika WHERE id = " + id;
			SQLiteCommand cmd = new SQLiteCommand(brisiAktivnostKorisnika, konekcija);
			cmd.ExecuteNonQuery();
			konekcija.Close();
			cmd.Dispose();
		}

		// Statistika

		// Statistika za razdoblje po datumu

		public static List<AktivnostKorisnika> StatistikaRazdobljaPoDatumu(DateTime datumOd, DateTime datumDo, int id)
		{
			datumDo.AddHours(23);
			datumDo.AddMinutes(59);
			datumDo.AddSeconds(59);
			konekcija.Open();
			string statistikaRazdoblja = @"SELECT * FROM aktivnostikorisnika WHERE k_id=" + id + " AND datum>=" + 
				datumOd.ToFileTime() + " AND datum<=" + datumDo.ToFileTime() +  " ORDER BY datum";
			SQLiteCommand cmd = new SQLiteCommand(statistikaRazdoblja, konekcija);
			SQLiteDataReader reader = cmd.ExecuteReader();

			List<AktivnostKorisnika> listaAktivnostiKorisnika = new List<AktivnostKorisnika>();
			while (reader.Read())
			{

				AktivnostKorisnika ak = new AktivnostKorisnika(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetString(3),
															   DateTime.FromFileTime(reader.GetInt64(4)), DateTime.FromFileTime(reader.GetInt64(5)),
															   DateTime.FromFileTime(reader.GetInt64(6)), reader.GetDouble(7));
				listaAktivnostiKorisnika.Add(ak);
			}
			konekcija.Close();

			cmd.Dispose();

			return listaAktivnostiKorisnika;
		}

		// Statistika za razdoblje po potrosnji

		public static List<AktivnostKorisnika> StatistikaRazdobljaPoPotrosnji(DateTime datumOd, DateTime datumDo, int id)
		{
			datumDo.AddHours(23);
			datumDo.AddMinutes(59);
			datumDo.AddSeconds(59);
			konekcija.Open();
			string statistikaRazdoblja = @"SELECT * FROM aktivnostikorisnika WHERE k_id=" + id + " AND datum>=" +
				datumOd.ToFileTime() + " AND datum<=" + datumDo.ToFileTime() + " ORDER BY potrosnja";
			SQLiteCommand cmd = new SQLiteCommand(statistikaRazdoblja, konekcija);
			SQLiteDataReader reader = cmd.ExecuteReader();

			List<AktivnostKorisnika> listaAktivnostiKorisnika = new List<AktivnostKorisnika>();
			while (reader.Read())
			{

				AktivnostKorisnika ak = new AktivnostKorisnika(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetString(3),
															   DateTime.FromFileTime(reader.GetInt64(4)), DateTime.FromFileTime(reader.GetInt64(5)),
															   DateTime.FromFileTime(reader.GetInt64(6)), reader.GetDouble(7));
				listaAktivnostiKorisnika.Add(ak);
			}
			konekcija.Close();

			cmd.Dispose();

			return listaAktivnostiKorisnika;
		}

		// Statistika po tipu aktivnosti

		public static List<AktivnostKorisnika> StatistikaRazdobljaPoTipu(int tip_id, int id)
		{
			konekcija.Open();
			string statistikaTipa = @"SELECT * FROM aktivnostikorisnika WHERE k_id=" + id + " AND ta_id = " + tip_id
				+ " ORDER BY potrosnja";
			SQLiteCommand cmd = new SQLiteCommand(statistikaTipa, konekcija);
			SQLiteDataReader reader = cmd.ExecuteReader();

			List<AktivnostKorisnika> listaAktivnostiKorisnika = new List<AktivnostKorisnika>();
			while (reader.Read())
			{

				AktivnostKorisnika ak = new AktivnostKorisnika(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetString(3),
															   DateTime.FromFileTime(reader.GetInt64(4)), DateTime.FromFileTime(reader.GetInt64(5)),
															   DateTime.FromFileTime(reader.GetInt64(6)), reader.GetDouble(7));
				listaAktivnostiKorisnika.Add(ak);
			}
			konekcija.Close();

			cmd.Dispose();

			return listaAktivnostiKorisnika;
		}
	}
}
