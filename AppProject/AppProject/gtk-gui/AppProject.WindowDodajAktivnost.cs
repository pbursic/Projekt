
// This file has been generated by the GUI designer. Do not modify.
namespace AppProject
{
	public partial class WindowDodajAktivnost
	{
		private global::Gtk.EventBox eventboxDodajAktivnost;

		private global::Gtk.VBox vbox5;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Label labelDatum;

		private global::Gtk.ComboBox comboboxDan;

		private global::Gtk.ComboBox comboboxMjesec;

		private global::Gtk.ComboBox comboboxGodina;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Label labelKorisnikId;

		private global::Gtk.Calendar calendarAktivnosti;

		private global::Gtk.Label labelTipId;

		private global::Gtk.HBox hbox6;

		private global::Gtk.Label labelNaziv;

		private global::Gtk.Entry entryNaziv;

		private global::Gtk.HBox hbox7;

		private global::Gtk.Label labelTip;

		private global::Gtk.ComboBox comboboxTipovi;

		private global::Gtk.HBox hbox8;

		private global::Gtk.Label labelVrijemePocetka;

		private global::Gtk.ComboBox comboboxSatPocetak;

		private global::Gtk.ComboBox comboboxMinPocetak;

		private global::Gtk.ComboBox comboboxSecPocetak;

		private global::Gtk.HBox hbox11;

		private global::Gtk.Label labelVrijemeKraja;

		private global::Gtk.ComboBox comboboxSatKraj;

		private global::Gtk.ComboBox comboboxMinKraj;

		private global::Gtk.ComboBox comboboxSecKraj;

		private global::Gtk.Fixed fixed12;

		private global::Gtk.HBox hbox10;

		private global::Gtk.Button buttonSpremi;

		private global::Gtk.Button buttonOdustani;

		private global::Gtk.Label labelPotrosnjaKcal;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget AppProject.WindowDodajAktivnost
			this.Name = "AppProject.WindowDodajAktivnost";
			this.Title = global::Mono.Unix.Catalog.GetString("Aktivnost");
			this.Icon = global::Gdk.Pixbuf.LoadFromResource("AppProject.Resources.icon.png");
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			this.Modal = true;
			this.Resizable = false;
			this.AllowGrow = false;
			// Container child AppProject.WindowDodajAktivnost.Gtk.Container+ContainerChild
			this.eventboxDodajAktivnost = new global::Gtk.EventBox();
			this.eventboxDodajAktivnost.Name = "eventboxDodajAktivnost";
			// Container child eventboxDodajAktivnost.Gtk.Container+ContainerChild
			this.vbox5 = new global::Gtk.VBox();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.labelDatum = new global::Gtk.Label();
			this.labelDatum.Name = "labelDatum";
			this.labelDatum.LabelProp = global::Mono.Unix.Catalog.GetString("Datum:");
			this.hbox2.Add(this.labelDatum);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.labelDatum]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.comboboxDan = global::Gtk.ComboBox.NewText();
			this.comboboxDan.Name = "comboboxDan";
			this.hbox2.Add(this.comboboxDan);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.comboboxDan]));
			w2.Position = 1;
			// Container child hbox2.Gtk.Box+BoxChild
			this.comboboxMjesec = global::Gtk.ComboBox.NewText();
			this.comboboxMjesec.AppendText(global::Mono.Unix.Catalog.GetString("sječanj"));
			this.comboboxMjesec.AppendText(global::Mono.Unix.Catalog.GetString("veljača"));
			this.comboboxMjesec.AppendText(global::Mono.Unix.Catalog.GetString("ožujak"));
			this.comboboxMjesec.AppendText(global::Mono.Unix.Catalog.GetString("travanj"));
			this.comboboxMjesec.AppendText(global::Mono.Unix.Catalog.GetString("svibanj"));
			this.comboboxMjesec.AppendText(global::Mono.Unix.Catalog.GetString("lipanj"));
			this.comboboxMjesec.AppendText(global::Mono.Unix.Catalog.GetString("srpanj"));
			this.comboboxMjesec.AppendText(global::Mono.Unix.Catalog.GetString("kolovoz"));
			this.comboboxMjesec.AppendText(global::Mono.Unix.Catalog.GetString("rujan"));
			this.comboboxMjesec.AppendText(global::Mono.Unix.Catalog.GetString("listopad"));
			this.comboboxMjesec.AppendText(global::Mono.Unix.Catalog.GetString("studeni"));
			this.comboboxMjesec.AppendText(global::Mono.Unix.Catalog.GetString("prosinac"));
			this.comboboxMjesec.Name = "comboboxMjesec";
			this.hbox2.Add(this.comboboxMjesec);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.comboboxMjesec]));
			w3.Position = 2;
			// Container child hbox2.Gtk.Box+BoxChild
			this.comboboxGodina = global::Gtk.ComboBox.NewText();
			this.comboboxGodina.Name = "comboboxGodina";
			this.hbox2.Add(this.comboboxGodina);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.comboboxGodina]));
			w4.Position = 3;
			this.vbox5.Add(this.hbox2);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hbox2]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.labelKorisnikId = new global::Gtk.Label();
			this.labelKorisnikId.Name = "labelKorisnikId";
			this.hbox1.Add(this.labelKorisnikId);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.labelKorisnikId]));
			w6.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.calendarAktivnosti = new global::Gtk.Calendar();
			this.calendarAktivnosti.CanFocus = true;
			this.calendarAktivnosti.Name = "calendarAktivnosti";
			this.calendarAktivnosti.DisplayOptions = ((global::Gtk.CalendarDisplayOptions)(35));
			this.hbox1.Add(this.calendarAktivnosti);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.calendarAktivnosti]));
			w7.Position = 1;
			w7.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.labelTipId = new global::Gtk.Label();
			this.labelTipId.Name = "labelTipId";
			this.hbox1.Add(this.labelTipId);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.labelTipId]));
			w8.Position = 2;
			this.vbox5.Add(this.hbox1);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hbox1]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.labelNaziv = new global::Gtk.Label();
			this.labelNaziv.Name = "labelNaziv";
			this.labelNaziv.LabelProp = global::Mono.Unix.Catalog.GetString("Naziv aktivnosti:");
			this.hbox6.Add(this.labelNaziv);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.labelNaziv]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.entryNaziv = new global::Gtk.Entry();
			this.entryNaziv.CanFocus = true;
			this.entryNaziv.Name = "entryNaziv";
			this.entryNaziv.IsEditable = true;
			this.entryNaziv.InvisibleChar = '●';
			this.hbox6.Add(this.entryNaziv);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.entryNaziv]));
			w11.Position = 1;
			this.vbox5.Add(this.hbox6);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hbox6]));
			w12.Position = 2;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox7 = new global::Gtk.HBox();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.labelTip = new global::Gtk.Label();
			this.labelTip.Name = "labelTip";
			this.labelTip.LabelProp = global::Mono.Unix.Catalog.GetString("Tip aktivnosti:");
			this.hbox7.Add(this.labelTip);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.labelTip]));
			w13.Position = 0;
			w13.Expand = false;
			w13.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.comboboxTipovi = global::Gtk.ComboBox.NewText();
			this.comboboxTipovi.Name = "comboboxTipovi";
			this.hbox7.Add(this.comboboxTipovi);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.comboboxTipovi]));
			w14.Position = 1;
			this.vbox5.Add(this.hbox7);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hbox7]));
			w15.Position = 3;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox8 = new global::Gtk.HBox();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.labelVrijemePocetka = new global::Gtk.Label();
			this.labelVrijemePocetka.Name = "labelVrijemePocetka";
			this.labelVrijemePocetka.LabelProp = global::Mono.Unix.Catalog.GetString("Vrijeme Početka:");
			this.hbox8.Add(this.labelVrijemePocetka);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.labelVrijemePocetka]));
			w16.Position = 0;
			w16.Expand = false;
			w16.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.comboboxSatPocetak = global::Gtk.ComboBox.NewText();
			this.comboboxSatPocetak.Name = "comboboxSatPocetak";
			this.hbox8.Add(this.comboboxSatPocetak);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.comboboxSatPocetak]));
			w17.Position = 1;
			w17.Expand = false;
			w17.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.comboboxMinPocetak = global::Gtk.ComboBox.NewText();
			this.comboboxMinPocetak.Name = "comboboxMinPocetak";
			this.hbox8.Add(this.comboboxMinPocetak);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.comboboxMinPocetak]));
			w18.Position = 2;
			w18.Expand = false;
			w18.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.comboboxSecPocetak = global::Gtk.ComboBox.NewText();
			this.comboboxSecPocetak.Name = "comboboxSecPocetak";
			this.hbox8.Add(this.comboboxSecPocetak);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.comboboxSecPocetak]));
			w19.Position = 3;
			w19.Expand = false;
			w19.Fill = false;
			this.vbox5.Add(this.hbox8);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hbox8]));
			w20.Position = 4;
			w20.Expand = false;
			w20.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox11 = new global::Gtk.HBox();
			this.hbox11.Name = "hbox11";
			this.hbox11.Spacing = 6;
			// Container child hbox11.Gtk.Box+BoxChild
			this.labelVrijemeKraja = new global::Gtk.Label();
			this.labelVrijemeKraja.Name = "labelVrijemeKraja";
			this.labelVrijemeKraja.LabelProp = global::Mono.Unix.Catalog.GetString("Vrijeme Kraja:");
			this.hbox11.Add(this.labelVrijemeKraja);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.labelVrijemeKraja]));
			w21.Position = 0;
			w21.Expand = false;
			w21.Fill = false;
			// Container child hbox11.Gtk.Box+BoxChild
			this.comboboxSatKraj = global::Gtk.ComboBox.NewText();
			this.comboboxSatKraj.Name = "comboboxSatKraj";
			this.hbox11.Add(this.comboboxSatKraj);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.comboboxSatKraj]));
			w22.Position = 1;
			w22.Expand = false;
			w22.Fill = false;
			// Container child hbox11.Gtk.Box+BoxChild
			this.comboboxMinKraj = global::Gtk.ComboBox.NewText();
			this.comboboxMinKraj.Name = "comboboxMinKraj";
			this.hbox11.Add(this.comboboxMinKraj);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.comboboxMinKraj]));
			w23.Position = 2;
			w23.Expand = false;
			w23.Fill = false;
			// Container child hbox11.Gtk.Box+BoxChild
			this.comboboxSecKraj = global::Gtk.ComboBox.NewText();
			this.comboboxSecKraj.Name = "comboboxSecKraj";
			this.hbox11.Add(this.comboboxSecKraj);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.comboboxSecKraj]));
			w24.Position = 3;
			w24.Expand = false;
			w24.Fill = false;
			this.vbox5.Add(this.hbox11);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hbox11]));
			w25.Position = 5;
			w25.Expand = false;
			w25.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.fixed12 = new global::Gtk.Fixed();
			this.fixed12.Name = "fixed12";
			this.fixed12.HasWindow = false;
			this.vbox5.Add(this.fixed12);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.fixed12]));
			w26.Position = 6;
			w26.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox10 = new global::Gtk.HBox();
			this.hbox10.Name = "hbox10";
			this.hbox10.Spacing = 6;
			// Container child hbox10.Gtk.Box+BoxChild
			this.buttonSpremi = new global::Gtk.Button();
			this.buttonSpremi.CanFocus = true;
			this.buttonSpremi.Name = "buttonSpremi";
			this.buttonSpremi.UseUnderline = true;
			this.buttonSpremi.Label = global::Mono.Unix.Catalog.GetString("Spremi");
			this.hbox10.Add(this.buttonSpremi);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox10[this.buttonSpremi]));
			w27.Position = 1;
			w27.Fill = false;
			// Container child hbox10.Gtk.Box+BoxChild
			this.buttonOdustani = new global::Gtk.Button();
			this.buttonOdustani.CanFocus = true;
			this.buttonOdustani.Name = "buttonOdustani";
			this.buttonOdustani.UseUnderline = true;
			this.buttonOdustani.Label = global::Mono.Unix.Catalog.GetString("Odustani");
			this.hbox10.Add(this.buttonOdustani);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox10[this.buttonOdustani]));
			w28.Position = 2;
			w28.Fill = false;
			this.vbox5.Add(this.hbox10);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hbox10]));
			w29.Position = 7;
			w29.Expand = false;
			w29.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.labelPotrosnjaKcal = new global::Gtk.Label();
			this.labelPotrosnjaKcal.Name = "labelPotrosnjaKcal";
			this.vbox5.Add(this.labelPotrosnjaKcal);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.labelPotrosnjaKcal]));
			w30.PackType = ((global::Gtk.PackType)(1));
			w30.Position = 8;
			w30.Fill = false;
			this.eventboxDodajAktivnost.Add(this.vbox5);
			this.Add(this.eventboxDodajAktivnost);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 561;
			this.DefaultHeight = 455;
			this.labelKorisnikId.Hide();
			this.labelTipId.Hide();
			this.labelPotrosnjaKcal.Hide();
			this.Show();
			this.calendarAktivnosti.PrevMonth += new global::System.EventHandler(this.UpdateDate);
			this.calendarAktivnosti.PrevYear += new global::System.EventHandler(this.UpdateDate);
			this.calendarAktivnosti.NextYear += new global::System.EventHandler(this.UpdateDate);
			this.calendarAktivnosti.MonthChanged += new global::System.EventHandler(this.UpdateDate);
			this.calendarAktivnosti.DaySelected += new global::System.EventHandler(this.UpdateDate);
			this.calendarAktivnosti.NextMonth += new global::System.EventHandler(this.UpdateDate);
			this.comboboxTipovi.Changed += new global::System.EventHandler(this.JedinicaMjere);
			this.buttonSpremi.Clicked += new global::System.EventHandler(this.SpremiClicked);
			this.buttonOdustani.Clicked += new global::System.EventHandler(this.OdustaniClicked);
		}
	}
}
