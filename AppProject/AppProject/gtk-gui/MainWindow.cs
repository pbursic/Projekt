
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.EventBox eventboxMain;

	private global::Gtk.HBox hbox1;

	private global::Gtk.Notebook notebookMenu;

	private global::Gtk.VBox vbox16;

	private global::Gtk.Button buttonMenuKorisnici;

	private global::Gtk.Button buttonMenuTipAktivnosti;

	private global::Gtk.HBox hbox11;

	private global::Gtk.Button buttonIzlaz;

	private global::Gtk.Label labelMenu;

	private global::Gtk.VBox vbox15;

	private global::Gtk.Button button1;

	private global::Gtk.HBox hbox9;

	private global::Gtk.Button button6;

	private global::Gtk.Button buttonIzlaz1;

	private global::Gtk.Label labelTipAktivnosti;

	private global::Gtk.VBox vbox1;

	private global::Gtk.HBox hbox2;

	private global::Gtk.Label label8;

	private global::Gtk.Label labelCurrentKorisnik;

	private global::Gtk.Button buttonAktivnosti;

	private global::Gtk.Button buttonStatistika;

	private global::Gtk.HBox hbox10;

	private global::Gtk.Button button10;

	private global::Gtk.Button buttonIzlaz2;

	private global::Gtk.Label labelKorisnici;

	private global::Gtk.VBox vbox2;

	private global::Gtk.Notebook notebookGlavni;

	private global::Gtk.Label label1;

	private global::Gtk.VBox vbox3;

	private global::Gtk.EventBox eventboxKorisniciUp;

	private global::Gtk.HBox hbox6;

	private global::Gtk.Entry entry4;

	private global::Gtk.Button button4;

	private global::Gtk.ScrolledWindow GtkScrolledWindow;

	private global::Gtk.NodeView nodeviewKorisnici;

	private global::Gtk.EventBox eventboxKorisniciDown;

	private global::Gtk.HBox hbox3;

	private global::Gtk.VBox vbox9;

	private global::Gtk.Button buttonNoviKorisnik;

	private global::Gtk.VBox vbox10;

	private global::Gtk.Button buttonMijenjajKorisnika;

	private global::Gtk.VBox vbox11;

	private global::Gtk.Button buttonObrisiKorisnika;

	private global::Gtk.Label labelViewKorisnici;

	private global::Gtk.VBox vbox4;

	private global::Gtk.EventBox eventboxAktivnostiUp;

	private global::Gtk.HBox hbox5;

	private global::Gtk.Entry entry3;

	private global::Gtk.Button button3;

	private global::Gtk.ScrolledWindow GtkScrolledWindow1;

	private global::Gtk.NodeView nodeviewAktivnostiKorisnika;

	private global::Gtk.EventBox eventboxAktivnostiDown;

	private global::Gtk.HBox hbox4;

	private global::Gtk.VBox vbox6;

	private global::Gtk.Button buttonNovaAktivnost;

	private global::Gtk.VBox vbox7;

	private global::Gtk.Button buttonMijenjajAktivnost;

	private global::Gtk.VBox vbox8;

	private global::Gtk.Button buttonObrisiAktivnost;

	private global::Gtk.Fixed fixed3;

	private global::Gtk.Calendar calendar;

	private global::Gtk.Label labelViewAktivnostiKorisnika;

	private global::Gtk.VBox vbox5;

	private global::Gtk.EventBox eventboxTipUp;

	private global::Gtk.HBox hbox7;

	private global::Gtk.Entry entry5;

	private global::Gtk.Button button5;

	private global::Gtk.ScrolledWindow GtkScrolledWindow2;

	private global::Gtk.NodeView nodeviewTip;

	private global::Gtk.EventBox eventboxTipDown;

	private global::Gtk.HBox hbox8;

	private global::Gtk.VBox vbox12;

	private global::Gtk.Button buttonNoviTip;

	private global::Gtk.VBox vbox13;

	private global::Gtk.Button buttonMijenjajTip;

	private global::Gtk.VBox vbox14;

	private global::Gtk.Button buttonObrisiTip;

	private global::Gtk.Label labelTipoviAktivnosti;

	private global::Gtk.Label labelStatistika;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("Tjelesna Aktivnost");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.eventboxMain = new global::Gtk.EventBox();
		this.eventboxMain.Name = "eventboxMain";
		// Container child eventboxMain.Gtk.Container+ContainerChild
		this.hbox1 = new global::Gtk.HBox();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.notebookMenu = new global::Gtk.Notebook();
		this.notebookMenu.WidthRequest = 300;
		this.notebookMenu.CanFocus = true;
		this.notebookMenu.Name = "notebookMenu";
		this.notebookMenu.CurrentPage = 1;
		this.notebookMenu.TabPos = ((global::Gtk.PositionType)(0));
		// Container child notebookMenu.Gtk.Notebook+NotebookChild
		this.vbox16 = new global::Gtk.VBox();
		this.vbox16.Name = "vbox16";
		this.vbox16.Spacing = 6;
		// Container child vbox16.Gtk.Box+BoxChild
		this.buttonMenuKorisnici = new global::Gtk.Button();
		this.buttonMenuKorisnici.CanFocus = true;
		this.buttonMenuKorisnici.Name = "buttonMenuKorisnici";
		this.buttonMenuKorisnici.UseUnderline = true;
		this.buttonMenuKorisnici.Label = global::Mono.Unix.Catalog.GetString("Korisnici");
		this.vbox16.Add(this.buttonMenuKorisnici);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox16[this.buttonMenuKorisnici]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child vbox16.Gtk.Box+BoxChild
		this.buttonMenuTipAktivnosti = new global::Gtk.Button();
		this.buttonMenuTipAktivnosti.CanFocus = true;
		this.buttonMenuTipAktivnosti.Name = "buttonMenuTipAktivnosti";
		this.buttonMenuTipAktivnosti.UseUnderline = true;
		this.buttonMenuTipAktivnosti.Label = global::Mono.Unix.Catalog.GetString("Tip Aktivnosti");
		this.vbox16.Add(this.buttonMenuTipAktivnosti);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox16[this.buttonMenuTipAktivnosti]));
		w2.Position = 1;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox16.Gtk.Box+BoxChild
		this.hbox11 = new global::Gtk.HBox();
		this.hbox11.Name = "hbox11";
		this.hbox11.Spacing = 6;
		// Container child hbox11.Gtk.Box+BoxChild
		this.buttonIzlaz = new global::Gtk.Button();
		this.buttonIzlaz.CanFocus = true;
		this.buttonIzlaz.Name = "buttonIzlaz";
		this.buttonIzlaz.UseUnderline = true;
		this.buttonIzlaz.Label = global::Mono.Unix.Catalog.GetString("Izlaz");
		this.hbox11.Add(this.buttonIzlaz);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.buttonIzlaz]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		this.vbox16.Add(this.hbox11);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox16[this.hbox11]));
		w4.Position = 3;
		w4.Expand = false;
		w4.Fill = false;
		this.notebookMenu.Add(this.vbox16);
		// Notebook tab
		this.labelMenu = new global::Gtk.Label();
		this.labelMenu.Name = "labelMenu";
		this.labelMenu.LabelProp = global::Mono.Unix.Catalog.GetString("Menu");
		this.notebookMenu.SetTabLabel(this.vbox16, this.labelMenu);
		this.labelMenu.ShowAll();
		// Container child notebookMenu.Gtk.Notebook+NotebookChild
		this.vbox15 = new global::Gtk.VBox();
		this.vbox15.Name = "vbox15";
		this.vbox15.Spacing = 6;
		// Container child vbox15.Gtk.Box+BoxChild
		this.button1 = new global::Gtk.Button();
		this.button1.CanFocus = true;
		this.button1.Name = "button1";
		this.button1.UseUnderline = true;
		this.button1.Label = global::Mono.Unix.Catalog.GetString("Pregled");
		this.vbox15.Add(this.button1);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox15[this.button1]));
		w6.Position = 0;
		w6.Expand = false;
		w6.Fill = false;
		// Container child vbox15.Gtk.Box+BoxChild
		this.hbox9 = new global::Gtk.HBox();
		this.hbox9.Name = "hbox9";
		this.hbox9.Spacing = 6;
		// Container child hbox9.Gtk.Box+BoxChild
		this.button6 = new global::Gtk.Button();
		this.button6.CanFocus = true;
		this.button6.Name = "button6";
		this.button6.UseUnderline = true;
		this.button6.Label = global::Mono.Unix.Catalog.GetString("Menu");
		this.hbox9.Add(this.button6);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.button6]));
		w7.Position = 0;
		w7.Expand = false;
		w7.Fill = false;
		// Container child hbox9.Gtk.Box+BoxChild
		this.buttonIzlaz1 = new global::Gtk.Button();
		this.buttonIzlaz1.CanFocus = true;
		this.buttonIzlaz1.Name = "buttonIzlaz1";
		this.buttonIzlaz1.UseUnderline = true;
		this.buttonIzlaz1.Label = global::Mono.Unix.Catalog.GetString("Izlaz");
		this.hbox9.Add(this.buttonIzlaz1);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.buttonIzlaz1]));
		w8.Position = 1;
		w8.Expand = false;
		w8.Fill = false;
		this.vbox15.Add(this.hbox9);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox15[this.hbox9]));
		w9.Position = 3;
		w9.Expand = false;
		w9.Fill = false;
		this.notebookMenu.Add(this.vbox15);
		global::Gtk.Notebook.NotebookChild w10 = ((global::Gtk.Notebook.NotebookChild)(this.notebookMenu[this.vbox15]));
		w10.Position = 1;
		// Notebook tab
		this.labelTipAktivnosti = new global::Gtk.Label();
		this.labelTipAktivnosti.Name = "labelTipAktivnosti";
		this.labelTipAktivnosti.LabelProp = global::Mono.Unix.Catalog.GetString("Tip Aktivnosti");
		this.notebookMenu.SetTabLabel(this.vbox15, this.labelTipAktivnosti);
		this.labelTipAktivnosti.ShowAll();
		// Container child notebookMenu.Gtk.Notebook+NotebookChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.label8 = new global::Gtk.Label();
		this.label8.Name = "label8";
		this.label8.LabelProp = global::Mono.Unix.Catalog.GetString("Korisnik:");
		this.hbox2.Add(this.label8);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label8]));
		w11.Position = 0;
		w11.Expand = false;
		w11.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.labelCurrentKorisnik = new global::Gtk.Label();
		this.labelCurrentKorisnik.Name = "labelCurrentKorisnik";
		this.labelCurrentKorisnik.LabelProp = global::Mono.Unix.Catalog.GetString("-");
		this.hbox2.Add(this.labelCurrentKorisnik);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.labelCurrentKorisnik]));
		w12.Position = 1;
		w12.Expand = false;
		w12.Fill = false;
		this.vbox1.Add(this.hbox2);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox2]));
		w13.Position = 0;
		w13.Expand = false;
		w13.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.buttonAktivnosti = new global::Gtk.Button();
		this.buttonAktivnosti.CanFocus = true;
		this.buttonAktivnosti.Name = "buttonAktivnosti";
		this.buttonAktivnosti.UseUnderline = true;
		this.buttonAktivnosti.Label = global::Mono.Unix.Catalog.GetString("Aktivnosti");
		this.vbox1.Add(this.buttonAktivnosti);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.buttonAktivnosti]));
		w14.Position = 1;
		w14.Expand = false;
		w14.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.buttonStatistika = new global::Gtk.Button();
		this.buttonStatistika.CanFocus = true;
		this.buttonStatistika.Name = "buttonStatistika";
		this.buttonStatistika.UseUnderline = true;
		this.buttonStatistika.Label = global::Mono.Unix.Catalog.GetString("Statistika");
		this.vbox1.Add(this.buttonStatistika);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.buttonStatistika]));
		w15.Position = 2;
		w15.Expand = false;
		w15.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox10 = new global::Gtk.HBox();
		this.hbox10.Name = "hbox10";
		this.hbox10.Spacing = 6;
		// Container child hbox10.Gtk.Box+BoxChild
		this.button10 = new global::Gtk.Button();
		this.button10.CanFocus = true;
		this.button10.Name = "button10";
		this.button10.UseUnderline = true;
		this.button10.Label = global::Mono.Unix.Catalog.GetString("Menu");
		this.hbox10.Add(this.button10);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox10[this.button10]));
		w16.Position = 0;
		w16.Expand = false;
		w16.Fill = false;
		// Container child hbox10.Gtk.Box+BoxChild
		this.buttonIzlaz2 = new global::Gtk.Button();
		this.buttonIzlaz2.CanFocus = true;
		this.buttonIzlaz2.Name = "buttonIzlaz2";
		this.buttonIzlaz2.UseUnderline = true;
		this.buttonIzlaz2.Label = global::Mono.Unix.Catalog.GetString("Izlaz");
		this.hbox10.Add(this.buttonIzlaz2);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox10[this.buttonIzlaz2]));
		w17.Position = 1;
		w17.Expand = false;
		w17.Fill = false;
		this.vbox1.Add(this.hbox10);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox10]));
		w18.Position = 4;
		w18.Expand = false;
		w18.Fill = false;
		this.notebookMenu.Add(this.vbox1);
		global::Gtk.Notebook.NotebookChild w19 = ((global::Gtk.Notebook.NotebookChild)(this.notebookMenu[this.vbox1]));
		w19.Position = 2;
		// Notebook tab
		this.labelKorisnici = new global::Gtk.Label();
		this.labelKorisnici.Name = "labelKorisnici";
		this.labelKorisnici.LabelProp = global::Mono.Unix.Catalog.GetString("Korisnici");
		this.notebookMenu.SetTabLabel(this.vbox1, this.labelKorisnici);
		this.labelKorisnici.ShowAll();
		this.hbox1.Add(this.notebookMenu);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.notebookMenu]));
		w20.Position = 0;
		w20.Expand = false;
		w20.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.vbox2 = new global::Gtk.VBox();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.notebookGlavni = new global::Gtk.Notebook();
		this.notebookGlavni.CanFocus = true;
		this.notebookGlavni.Name = "notebookGlavni";
		this.notebookGlavni.CurrentPage = 3;
		// Notebook tab
		global::Gtk.Label w21 = new global::Gtk.Label();
		w21.Visible = true;
		this.notebookGlavni.Add(w21);
		this.label1 = new global::Gtk.Label();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Menu");
		this.notebookGlavni.SetTabLabel(w21, this.label1);
		this.label1.ShowAll();
		// Container child notebookGlavni.Gtk.Notebook+NotebookChild
		this.vbox3 = new global::Gtk.VBox();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.eventboxKorisniciUp = new global::Gtk.EventBox();
		this.eventboxKorisniciUp.Name = "eventboxKorisniciUp";
		// Container child eventboxKorisniciUp.Gtk.Container+ContainerChild
		this.hbox6 = new global::Gtk.HBox();
		this.hbox6.Name = "hbox6";
		this.hbox6.Spacing = 6;
		// Container child hbox6.Gtk.Box+BoxChild
		this.entry4 = new global::Gtk.Entry();
		this.entry4.CanFocus = true;
		this.entry4.Name = "entry4";
		this.entry4.IsEditable = true;
		this.entry4.InvisibleChar = '●';
		this.hbox6.Add(this.entry4);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.entry4]));
		w22.Position = 0;
		// Container child hbox6.Gtk.Box+BoxChild
		this.button4 = new global::Gtk.Button();
		this.button4.CanFocus = true;
		this.button4.Name = "button4";
		this.button4.UseUnderline = true;
		this.button4.Label = global::Mono.Unix.Catalog.GetString("Pretraži");
		this.hbox6.Add(this.button4);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.button4]));
		w23.Position = 1;
		w23.Expand = false;
		w23.Fill = false;
		this.eventboxKorisniciUp.Add(this.hbox6);
		this.vbox3.Add(this.eventboxKorisniciUp);
		global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.eventboxKorisniciUp]));
		w25.Position = 0;
		w25.Expand = false;
		w25.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.nodeviewKorisnici = new global::Gtk.NodeView();
		this.nodeviewKorisnici.CanFocus = true;
		this.nodeviewKorisnici.Name = "nodeviewKorisnici";
		this.GtkScrolledWindow.Add(this.nodeviewKorisnici);
		this.vbox3.Add(this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.GtkScrolledWindow]));
		w27.Position = 1;
		// Container child vbox3.Gtk.Box+BoxChild
		this.eventboxKorisniciDown = new global::Gtk.EventBox();
		this.eventboxKorisniciDown.Name = "eventboxKorisniciDown";
		// Container child eventboxKorisniciDown.Gtk.Container+ContainerChild
		this.hbox3 = new global::Gtk.HBox();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.vbox9 = new global::Gtk.VBox();
		this.vbox9.Name = "vbox9";
		this.vbox9.Spacing = 6;
		// Container child vbox9.Gtk.Box+BoxChild
		this.buttonNoviKorisnik = new global::Gtk.Button();
		this.buttonNoviKorisnik.CanFocus = true;
		this.buttonNoviKorisnik.Name = "buttonNoviKorisnik";
		this.buttonNoviKorisnik.UseUnderline = true;
		this.buttonNoviKorisnik.Label = global::Mono.Unix.Catalog.GetString("Dodaj Novog Korisnika");
		this.vbox9.Add(this.buttonNoviKorisnik);
		global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox9[this.buttonNoviKorisnik]));
		w28.Position = 0;
		w28.Expand = false;
		w28.Fill = false;
		this.hbox3.Add(this.vbox9);
		global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.vbox9]));
		w29.Position = 0;
		w29.Expand = false;
		w29.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.vbox10 = new global::Gtk.VBox();
		this.vbox10.Name = "vbox10";
		this.vbox10.Spacing = 6;
		// Container child vbox10.Gtk.Box+BoxChild
		this.buttonMijenjajKorisnika = new global::Gtk.Button();
		this.buttonMijenjajKorisnika.CanFocus = true;
		this.buttonMijenjajKorisnika.Name = "buttonMijenjajKorisnika";
		this.buttonMijenjajKorisnika.UseUnderline = true;
		this.buttonMijenjajKorisnika.Label = global::Mono.Unix.Catalog.GetString("Mijenjaj Korisnika");
		this.vbox10.Add(this.buttonMijenjajKorisnika);
		global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox10[this.buttonMijenjajKorisnika]));
		w30.Position = 0;
		w30.Expand = false;
		w30.Fill = false;
		this.hbox3.Add(this.vbox10);
		global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.vbox10]));
		w31.Position = 1;
		w31.Expand = false;
		w31.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.vbox11 = new global::Gtk.VBox();
		this.vbox11.Name = "vbox11";
		this.vbox11.Spacing = 6;
		// Container child vbox11.Gtk.Box+BoxChild
		this.buttonObrisiKorisnika = new global::Gtk.Button();
		this.buttonObrisiKorisnika.CanFocus = true;
		this.buttonObrisiKorisnika.Name = "buttonObrisiKorisnika";
		this.buttonObrisiKorisnika.UseUnderline = true;
		this.buttonObrisiKorisnika.Label = global::Mono.Unix.Catalog.GetString("Obriši Korisnika");
		this.vbox11.Add(this.buttonObrisiKorisnika);
		global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.vbox11[this.buttonObrisiKorisnika]));
		w32.Position = 0;
		w32.Expand = false;
		w32.Fill = false;
		this.hbox3.Add(this.vbox11);
		global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.vbox11]));
		w33.Position = 2;
		w33.Expand = false;
		w33.Fill = false;
		this.eventboxKorisniciDown.Add(this.hbox3);
		this.vbox3.Add(this.eventboxKorisniciDown);
		global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.eventboxKorisniciDown]));
		w35.Position = 2;
		this.notebookGlavni.Add(this.vbox3);
		global::Gtk.Notebook.NotebookChild w36 = ((global::Gtk.Notebook.NotebookChild)(this.notebookGlavni[this.vbox3]));
		w36.Position = 1;
		// Notebook tab
		this.labelViewKorisnici = new global::Gtk.Label();
		this.labelViewKorisnici.Name = "labelViewKorisnici";
		this.labelViewKorisnici.LabelProp = global::Mono.Unix.Catalog.GetString("Korisnici");
		this.notebookGlavni.SetTabLabel(this.vbox3, this.labelViewKorisnici);
		this.labelViewKorisnici.ShowAll();
		// Container child notebookGlavni.Gtk.Notebook+NotebookChild
		this.vbox4 = new global::Gtk.VBox();
		this.vbox4.Name = "vbox4";
		this.vbox4.Spacing = 6;
		// Container child vbox4.Gtk.Box+BoxChild
		this.eventboxAktivnostiUp = new global::Gtk.EventBox();
		this.eventboxAktivnostiUp.Name = "eventboxAktivnostiUp";
		// Container child eventboxAktivnostiUp.Gtk.Container+ContainerChild
		this.hbox5 = new global::Gtk.HBox();
		this.hbox5.Name = "hbox5";
		this.hbox5.Spacing = 6;
		// Container child hbox5.Gtk.Box+BoxChild
		this.entry3 = new global::Gtk.Entry();
		this.entry3.CanFocus = true;
		this.entry3.Name = "entry3";
		this.entry3.IsEditable = true;
		this.entry3.InvisibleChar = '●';
		this.hbox5.Add(this.entry3);
		global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.entry3]));
		w37.Position = 0;
		// Container child hbox5.Gtk.Box+BoxChild
		this.button3 = new global::Gtk.Button();
		this.button3.CanFocus = true;
		this.button3.Name = "button3";
		this.button3.UseUnderline = true;
		this.button3.Label = global::Mono.Unix.Catalog.GetString("Pretraži");
		this.hbox5.Add(this.button3);
		global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.button3]));
		w38.Position = 1;
		w38.Expand = false;
		w38.Fill = false;
		this.eventboxAktivnostiUp.Add(this.hbox5);
		this.vbox4.Add(this.eventboxAktivnostiUp);
		global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.eventboxAktivnostiUp]));
		w40.Position = 0;
		w40.Expand = false;
		w40.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
		this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
		this.nodeviewAktivnostiKorisnika = new global::Gtk.NodeView();
		this.nodeviewAktivnostiKorisnika.CanFocus = true;
		this.nodeviewAktivnostiKorisnika.Name = "nodeviewAktivnostiKorisnika";
		this.GtkScrolledWindow1.Add(this.nodeviewAktivnostiKorisnika);
		this.vbox4.Add(this.GtkScrolledWindow1);
		global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.GtkScrolledWindow1]));
		w42.Position = 1;
		// Container child vbox4.Gtk.Box+BoxChild
		this.eventboxAktivnostiDown = new global::Gtk.EventBox();
		this.eventboxAktivnostiDown.Name = "eventboxAktivnostiDown";
		// Container child eventboxAktivnostiDown.Gtk.Container+ContainerChild
		this.hbox4 = new global::Gtk.HBox();
		this.hbox4.Name = "hbox4";
		this.hbox4.Spacing = 6;
		// Container child hbox4.Gtk.Box+BoxChild
		this.vbox6 = new global::Gtk.VBox();
		this.vbox6.Name = "vbox6";
		this.vbox6.Spacing = 6;
		// Container child vbox6.Gtk.Box+BoxChild
		this.buttonNovaAktivnost = new global::Gtk.Button();
		this.buttonNovaAktivnost.CanFocus = true;
		this.buttonNovaAktivnost.Name = "buttonNovaAktivnost";
		this.buttonNovaAktivnost.UseUnderline = true;
		this.buttonNovaAktivnost.Label = global::Mono.Unix.Catalog.GetString("Dodaj Novu Aktivnost");
		this.vbox6.Add(this.buttonNovaAktivnost);
		global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.buttonNovaAktivnost]));
		w43.Position = 0;
		w43.Expand = false;
		w43.Fill = false;
		this.hbox4.Add(this.vbox6);
		global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.vbox6]));
		w44.Position = 0;
		w44.Expand = false;
		w44.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.vbox7 = new global::Gtk.VBox();
		this.vbox7.Name = "vbox7";
		this.vbox7.Spacing = 6;
		// Container child vbox7.Gtk.Box+BoxChild
		this.buttonMijenjajAktivnost = new global::Gtk.Button();
		this.buttonMijenjajAktivnost.CanFocus = true;
		this.buttonMijenjajAktivnost.Name = "buttonMijenjajAktivnost";
		this.buttonMijenjajAktivnost.UseUnderline = true;
		this.buttonMijenjajAktivnost.Label = global::Mono.Unix.Catalog.GetString("Mijenjaj Aktivnost");
		this.vbox7.Add(this.buttonMijenjajAktivnost);
		global::Gtk.Box.BoxChild w45 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.buttonMijenjajAktivnost]));
		w45.Position = 0;
		w45.Expand = false;
		w45.Fill = false;
		this.hbox4.Add(this.vbox7);
		global::Gtk.Box.BoxChild w46 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.vbox7]));
		w46.Position = 1;
		w46.Expand = false;
		w46.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.vbox8 = new global::Gtk.VBox();
		this.vbox8.Name = "vbox8";
		this.vbox8.Spacing = 6;
		// Container child vbox8.Gtk.Box+BoxChild
		this.buttonObrisiAktivnost = new global::Gtk.Button();
		this.buttonObrisiAktivnost.CanFocus = true;
		this.buttonObrisiAktivnost.Name = "buttonObrisiAktivnost";
		this.buttonObrisiAktivnost.UseUnderline = true;
		this.buttonObrisiAktivnost.Label = global::Mono.Unix.Catalog.GetString("Obriši Aktivnost");
		this.vbox8.Add(this.buttonObrisiAktivnost);
		global::Gtk.Box.BoxChild w47 = ((global::Gtk.Box.BoxChild)(this.vbox8[this.buttonObrisiAktivnost]));
		w47.Position = 0;
		w47.Expand = false;
		w47.Fill = false;
		this.hbox4.Add(this.vbox8);
		global::Gtk.Box.BoxChild w48 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.vbox8]));
		w48.Position = 2;
		w48.Expand = false;
		w48.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.fixed3 = new global::Gtk.Fixed();
		this.fixed3.Name = "fixed3";
		this.fixed3.HasWindow = false;
		this.hbox4.Add(this.fixed3);
		global::Gtk.Box.BoxChild w49 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.fixed3]));
		w49.Position = 3;
		// Container child hbox4.Gtk.Box+BoxChild
		this.calendar = new global::Gtk.Calendar();
		this.calendar.CanFocus = true;
		this.calendar.Name = "calendar";
		this.calendar.DisplayOptions = ((global::Gtk.CalendarDisplayOptions)(35));
		this.hbox4.Add(this.calendar);
		global::Gtk.Box.BoxChild w50 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.calendar]));
		w50.Position = 4;
		w50.Expand = false;
		w50.Fill = false;
		this.eventboxAktivnostiDown.Add(this.hbox4);
		this.vbox4.Add(this.eventboxAktivnostiDown);
		global::Gtk.Box.BoxChild w52 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.eventboxAktivnostiDown]));
		w52.Position = 2;
		w52.Expand = false;
		w52.Fill = false;
		this.notebookGlavni.Add(this.vbox4);
		global::Gtk.Notebook.NotebookChild w53 = ((global::Gtk.Notebook.NotebookChild)(this.notebookGlavni[this.vbox4]));
		w53.Position = 2;
		// Notebook tab
		this.labelViewAktivnostiKorisnika = new global::Gtk.Label();
		this.labelViewAktivnostiKorisnika.Name = "labelViewAktivnostiKorisnika";
		this.labelViewAktivnostiKorisnika.LabelProp = global::Mono.Unix.Catalog.GetString("Aktivnosti Korisnika");
		this.notebookGlavni.SetTabLabel(this.vbox4, this.labelViewAktivnostiKorisnika);
		this.labelViewAktivnostiKorisnika.ShowAll();
		// Container child notebookGlavni.Gtk.Notebook+NotebookChild
		this.vbox5 = new global::Gtk.VBox();
		this.vbox5.Name = "vbox5";
		this.vbox5.Spacing = 6;
		// Container child vbox5.Gtk.Box+BoxChild
		this.eventboxTipUp = new global::Gtk.EventBox();
		this.eventboxTipUp.Name = "eventboxTipUp";
		// Container child eventboxTipUp.Gtk.Container+ContainerChild
		this.hbox7 = new global::Gtk.HBox();
		this.hbox7.Name = "hbox7";
		this.hbox7.Spacing = 6;
		// Container child hbox7.Gtk.Box+BoxChild
		this.entry5 = new global::Gtk.Entry();
		this.entry5.CanFocus = true;
		this.entry5.Name = "entry5";
		this.entry5.IsEditable = true;
		this.entry5.InvisibleChar = '●';
		this.hbox7.Add(this.entry5);
		global::Gtk.Box.BoxChild w54 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.entry5]));
		w54.Position = 0;
		// Container child hbox7.Gtk.Box+BoxChild
		this.button5 = new global::Gtk.Button();
		this.button5.CanFocus = true;
		this.button5.Name = "button5";
		this.button5.UseUnderline = true;
		this.button5.Label = global::Mono.Unix.Catalog.GetString("Pretraži");
		this.hbox7.Add(this.button5);
		global::Gtk.Box.BoxChild w55 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.button5]));
		w55.Position = 1;
		w55.Expand = false;
		w55.Fill = false;
		this.eventboxTipUp.Add(this.hbox7);
		this.vbox5.Add(this.eventboxTipUp);
		global::Gtk.Box.BoxChild w57 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.eventboxTipUp]));
		w57.Position = 0;
		w57.Expand = false;
		w57.Fill = false;
		// Container child vbox5.Gtk.Box+BoxChild
		this.GtkScrolledWindow2 = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow2.Name = "GtkScrolledWindow2";
		this.GtkScrolledWindow2.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow2.Gtk.Container+ContainerChild
		this.nodeviewTip = new global::Gtk.NodeView();
		this.nodeviewTip.CanFocus = true;
		this.nodeviewTip.Name = "nodeviewTip";
		this.GtkScrolledWindow2.Add(this.nodeviewTip);
		this.vbox5.Add(this.GtkScrolledWindow2);
		global::Gtk.Box.BoxChild w59 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.GtkScrolledWindow2]));
		w59.Position = 1;
		// Container child vbox5.Gtk.Box+BoxChild
		this.eventboxTipDown = new global::Gtk.EventBox();
		this.eventboxTipDown.Name = "eventboxTipDown";
		// Container child eventboxTipDown.Gtk.Container+ContainerChild
		this.hbox8 = new global::Gtk.HBox();
		this.hbox8.Name = "hbox8";
		this.hbox8.Spacing = 6;
		// Container child hbox8.Gtk.Box+BoxChild
		this.vbox12 = new global::Gtk.VBox();
		this.vbox12.Name = "vbox12";
		this.vbox12.Spacing = 6;
		// Container child vbox12.Gtk.Box+BoxChild
		this.buttonNoviTip = new global::Gtk.Button();
		this.buttonNoviTip.CanFocus = true;
		this.buttonNoviTip.Name = "buttonNoviTip";
		this.buttonNoviTip.UseUnderline = true;
		this.buttonNoviTip.Label = global::Mono.Unix.Catalog.GetString("Dodaj Novi Tip");
		this.vbox12.Add(this.buttonNoviTip);
		global::Gtk.Box.BoxChild w60 = ((global::Gtk.Box.BoxChild)(this.vbox12[this.buttonNoviTip]));
		w60.Position = 0;
		w60.Expand = false;
		w60.Fill = false;
		this.hbox8.Add(this.vbox12);
		global::Gtk.Box.BoxChild w61 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.vbox12]));
		w61.Position = 0;
		w61.Expand = false;
		w61.Fill = false;
		// Container child hbox8.Gtk.Box+BoxChild
		this.vbox13 = new global::Gtk.VBox();
		this.vbox13.Name = "vbox13";
		this.vbox13.Spacing = 6;
		// Container child vbox13.Gtk.Box+BoxChild
		this.buttonMijenjajTip = new global::Gtk.Button();
		this.buttonMijenjajTip.CanFocus = true;
		this.buttonMijenjajTip.Name = "buttonMijenjajTip";
		this.buttonMijenjajTip.UseUnderline = true;
		this.buttonMijenjajTip.Label = global::Mono.Unix.Catalog.GetString("Mijenjaj Tip");
		this.vbox13.Add(this.buttonMijenjajTip);
		global::Gtk.Box.BoxChild w62 = ((global::Gtk.Box.BoxChild)(this.vbox13[this.buttonMijenjajTip]));
		w62.Position = 0;
		w62.Expand = false;
		w62.Fill = false;
		this.hbox8.Add(this.vbox13);
		global::Gtk.Box.BoxChild w63 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.vbox13]));
		w63.Position = 1;
		w63.Expand = false;
		w63.Fill = false;
		// Container child hbox8.Gtk.Box+BoxChild
		this.vbox14 = new global::Gtk.VBox();
		this.vbox14.Name = "vbox14";
		this.vbox14.Spacing = 6;
		// Container child vbox14.Gtk.Box+BoxChild
		this.buttonObrisiTip = new global::Gtk.Button();
		this.buttonObrisiTip.CanFocus = true;
		this.buttonObrisiTip.Name = "buttonObrisiTip";
		this.buttonObrisiTip.UseUnderline = true;
		this.buttonObrisiTip.Label = global::Mono.Unix.Catalog.GetString("Obriši Tip");
		this.vbox14.Add(this.buttonObrisiTip);
		global::Gtk.Box.BoxChild w64 = ((global::Gtk.Box.BoxChild)(this.vbox14[this.buttonObrisiTip]));
		w64.Position = 0;
		w64.Expand = false;
		w64.Fill = false;
		this.hbox8.Add(this.vbox14);
		global::Gtk.Box.BoxChild w65 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.vbox14]));
		w65.Position = 2;
		w65.Expand = false;
		w65.Fill = false;
		this.eventboxTipDown.Add(this.hbox8);
		this.vbox5.Add(this.eventboxTipDown);
		global::Gtk.Box.BoxChild w67 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.eventboxTipDown]));
		w67.Position = 2;
		this.notebookGlavni.Add(this.vbox5);
		global::Gtk.Notebook.NotebookChild w68 = ((global::Gtk.Notebook.NotebookChild)(this.notebookGlavni[this.vbox5]));
		w68.Position = 3;
		// Notebook tab
		this.labelTipoviAktivnosti = new global::Gtk.Label();
		this.labelTipoviAktivnosti.Name = "labelTipoviAktivnosti";
		this.labelTipoviAktivnosti.LabelProp = global::Mono.Unix.Catalog.GetString("Tipovi Aktivnosti");
		this.notebookGlavni.SetTabLabel(this.vbox5, this.labelTipoviAktivnosti);
		this.labelTipoviAktivnosti.ShowAll();
		// Notebook tab
		global::Gtk.Label w69 = new global::Gtk.Label();
		w69.Visible = true;
		this.notebookGlavni.Add(w69);
		this.labelStatistika = new global::Gtk.Label();
		this.labelStatistika.Name = "labelStatistika";
		this.labelStatistika.LabelProp = global::Mono.Unix.Catalog.GetString("Statistika");
		this.notebookGlavni.SetTabLabel(w69, this.labelStatistika);
		this.labelStatistika.ShowAll();
		this.vbox2.Add(this.notebookGlavni);
		global::Gtk.Box.BoxChild w70 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.notebookGlavni]));
		w70.Position = 0;
		this.hbox1.Add(this.vbox2);
		global::Gtk.Box.BoxChild w71 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox2]));
		w71.Position = 1;
		this.eventboxMain.Add(this.hbox1);
		this.Add(this.eventboxMain);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 1049;
		this.DefaultHeight = 578;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.buttonMenuKorisnici.Clicked += new global::System.EventHandler(this.ShowKorisnici);
		this.buttonMenuTipAktivnosti.Clicked += new global::System.EventHandler(this.ShowTipAktivnosti);
		this.buttonIzlaz.Clicked += new global::System.EventHandler(this.showQuestionIzlaz);
		this.buttonIzlaz1.Clicked += new global::System.EventHandler(this.showQuestionIzlaz);
		this.buttonIzlaz2.Clicked += new global::System.EventHandler(this.showQuestionIzlaz);
		this.buttonNoviKorisnik.Clicked += new global::System.EventHandler(this.dodajKorisnika);
		this.buttonMijenjajKorisnika.Clicked += new global::System.EventHandler(this.mijenjajKorisnika);
		this.buttonObrisiKorisnika.Clicked += new global::System.EventHandler(this.showQuestionKorisnik);
		this.buttonNovaAktivnost.Clicked += new global::System.EventHandler(this.dodajAktivnost);
		this.buttonMijenjajAktivnost.Clicked += new global::System.EventHandler(this.mijenjajAktivnost);
		this.buttonObrisiAktivnost.Clicked += new global::System.EventHandler(this.showQuestionAktivnost);
		this.buttonNoviTip.Clicked += new global::System.EventHandler(this.dodajTip);
		this.buttonMijenjajTip.Clicked += new global::System.EventHandler(this.mijenjajTip);
		this.buttonObrisiTip.Clicked += new global::System.EventHandler(this.showQuestionTip);
	}
}
