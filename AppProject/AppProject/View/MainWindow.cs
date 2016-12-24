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

		korisnikPresenter.Dodaj(Baza.DbUcitajKorisnike());

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

	protected void dodajAktivnost(object sender, EventArgs e)
	{
		var dodajAktivnostWin = new WindowDodajAktivnost();
	}

	protected void dodajTip(object sender, EventArgs e)
	{
		var dodajTipWin = new WindowDodajTip();
	}

	protected void mijenjajKorisnika(object sender, EventArgs e)
	{
		var mijenjajKorisnikaWin = new WindowMijenjajKorisnika();
	}

	protected void mijenjajAktivnost(object sender, EventArgs e)
	{
		var mijenjajAktivnostWin = new WindowMijenjajAktivnost();
	}

	protected void mijenjajTip(object sender, EventArgs e)
	{
		var mijenjajTipWin = new WindowMijenjajTip();
	}

	protected void showQuestionKorisnik(object sender, EventArgs e)
	{
		Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Question, ButtonsType.None, "Jeste li sigurni da želite obrisati korisnika?");

		d.AddButton("Da", Gtk.ResponseType.Yes);
		d.AddButton("Ne", Gtk.ResponseType.No);

		var odgovor = (Gtk.ResponseType)d.Run();
		d.Destroy();
	}

	protected void showQuestionAktivnost(object sender, EventArgs e)
	{
		Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Question, ButtonsType.None, "Jeste li sigurni da želite obrisati aktivnost?");

		d.AddButton("Da", Gtk.ResponseType.Yes);
		d.AddButton("Ne", Gtk.ResponseType.No);

		var odgovor = (Gtk.ResponseType)d.Run();
		d.Destroy();
	}

	protected void showQuestionTip(object sender, EventArgs e)
	{
		Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Question, ButtonsType.None, "Jeste li sigurni da želite obrisati tip aktivnosti?");

		d.AddButton("Da", Gtk.ResponseType.Yes);
		d.AddButton("Ne", Gtk.ResponseType.No);

		var odgovor = (Gtk.ResponseType)d.Run();
		d.Destroy();
	}

	protected void showQuestionIzlaz(object sender, EventArgs e)
	{
		Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Question, ButtonsType.None, "Jeste li sigurni da želite izaći iz programa?");

		d.AddButton("Da", Gtk.ResponseType.Yes);
		d.AddButton("Ne", Gtk.ResponseType.No);

		var odgovor = (Gtk.ResponseType)d.Run();
		d.Destroy();
		if (odgovor == ResponseType.Yes)
		{
			Application.Quit();
		}
	}

	protected void ShowKorisnici(object sender, EventArgs e)
	{
		notebookGlavni.CurrentPage = 1;
		notebookMenu.CurrentPage = 2;
	}

	protected void ShowTipAktivnosti(object sender, EventArgs e)
	{
		notebookGlavni.CurrentPage = 3;
	}
}
