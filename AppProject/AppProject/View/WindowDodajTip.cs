using System;
using Gtk;

namespace AppProject
{
	public partial class WindowDodajTip : Gtk.Window
	{
		public WindowDodajTip() :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();

			Gdk.Color colorLightBlue = new Gdk.Color();
			Gdk.Color.Parse("#3FB2F0", ref colorLightBlue);
			eventboxDodajTip.ModifyBg(StateType.Normal, colorLightBlue);
			Add(eventboxDodajTip);
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
				                                 +"\nPotrosnja: "+ entryPotrosnja.Text + " kcal/" + comboboxJedinicaMjereTipaAktivnosti.ActiveText 
				                                 +"\n\nŽelite li spremiti tip aktivnosti?");
				var response = (ResponseType)d.Run();
				if (response == ResponseType.Ok)
				{
					TipAktivnosti noviTipAktivnosti = new TipAktivnosti(0,entryNazivTipAktivnosti.Text, comboboxJedinicaMjereTipaAktivnosti.ActiveText, Double.Parse(entryPotrosnja.Text));
					Baza.DbSpremiTipAktivnosti(noviTipAktivnosti);
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
