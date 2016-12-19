using System;
using Gtk;
using AppProject;

public partial class MainWindow : Gtk.Window
{
	KorisnikNodeStore korisnikPresenter;
	AktKorisnikaNodeStore aktKorisnikPresenter;
	TipAktivnostiNodeStore tipPresenter;

	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		Build();

		korisnikPresenter = new KorisnikNodeStore();
		aktKorisnikPresenter = new AktKorisnikaNodeStore();
		tipPresenter = new TipAktivnostiNodeStore();

		nodeviewKorisnici.NodeStore = korisnikPresenter;
		nodeviewAktivnostiKorisnika.NodeStore = aktKorisnikPresenter;
		nodeviewTip.NodeStore = tipPresenter;

		nodeviewKorisnici.AppendColumn("Ime", new Gtk.CellRendererText(), "text", 0);
		nodeviewKorisnici.AppendColumn("Prezime", new Gtk.CellRendererText(), "text", 1);
		nodeviewKorisnici.AppendColumn("Dob", new Gtk.CellRendererText(), "text", 2);
		nodeviewKorisnici.AppendColumn("Visina", new Gtk.CellRendererText(), "text", 3);
		nodeviewKorisnici.AppendColumn("Težina", new Gtk.CellRendererText(), "text", 4);

		nodeviewKorisnici.NodeSelection.Changed += this.RowSelected;

		nodeviewAktivnostiKorisnika.AppendColumn("Naziv", new Gtk.CellRendererText(), "text", 0);
		nodeviewAktivnostiKorisnika.AppendColumn("Datum", new Gtk.CellRendererText(), "text", 1);
		nodeviewAktivnostiKorisnika.AppendColumn("Vrijeme", new Gtk.CellRendererText(), "text", 2);
		nodeviewAktivnostiKorisnika.AppendColumn("Potrošnja", new Gtk.CellRendererText(), "text", 3);

		nodeviewTip.AppendColumn("Naziv", new Gtk.CellRendererText(), "text", 0);
		nodeviewTip.AppendColumn("Tip", new Gtk.CellRendererText(), "text", 1);
		nodeviewTip.AppendColumn("Jedinica", new Gtk.CellRendererText(), "text", 2);
	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a)
	{
		Application.Quit();
		a.RetVal = true;
	}

	protected void RowSelected(object o, EventArgs args)
	{
		var selectedKontakt = (KorisnikNode)nodeviewKorisnici.NodeSelection.SelectedNode;
		labelKorisnici.Text = selectedKontakt.ime + " " + selectedKontakt.prezime;

	}

	protected void dodajKorisnika(object sender, EventArgs e)
	{
		var dodajKorisnikaWin = new WindowDodajKorisnika();
	}
}
