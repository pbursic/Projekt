using System;
using System.Globalization;
using Gtk;

namespace AppProject
{
	public partial class WindowDodajKorisnika : Gtk.Window
	{
		public WindowDodajKorisnika() : base(Gtk.WindowType.Toplevel)
		{
			this.Build();

			Gdk.Color colorLightBlue = new Gdk.Color();
			Gdk.Color.Parse("#3FB2F0", ref colorLightBlue);
			eventboxDodajKorisnika.ModifyBg(StateType.Normal, colorLightBlue);
			Add(eventboxDodajKorisnika);

			//Prvo popunjavanje comboboxeva pri otvaranju prozora
			PopuniDatum();
		}


		//Postavljanje liste u comboboxevima te odabran datum s kalendara (danas)
		public void PopuniDatum()
		{
			ListStore clearListDani = new ListStore(typeof(string), typeof(string));
			ListStore clearListGod = new ListStore(typeof(string), typeof(string));
			comboboxDan.Model = clearListDani;
			comboboxGodina.Model = clearListGod;

			//Postavljanje comboboxa s danima da pokazuje broj dana u odabranom mjesecu određene godine
			var daniuMjesecu = DateTime.DaysInMonth(calendarDatumRodjenja.Date.Year, calendarDatumRodjenja.Date.Month);

			for (int i = 1; i <= daniuMjesecu; i++)
			{
				comboboxDan.AppendText(i.ToString());
			}
			comboboxDan.Active = calendarDatumRodjenja.Date.Day - 1;

			//Postavljanje odabranog mjeseca
			comboboxMjesec.Active = calendarDatumRodjenja.Date.Month - 1;

			//Postavljanje odabrane godine
			for (int i = DateTime.Now.Year; i >= 1920; i--)
			{
				comboboxGodina.AppendText(i.ToString());
			}
			comboboxGodina.Active = DateTime.Now.Year - calendarDatumRodjenja.Date.Year;
		}


		//Prikazi datum s kalendara u comboboxevima
		protected void UpdateDate(object sender, EventArgs e)
		{
			PopuniDatum();
		}


		//Klikom na Spremi, korisnik se sprema u bazu podataka
		protected void SpremiKorisnika(object sender, EventArgs e)
		{
			
			DateTime datum = new DateTime(Int32.Parse(comboboxGodina.ActiveText), (int)(comboboxMjesec.Active+1), Int32.Parse(comboboxDan.ActiveText));

			//Ime ne smije biti prazno
			if (entryIme.Text == "")
			{
				Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Ime ne može biti prazno.");
				d.Run();
				d.Destroy();
			}
			//Prezime ne smije biti prazno
			else if (entryPrezime.Text == "")
			{
				Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Prezime ne može biti prazno.");
				d.Run();
				d.Destroy();
			}
			//Datum rodjenja ne smije biti >= danas
			else if (datum >= DateTime.Today)
			{
				Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Odaberite valjani datum rođenja.");
				d.Run();
				d.Destroy();
			}
			//Spremi podatke u bazu i zatvori prozor
			else {
				Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Other, ButtonsType.OkCancel, "Ime: " + entryIme.Text + "\nPrezime: " 
				                                 + entryPrezime.Text + "\nDatum rodjenja: " + datum.Date.ToString("d") + "\nVisina: " + spinbuttonVisina.Value 
				                                 + "\nTežina: " + spinbuttonTezina.Value + "\n\nŽelite li spremiti korisnika?");
				var response = (ResponseType)d.Run();
				if (response == ResponseType.Ok)
				{
					Korisnik noviKorisnik = new Korisnik(0, entryIme.Text, entryPrezime.Text, datum, spinbuttonVisina.ValueAsInt, spinbuttonTezina.ValueAsInt);
					Baza.DbSpremiKorisnik(noviKorisnik);
					d.Destroy();
					this.Destroy();
				}
				else
				{
					d.Destroy();
				}
			}
		}

		protected void OdustaniClicked(object sender, EventArgs e)
		{
			Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Question, ButtonsType.YesNo, 
			                                 "Jeste li sigurni? Promjene neće biti spremljene.");
			var response = (ResponseType) d.Run();
			if (response == ResponseType.Yes)
			{
				d.Destroy();
				this.Destroy();
			}
			else 
			{
				d.Destroy();
			}
		}
	}
}
