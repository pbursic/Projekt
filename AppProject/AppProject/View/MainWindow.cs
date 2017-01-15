﻿using System;
using Gtk;
using AppProject;
using System.Collections.Generic;

public partial class MainWindow : Gtk.Window
{
	KorisnikNodeStore korisnikPresenter;
	AktKorisnikaNodeStore aktKorisnikPresenter;
	TipAktivnostiNodeStore tipPresenter;

	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		Build();

		Gdk.Color colorMain = new Gdk.Color();
		Gdk.Color.Parse("#031A26", ref colorMain);
		eventboxMain.ModifyBg(StateType.Normal, colorMain);
		Add(eventboxMain);

		Gdk.Color colorPage = new Gdk.Color();
		Gdk.Color.Parse("#14A4EF", ref colorPage);
		eventboxKorisniciUp.ModifyBg(StateType.Normal, colorPage);
		Add(eventboxKorisniciUp);
		eventboxKorisniciDown.ModifyBg(StateType.Normal, colorPage);
		Add(eventboxKorisniciDown);
		eventboxAktivnostiUp.ModifyBg(StateType.Normal, colorPage);
		Add(eventboxAktivnostiUp);
		eventboxAktivnostiDown.ModifyBg(StateType.Normal, colorPage);
		Add(eventboxAktivnostiDown);
		eventboxTipUp.ModifyBg(StateType.Normal, colorPage);
		Add(eventboxTipUp);
		eventboxTipDown.ModifyBg(StateType.Normal, colorPage);
		Add(eventboxTipDown);

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
		nodeviewAktivnostiKorisnika.AppendColumn("Tip", new Gtk.CellRendererText(), "text", 1);
		nodeviewAktivnostiKorisnika.AppendColumn("Datum", new Gtk.CellRendererText(), "text", 2);
		nodeviewAktivnostiKorisnika.AppendColumn("Vrijeme Početka", new Gtk.CellRendererText(), "text", 3);
		nodeviewAktivnostiKorisnika.AppendColumn("Vrijeme Kraja", new Gtk.CellRendererText(), "text", 4);
		nodeviewAktivnostiKorisnika.AppendColumn("Potrošnja", new Gtk.CellRendererText(), "text", 5);

		if (labelKorisnikId.Text != "")
		{
			aktKorisnikPresenter.Dodaj(Baza.DbUcitajAktivnostiKorisnika(Int32.Parse(labelKorisnikId.Text)));
		}
		nodeviewAktivnostiKorisnika.NodeSelection.Changed += this.RowSelected;

		nodeviewTip.AppendColumn("Naziv Tipa", new Gtk.CellRendererText(), "text", 0);
		nodeviewTip.AppendColumn("Tip", new Gtk.CellRendererText(), "text", 1);
		nodeviewTip.AppendColumn("Jedinica", new Gtk.CellRendererText(), "text", 2);

		tipPresenter.Dodaj(Baza.DbUcitajTipAktivnosti());
		nodeviewTip.NodeSelection.Changed += this.RowSelected;

		calendarAktivnosti.Date = DateTime.Today.Date;
	}

	//Postavljanje liste tipova (svi unešeni tipovi)
	public void PopuniTipove()
	{
		List<TipAktivnosti> listaTipova = new List<TipAktivnosti>();
		listaTipova = Baza.DbUcitajTipAktivnosti();
		comboboxTipovi.Clear();
		foreach (var x in listaTipova)
		{
			comboboxTipovi.AppendText(x.Naziv);
		}
	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a)
	{
		Application.Quit();
		a.RetVal = true;
	}

	protected void RowSelected(object o, EventArgs args)
	{
		var selectedKorisnik = (KorisnikNode)nodeviewKorisnici.NodeSelection.SelectedNode;
		var selectedTipAktivnosti = (TipAktivnostiNode)nodeviewTip.NodeSelection.SelectedNode;
		var selectedAktivnostKorisnika = (AktKorisnikaNode)nodeviewAktivnostiKorisnika.NodeSelection.SelectedNode;
	}

	protected void dodajKorisnika(object sender, EventArgs e)
	{
		var dodajKorisnikaWin = new WindowDodajKorisnika();
	}

	protected void dodajAktivnost(object sender, EventArgs e)
	{
		var dodajAktivnostWin = new WindowDodajAktivnost(Int32.Parse(labelKorisnikIdAkt.Text));
	}

	protected void dodajTip(object sender, EventArgs e)
	{
		var dodajTipWin = new WindowDodajTip();
	}

	protected void mijenjajKorisnika(object sender, EventArgs e)
	{
		var selectedNodeKorisnik = (KorisnikNode)nodeviewKorisnici.NodeSelection.SelectedNode;
		if (selectedNodeKorisnik != null)
		{
			var mijenjajKorisnikaWin = new WindowMijenjajKorisnika(selectedNodeKorisnik);
		}
	}

	protected void mijenjajAktivnost(object sender, EventArgs e)
	{
		var selectedAktivnostKorisnikaNode = (AktKorisnikaNode)nodeviewAktivnostiKorisnika.NodeSelection.SelectedNode;
		if (selectedAktivnostKorisnikaNode != null)
		{
			var mijenjajAktivnostWin = new WindowMijenjajAktivnost(selectedAktivnostKorisnikaNode);
		}
	}

	protected void mijenjajTip(object sender, EventArgs e)
	{
		var selectedNodeTipAktivnosti = (TipAktivnostiNode)nodeviewTip.NodeSelection.SelectedNode;
		if (selectedNodeTipAktivnosti != null)
		{
			var mijenjajTipWin = new WindowMijenjajTip(selectedNodeTipAktivnosti);
		}
	}

	protected void showQuestionKorisnik(object sender, EventArgs e)
	{
		var selectedNodeKorisnik = (KorisnikNode)nodeviewKorisnici.NodeSelection.SelectedNode;
		if (selectedNodeKorisnik != null)
		{
			Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Question, ButtonsType.None, "Jeste li sigurni da želite obrisati korisnika?");

			d.AddButton("Da", Gtk.ResponseType.Yes);
			d.AddButton("Ne", Gtk.ResponseType.No);

			var odgovor = (Gtk.ResponseType)d.Run();

			if (odgovor == ResponseType.Yes)
			{
				if (Baza.DbProvjeriIdKorisnika(selectedNodeKorisnik.id))
				{
					Baza.BrisiKorisnika(selectedNodeKorisnik.id);
					korisnikPresenter.Brisi(selectedNodeKorisnik);
				}
			}
			d.Destroy();
		}
	}

	protected void showQuestionAktivnost(object sender, EventArgs e)
	{
		var selectedNodeAktivnostKorisnika = (AktKorisnikaNode)nodeviewAktivnostiKorisnika.NodeSelection.SelectedNode;
		if (selectedNodeAktivnostKorisnika != null)
		{
			Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Question, ButtonsType.None, "Jeste li sigurni da želite obrisati aktivnost?");

			d.AddButton("Da", Gtk.ResponseType.Yes);
			d.AddButton("Ne", Gtk.ResponseType.No);

			var odgovor = (Gtk.ResponseType)d.Run();

			if (odgovor == ResponseType.Yes)
			{
				if (Baza.DbProvjeriIdAktivnostiKorisnika(selectedNodeAktivnostKorisnika.id))
				{
					Baza.BrisiAktivnostKorisnika(selectedNodeAktivnostKorisnika.id);
					aktKorisnikPresenter.Brisi(selectedNodeAktivnostKorisnika);
				}
			}
			d.Destroy();
		}
	}

	protected void showQuestionTip(object sender, EventArgs e)
	{
		var selectedNodeTipAktivnosti = (TipAktivnostiNode)nodeviewTip.NodeSelection.SelectedNode;
		if (selectedNodeTipAktivnosti != null)
		{
			Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Question, ButtonsType.None, "Jeste li sigurni da želite obrisati tip aktivnosti?");

			d.AddButton("Da", Gtk.ResponseType.Yes);
			d.AddButton("Ne", Gtk.ResponseType.No);

			var odgovor = (Gtk.ResponseType)d.Run();

			if (odgovor == ResponseType.Yes)
			{
				if (Baza.DbProvjeriIdTipaAktivnosti(selectedNodeTipAktivnosti.id))
				{
					Baza.BrisiTipAktivnosti(selectedNodeTipAktivnosti.id);
					tipPresenter.Brisi(selectedNodeTipAktivnosti);
				}
			}
			d.Destroy();
		}

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
		notebookMenu.CurrentPage = 1;
	}

	protected void UpdateLists(object sender, EventArgs e)
	{
		korisnikPresenter.Clear();
		korisnikPresenter.Dodaj(Baza.DbUcitajKorisnike());
		tipPresenter.Clear();
		tipPresenter.Dodaj(Baza.DbUcitajTipAktivnosti());
		if (labelKorisnikIdAkt.Text != "")
		{
			aktKorisnikPresenter.Clear();
			aktKorisnikPresenter.Dodaj(Baza.DbUcitajAktivnostiKorisnika(Int32.Parse(labelKorisnikIdAkt.Text)));	
		}
	}

	protected void MenuClicked(object sender, EventArgs e)
	{
		notebookMenu.CurrentPage = 0;
		notebookGlavni.CurrentPage = 0;
	}

	protected void AktivnostiKorisnika(object sender, EventArgs e)
	{
		var selectedKorisnik = (KorisnikNode)nodeviewKorisnici.NodeSelection.SelectedNode;
		if (selectedKorisnik != null)
		{
			string ime_korisnika = selectedKorisnik.ime + " " + selectedKorisnik.prezime;
			labelCurrentKorisnik.Text = ime_korisnika;
			labelKorisnikIdAkt.Text = selectedKorisnik.id.ToString();
			aktKorisnikPresenter.Dodaj(Baza.DbUcitajAktivnostiKorisnika(selectedKorisnik.ID));
			notebookMenu.CurrentPage = 3;
			notebookGlavni.CurrentPage = 2;
		}
	}

	protected void StatistikaClicked(object sender, EventArgs e)
	{
		var selectedKorisnik = (KorisnikNode)nodeviewKorisnici.NodeSelection.SelectedNode;
		if (selectedKorisnik != null)
		{
			string ime_korisnika = selectedKorisnik.ime + " " + selectedKorisnik.prezime;
			labelCurrentKorisnik1.Text = ime_korisnika;
			labelKorisnikId1.Text = selectedKorisnik.ID.ToString();
			notebookMenu.CurrentPage = 4;
			notebookGlavni.CurrentPage = 4;
		}
	}

	protected void StatistikaAktivnostClicked(object sender, EventArgs e)
	{
		if (labelKorisnikIdAkt.Text != "")
		{
			labelCurrentKorisnik1.Text = labelCurrentKorisnik.Text;
			labelKorisnikIdAkt1.Text = labelKorisnikId.Text;
			notebookMenu.CurrentPage = 4;
			notebookGlavni.CurrentPage = 4;
		}
	}

	protected void StatTipClicked(object sender, EventArgs e)
	{
		notebookGlavni.CurrentPage = 5;
		PopuniTipove();
	}

	protected void StatVrijemeClicked(object sender, EventArgs e)
	{
		notebookGlavni.CurrentPage = 6;
	}
}
