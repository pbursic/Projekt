using System;
using System.Collections.Generic;
using Gtk;
using System.Globalization;

namespace AppProject
{
	public partial class WindowDodajAktivnost : Gtk.Window
	{
		public WindowDodajAktivnost() :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();

			Gdk.Color colorLightBlue = new Gdk.Color();
			Gdk.Color.Parse("#3FB2F0", ref colorLightBlue);
			eventboxDodajAktivnost.ModifyBg(Gtk.StateType.Normal, colorLightBlue);
			Add(eventboxDodajAktivnost);

			PopuniDatum();
			PopuniTipove();
		}

		//Postavljanje liste u comboboxevima te odabran datum s kalendara (danas)
		public void PopuniDatum()
		{
			ListStore clearListDani = new ListStore(typeof(string), typeof(string));
			ListStore clearListGod = new ListStore(typeof(string), typeof(string));
			comboboxDan.Model = clearListDani;
			comboboxGodina.Model = clearListGod;

			//Postavljanje comboboxa s danima da pokazuje broj dana u odabranom mjesecu određene godine
			var daniuMjesecu = DateTime.DaysInMonth(calendarAktivnosti.Date.Year, calendarAktivnosti.Date.Month);

			for (int i = 1; i <= daniuMjesecu; i++)
			{
				comboboxDan.AppendText(i.ToString());
			}
			comboboxDan.Active = calendarAktivnosti.Date.Day - 1;

			//Postavljanje odabranog mjeseca
			comboboxMjesec.Active = calendarAktivnosti.Date.Month - 1;

			//Postavljanje odabrane godine
			for (int i = DateTime.Now.Year; i >= 1920; i--)
			{
				comboboxGodina.AppendText(i.ToString());
			}
			comboboxGodina.Active = calendarAktivnosti.Date.Year - calendarAktivnosti.Date.Year;
		}

		//Postavljanje liste tipova (svi unešeni tipovi)
		public void PopuniTipove()
		{
			List<TipAktivnosti> listaTipova = new List<TipAktivnosti>();
			listaTipova = Baza.DbUcitajTipAktivnosti();
			comboboxTipovi.AppendText ("");
			foreach (var x in listaTipova)
			{
				Console.WriteLine(x.Naziv + "\n");
				comboboxTipovi.AppendText(x.Naziv);
			}
		}

		/*TODO:
				Implementirati combobox da provjerava koji je tip odabran te da sukladno prikazuje jedinicu mjere
				Provjera po nazivu i prikazanom tekstu nije točna!!!
		*/
		public void PopuniJedinicuMjere()
		{
			List<TipAktivnosti> listaTipova = new List<TipAktivnosti>();
			listaTipova = Baza.DbUcitajTipAktivnosti();
			foreach (var x in listaTipova)
			{
				if (x.Naziv == comboboxTipovi.ActiveText)
				{
					labelJedinicaMjere.LabelProp = x.JedinicaMjere;
				}
				else {
					labelJedinicaMjere.LabelProp = "";
				}
			}
		}

		//Prikazi datum s kalendara u comboboxevima
		protected void UpdateDate(object sender, EventArgs e)
		{
			PopuniDatum();
		}

		protected void OdustaniClicked(object sender, EventArgs e)
		{
			Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Question, ButtonsType.YesNo,
											 "Jeste li sigurni? Promjene neće biti spremljene.");
			ResponseType response = (ResponseType)d.Run();
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

		protected void JedinicaMjere(object sender, EventArgs e)
		{
			PopuniJedinicuMjere();
		}
	}
}
