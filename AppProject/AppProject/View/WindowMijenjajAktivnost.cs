using System;
using System.Collections.Generic;
using Gtk;

namespace AppProject
{
	public partial class WindowMijenjajAktivnost : Gtk.Window
	{
		public WindowMijenjajAktivnost(AktKorisnikaNode ak) :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();

			Gdk.Color colorLightBlue = new Gdk.Color();
			Gdk.Color.Parse("#3FB2F0", ref colorLightBlue);
			eventboxDodajAktivnost.ModifyBg(Gtk.StateType.Normal, colorLightBlue);
			Add(eventboxDodajAktivnost);

			calendarAktivnosti.Date = DateTime.Parse(ak.datum);
			DateTime vp = DateTime.Parse(ak.vrijeme_pocetka);
			DateTime vk = DateTime.Parse(ak.vrijeme_kraja);

			PopuniDatum();
			PopuniTipove(ak.id);
			PopuniVrijeme();
			labelKorisnikId.Text = ak.k_id.ToString();
			labelTipId.Text = ak.ta_id.ToString();
			labelAktivnostId.Text = ak.id.ToString();
			entryNaziv.Text = ak.naziv;
			comboboxSatPocetak.Active = vp.Hour;
			comboboxMinPocetak.Active = vp.Minute;
			comboboxSecPocetak.Active = vp.Second;
			comboboxSatKraj.Active = vk.Hour;
			comboboxMinKraj.Active = vk.Minute;
			comboboxSecKraj.Active = vk.Second;

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
			comboboxGodina.Active = DateTime.Now.Year - calendarAktivnosti.Date.Year;
		}

		//Postavljanje liste tipova (svi unešeni tipovi)
		public void PopuniTipove(int id)
		{
			List<TipAktivnosti> listaTipova = new List<TipAktivnosti>();
			listaTipova = Baza.DbUcitajTipAktivnosti();
			foreach (var x in listaTipova)
			{
				comboboxTipovi.AppendText(x.Naziv);
			}
		}

		//Postavljanje liste sa satovima, minutama i sekundama (početak i kraj)
		public void PopuniVrijeme()
		{
			for (int i = 0; i < 24; i++)
			{
				comboboxSatPocetak.AppendText(i.ToString("00"));
				comboboxSatKraj.AppendText(i.ToString("00"));
			}

			for (int i = 0; i < 60; i++)
			{
				comboboxMinPocetak.AppendText(i.ToString("00"));
				comboboxMinKraj.AppendText(i.ToString("00"));
			}

			for (int i = 0; i < 60; i++)
			{
				comboboxSecPocetak.AppendText(i.ToString("00"));
				comboboxSecKraj.AppendText(i.ToString("00"));
			}

			comboboxSatPocetak.Active = 0;
			comboboxSatKraj.Active = 0;
			comboboxMinPocetak.Active = 0;
			comboboxMinKraj.Active = 0;
			comboboxSecPocetak.Active = 0;
			comboboxSecKraj.Active = 0;
		}

		public void PopuniJedinicuMjere()
		{
			DateTime datum = new DateTime(Int32.Parse(comboboxGodina.ActiveText), (int)(comboboxMjesec.Active + 1), Int32.Parse(comboboxDan.ActiveText));
			DateTime vrijeme_p = new DateTime(Int32.Parse(comboboxGodina.ActiveText), (int)(comboboxMjesec.Active + 1), Int32.Parse(comboboxDan.ActiveText),
											  Int32.Parse(comboboxSatPocetak.ActiveText), Int32.Parse(comboboxMinPocetak.ActiveText),
											  Int32.Parse(comboboxSecPocetak.ActiveText));
			DateTime vrijeme_k = new DateTime(Int32.Parse(comboboxGodina.ActiveText), (int)(comboboxMjesec.Active + 1), Int32.Parse(comboboxDan.ActiveText),
											  Int32.Parse(comboboxSatKraj.ActiveText), Int32.Parse(comboboxMinKraj.ActiveText),
											  Int32.Parse(comboboxSecKraj.ActiveText));
			TimeSpan tot_vrijeme = vrijeme_k - vrijeme_p;


			List<TipAktivnosti> listaTipova = new List<TipAktivnosti>();
			listaTipova = Baza.DbUcitajTipAktivnosti();
			foreach (var x in listaTipova)
			{
				if (x.Naziv == comboboxTipovi.ActiveText)
				{
					labelTipId.LabelProp = x.Id.ToString();

					if (x.JedinicaMjere == "min")
					{
						double minuti = tot_vrijeme.Hours * 60 + tot_vrijeme.Minutes;
						labelPotrosnjaKcal.Text = (minuti * x.KcalPoJediniciMjere).ToString();
					}
					else if (x.JedinicaMjere == "h")
					{
						double sati = tot_vrijeme.Hours;
						labelPotrosnjaKcal.Text = (sati * x.KcalPoJediniciMjere).ToString();
					}
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

		protected void SpremiClicked(object sender, EventArgs e)
		{
			DateTime datum = new DateTime(Int32.Parse(comboboxGodina.ActiveText), (int)(comboboxMjesec.Active + 1), Int32.Parse(comboboxDan.ActiveText));
			DateTime vrijeme_p = new DateTime(Int32.Parse(comboboxGodina.ActiveText), (int)(comboboxMjesec.Active + 1), Int32.Parse(comboboxDan.ActiveText),
											  Int32.Parse(comboboxSatPocetak.ActiveText), Int32.Parse(comboboxMinPocetak.ActiveText),
											  Int32.Parse(comboboxSecPocetak.ActiveText));
			DateTime vrijeme_k = new DateTime(Int32.Parse(comboboxGodina.ActiveText), (int)(comboboxMjesec.Active + 1), Int32.Parse(comboboxDan.ActiveText),
											  Int32.Parse(comboboxSatKraj.ActiveText), Int32.Parse(comboboxMinKraj.ActiveText),
											  Int32.Parse(comboboxSecKraj.ActiveText));
			TimeSpan tot_vrijeme = vrijeme_k - vrijeme_p;

			//Naziv aktivnosti ne smije biti prazan
			if (entryNaziv.Text == "")
			{
				Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Naziv ne može biti prazan.");
				d.Run();
				d.Destroy();
			}
			//Datum rodjenja ne smije biti > danas
			else if (datum > DateTime.Today)
			{
				Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Odaberite valjani datum.");
				d.Run();
				d.Destroy();
			}
			//Tip aktivnosti mora biti odabran
			else if (comboboxTipovi.ActiveText == "")
			{
				Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Odaberite tip aktivnosti.");
				d.Run();
				d.Destroy();
			}
			else if (vrijeme_k <= vrijeme_p)
			{
				Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Odaberite valjano vrijeme aktivnosti.");
				d.Run();
				d.Destroy();
			}
			//Spremi podatke u bazu i zatvori prozor
			else {

				List<TipAktivnosti> listaTipova = new List<TipAktivnosti>();
				listaTipova = Baza.DbUcitajTipAktivnosti();
				foreach (var x in listaTipova)
				{
					if (x.Naziv == comboboxTipovi.ActiveText)
					{
						if (x.JedinicaMjere == "min")
						{
							double minuti = tot_vrijeme.Hours * 60 + tot_vrijeme.Minutes;
							labelPotrosnjaKcal.Text = (minuti * x.KcalPoJediniciMjere).ToString();
						}
						else if (x.JedinicaMjere == "h")
						{
							double sati = tot_vrijeme.Hours;
							labelPotrosnjaKcal.Text = (sati * x.KcalPoJediniciMjere).ToString();
						}
					}
				}

				Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Other, ButtonsType.OkCancel, "Naziv: " + entryNaziv.Text + "\nDatum: "
				                                 + datum.Date.ToString("d") + "\nVrijeme početka: " + vrijeme_p.ToString("HH:mm:ss") + "\nVrijeme kraj: "
												 + vrijeme_k.ToString("HH:mm:ss") + "\nTrajanje " + tot_vrijeme.ToString("c") + "\nPotrosnja: "
												 + labelPotrosnjaKcal.Text);
				var response = (ResponseType)d.Run();
				if (response == ResponseType.Ok)
				{
					AktivnostKorisnika novaAktivnostKorisnika = new AktivnostKorisnika(Int32.Parse(labelAktivnostId.Text), Int32.Parse(labelKorisnikId.Text),
					                                                                   Int32.Parse(labelTipId.Text),entryNaziv.Text, datum, vrijeme_p, 
					                                                                   vrijeme_k, Double.Parse(labelPotrosnjaKcal.Text));
					Baza.UpdateAktivnostiKorisnika(novaAktivnostKorisnika);
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
}
