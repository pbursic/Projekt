using System;
using Gtk;

namespace AppProject
{
	public partial class WindowMijenjajTip : Gtk.Window
	{
		public WindowMijenjajTip(TipAktivnostiNode t) :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();

			Gdk.Color colorLightBlue = new Gdk.Color();
			Gdk.Color.Parse("#3FB2F0", ref colorLightBlue);
			eventboxMijenjajTip.ModifyBg(Gtk.StateType.Normal, colorLightBlue);
			Add(eventboxMijenjajTip);

			labelID.Text = t.id.ToString();
			entryNazivTipAktivnosti.Text = t.naziv;
			entryPotrosnja.Text = t.kalorijeJedinica;
			labelJedinicaMjere.Text = t.tip;
			PopuniJedinicu();
		}

		public void PopuniJedinicu()
		{
			string x = labelJedinicaMjere.Text;

			switch (x)
			{
				case "m":
					comboboxJedinicaMjereTipaAktivnosti.Active = 1;
					break;
				case "km":
					comboboxJedinicaMjereTipaAktivnosti.Active = 2;
					break;
				case "km/h":
					comboboxJedinicaMjereTipaAktivnosti.Active = 3;
					break;
				case "min":
					comboboxJedinicaMjereTipaAktivnosti.Active = 4;
					break;
				case "h":
					comboboxJedinicaMjereTipaAktivnosti.Active = 5;
					break;
			}
		}

		protected void PromjeniLabel(object sender, EventArgs e)
		{
			if (comboboxJedinicaMjereTipaAktivnosti.ActiveText == "")
			{
				labelJedinicaMjere.Text = "";
			}
			else
			{
				labelJedinicaMjere.Text = "kcal/" + comboboxJedinicaMjereTipaAktivnosti.ActiveText;
			}
		}

		protected void SpremiClicked(object sender, EventArgs e)
		{
			//Naziv ne smije biti prazan
			if (entryNazivTipAktivnosti.Text == "")
			{
				Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Naziv tipa aktivnosti ne može biti prazan.");
				d.Run();
				d.Destroy();
			}
			//Jedinica mjere potrošnje ne smije biti prazna
			else if (comboboxJedinicaMjereTipaAktivnosti.ActiveText == "")
			{
				Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Odaberite jedinicu mjere potrošnje.");
				d.Run();
				d.Destroy();
			}
			//Potrošnja ne smije biti prazna
			else if (entryPotrosnja.Text == "")
			{
				Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Unesite potrošnju.");
				d.Run();
				d.Destroy();
			}
			//Spremi podatke u bazu i zatvori prozor
			else {
				Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Other, ButtonsType.OkCancel, "Naziv: " + entryNazivTipAktivnosti.Text
												 + "\nPotrosnja: " + entryPotrosnja.Text + " kcal/" + comboboxJedinicaMjereTipaAktivnosti.ActiveText
												 + "\n\nŽelite li spremiti tip aktivnosti?");
				var response = (ResponseType)d.Run();
				if (response == ResponseType.Ok)
				{
					TipAktivnosti noviTipAktivnosti = new TipAktivnosti(Int32.Parse(labelID.Text), entryNazivTipAktivnosti.Text, comboboxJedinicaMjereTipaAktivnosti.ActiveText, Double.Parse(entryPotrosnja.Text));
					Baza.UpdateTipAktivnosti(noviTipAktivnosti);
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
