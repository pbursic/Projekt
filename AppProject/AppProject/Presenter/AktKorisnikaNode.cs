using System;
namespace AppProject
{
	public class AktKorisnikaNode : Gtk.TreeNode
	{
		public AktivnostKorisnika aktivnostiKorisnika = null;

		public int id,k_id,ta_id;

		[Gtk.TreeNodeValue(Column = 0)]
		public String naziv;

		[Gtk.TreeNodeValue(Column = 1)]
		public String tip;

		[Gtk.TreeNodeValue(Column = 2)]
		public String datum;

		[Gtk.TreeNodeValue(Column = 3)]
		public String vrijeme_pocetka;

		[Gtk.TreeNodeValue(Column = 4)]
		public String vrijeme_kraja;

		[Gtk.TreeNodeValue(Column = 5)]
		public String potrosnja;

		public AktKorisnikaNode(AktivnostKorisnika aktKorisnika)
		{
			this.aktivnostiKorisnika = aktKorisnika;
			this.id = aktKorisnika.Id;
			this.k_id = aktKorisnika.K_id;
			this.ta_id = aktKorisnika.Ta_id;
			this.naziv = aktKorisnika.Naziv;
			this.tip = aktKorisnika.Tip;
			this.datum = aktKorisnika.Datum.ToString("dd.MM.yyyy");
			this.vrijeme_pocetka = aktKorisnika.Vrijeme_pocetka.ToString("hh:mm:ss");
			this.vrijeme_kraja = aktKorisnika.Vrijeme_kraja.ToString("hh:mm:ss");
			this.potrosnja = aktKorisnika.Potrosnja.ToString();
		}
	}
}
