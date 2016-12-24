
// This file has been generated by the GUI designer. Do not modify.
namespace AppProject
{
	public partial class WindowDodajTip
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.Label labelTitle;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Label labelNaziv;

		private global::Gtk.Entry entryNazivTipAktivnosti;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Label labelPotrosnja;

		private global::Gtk.ComboBox comboboxJedinicaMjereTipaAktivnosti;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Label labelPotrosnja1;

		private global::Gtk.Entry entryPotrosnja;

		private global::Gtk.Label labelJedinicaMjere;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Button buttonOk;

		private global::Gtk.Button buttonCancel;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget AppProject.WindowDodajTip
			this.Name = "AppProject.WindowDodajTip";
			this.Title = global::Mono.Unix.Catalog.GetString("WindowDodajTip");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child AppProject.WindowDodajTip.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.labelTitle = new global::Gtk.Label();
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.LabelProp = global::Mono.Unix.Catalog.GetString("Novi Tip Aktivnosti");
			this.vbox1.Add(this.labelTitle);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.labelTitle]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.labelNaziv = new global::Gtk.Label();
			this.labelNaziv.Name = "labelNaziv";
			this.labelNaziv.LabelProp = global::Mono.Unix.Catalog.GetString("Naziv tipa aktivnosti: ");
			this.hbox1.Add(this.labelNaziv);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.labelNaziv]));
			w2.Position = 0;
			w2.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.entryNazivTipAktivnosti = new global::Gtk.Entry();
			this.entryNazivTipAktivnosti.CanFocus = true;
			this.entryNazivTipAktivnosti.Name = "entryNazivTipAktivnosti";
			this.entryNazivTipAktivnosti.IsEditable = true;
			this.entryNazivTipAktivnosti.InvisibleChar = '●';
			this.hbox1.Add(this.entryNazivTipAktivnosti);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.entryNazivTipAktivnosti]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			this.vbox1.Add(this.hbox1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
			w4.Position = 2;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.labelPotrosnja = new global::Gtk.Label();
			this.labelPotrosnja.Name = "labelPotrosnja";
			this.labelPotrosnja.LabelProp = global::Mono.Unix.Catalog.GetString("Jedinica mjere potrosnje: ");
			this.hbox2.Add(this.labelPotrosnja);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.labelPotrosnja]));
			w5.Position = 0;
			w5.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.comboboxJedinicaMjereTipaAktivnosti = global::Gtk.ComboBox.NewText();
			this.comboboxJedinicaMjereTipaAktivnosti.AppendText("");
			this.comboboxJedinicaMjereTipaAktivnosti.AppendText(global::Mono.Unix.Catalog.GetString("m"));
			this.comboboxJedinicaMjereTipaAktivnosti.AppendText(global::Mono.Unix.Catalog.GetString("km"));
			this.comboboxJedinicaMjereTipaAktivnosti.AppendText(global::Mono.Unix.Catalog.GetString("km/h"));
			this.comboboxJedinicaMjereTipaAktivnosti.AppendText(global::Mono.Unix.Catalog.GetString("min"));
			this.comboboxJedinicaMjereTipaAktivnosti.AppendText(global::Mono.Unix.Catalog.GetString("h"));
			this.comboboxJedinicaMjereTipaAktivnosti.Name = "comboboxJedinicaMjereTipaAktivnosti";
			this.comboboxJedinicaMjereTipaAktivnosti.Active = 0;
			this.hbox2.Add(this.comboboxJedinicaMjereTipaAktivnosti);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.comboboxJedinicaMjereTipaAktivnosti]));
			w6.Position = 1;
			this.vbox1.Add(this.hbox2);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox2]));
			w7.Position = 3;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.labelPotrosnja1 = new global::Gtk.Label();
			this.labelPotrosnja1.Name = "labelPotrosnja1";
			this.labelPotrosnja1.LabelProp = global::Mono.Unix.Catalog.GetString("Potrošnja: ");
			this.hbox3.Add(this.labelPotrosnja1);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.labelPotrosnja1]));
			w8.Position = 0;
			// Container child hbox3.Gtk.Box+BoxChild
			this.entryPotrosnja = new global::Gtk.Entry();
			this.entryPotrosnja.CanFocus = true;
			this.entryPotrosnja.Name = "entryPotrosnja";
			this.entryPotrosnja.IsEditable = true;
			this.entryPotrosnja.InvisibleChar = '●';
			this.hbox3.Add(this.entryPotrosnja);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.entryPotrosnja]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.labelJedinicaMjere = new global::Gtk.Label();
			this.labelJedinicaMjere.Name = "labelJedinicaMjere";
			this.hbox3.Add(this.labelJedinicaMjere);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.labelJedinicaMjere]));
			w10.Position = 2;
			this.vbox1.Add(this.hbox3);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox3]));
			w11.Position = 4;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.buttonOk = new global::Gtk.Button();
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = global::Mono.Unix.Catalog.GetString("Spremi");
			this.hbox4.Add(this.buttonOk);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.buttonOk]));
			w12.Position = 0;
			w12.Expand = false;
			w12.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.buttonCancel = new global::Gtk.Button();
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = global::Mono.Unix.Catalog.GetString("Odustani");
			this.hbox4.Add(this.buttonCancel);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.buttonCancel]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			this.vbox1.Add(this.hbox4);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox4]));
			w14.Position = 5;
			w14.Expand = false;
			w14.Fill = false;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 398;
			this.DefaultHeight = 240;
			this.Show();
			this.comboboxJedinicaMjereTipaAktivnosti.Changed += new global::System.EventHandler(this.PromjeniLabel);
			this.buttonOk.Clicked += new global::System.EventHandler(this.SpremiClicked);
			this.buttonCancel.Clicked += new global::System.EventHandler(this.OdustaniClicked);
		}
	}
}
