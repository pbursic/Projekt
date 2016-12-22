using System;
using Gtk;

namespace AppProject
{
	public partial class WindowDodajKorisnika : Gtk.Window
	{
		public WindowDodajKorisnika() : base(Gtk.WindowType.Toplevel)
		{
			this.Build();
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
			comboboxGodina.Active = calendarDatumRodjenja.Date.Year - calendarDatumRodjenja.Date.Year;
		}

		protected void UpdateCalendar(object sender, EventArgs e)
		{
			/*TODO:
			 * Implementirati metodu koja ucitava dan, mjesec i godinu sa combobox-eva i postavlja taj datum u kalendar
			 * 
			 */
		}

		protected void UpdateDate(object sender, EventArgs e)
		{
			PopuniDatum();
		}
	}
}
