using System;
using Gtk;

namespace AppProject
{
	public partial class WindowMijenjajKorisnika : Gtk.Window
	{
		public WindowMijenjajKorisnika(KorisnikNode k) :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();

			Gdk.Color colorLightBlue = new Gdk.Color();
			Gdk.Color.Parse("#3FB2F0", ref colorLightBlue);
			eventboxMijenjajKorisnika.ModifyBg(StateType.Normal, colorLightBlue);
			Add(eventboxMijenjajKorisnika);

			labelID.Text = k.id.ToString();
			entryIme.Text = k.ime;
			entryPrezime.Text = k.prezime;
			calendarDatumRodjenja.Date = Convert.ToDateTime(k.datum_rodjenja);
			spinbuttonVisina.Value = double.Parse(k.visina);
			spinbuttonTezina.Value = double.Parse(k.tezina);
			PopuniDatum();
		}

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
			comboboxGodina.Active = DateTime.Now.Year - calendarDatumRodjenja.Date.Year  ;
		}

		protected void SpremiPromjene(object sender, EventArgs e)
		{
			DateTime datum = new DateTime(Int32.Parse(comboboxGodina.ActiveText), (int)(comboboxMjesec.Active + 1), Int32.Parse(comboboxDan.ActiveText));

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
			//Spremi podatke u bazu i zatvori prozor
			else {
				Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Other, ButtonsType.OkCancel, "Ime: " + entryIme.Text + "\nPrezime: "
												 + entryPrezime.Text + "\nDatum rodjenja: " + datum.Date.ToString("d") + "\nVisina: " + spinbuttonVisina.Value
												 + "\nTežina: " + spinbuttonTezina.Value + "\n\nŽelite li spremiti promjene?");
				var response = (ResponseType)d.Run();
				if (response == ResponseType.Ok)
				{
					Korisnik updateKorisnik = new Korisnik(Int32.Parse(labelID.Text), entryIme.Text, entryPrezime.Text, datum, spinbuttonVisina.ValueAsInt, spinbuttonTezina.ValueAsInt);
					Baza.UpdateKorisnika(updateKorisnik);
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
			var response = (ResponseType)d.Run();
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
