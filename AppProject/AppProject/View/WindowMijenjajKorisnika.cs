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
			eventboxMijenjajKorisnika.ModifyBg(Gtk.StateType.Normal, colorLightBlue);
			Add(eventboxMijenjajKorisnika);

			entryIme.Text = k.ime;
			entryPrezime.Text = k.prezime;
			calendarDatumRodjenja.Date = Convert.ToDateTime(k.datum_rodjenja);
			spinbuttonVisina.Value = double.Parse(k.visina);
			spinbuttonTezina.Value = double.Parse(k.tezina);
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
			comboboxGodina.Active = calendarDatumRodjenja.Date.Year - calendarDatumRodjenja.Date.Year;
		}
	}
}
