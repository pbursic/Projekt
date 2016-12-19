using System;
namespace AppProject
{
	public class AktKorisnikaNode : Gtk.TreeNode
	{
		public AktivnostKorisnika aktivnostiKorisnika = null;

		[Gtk.TreeNodeValue(Column = 0)]
		public String naziv;

		[Gtk.TreeNodeValue(Column = 1)]
		public String datum;

		[Gtk.TreeNodeValue(Column = 2)]
		public String vrijeme;

		[Gtk.TreeNodeValue(Column = 3)]
		public String potrosnja;

		public AktKorisnikaNode(AktivnostKorisnika aktKorisnika)
		{
			this.aktivnostiKorisnika = aktKorisnika;
			this.naziv = aktKorisnika.Naziv;
			this.datum = aktKorisnika.Datum.ToString("dd.MM.yyyy");
			this.vrijeme = aktKorisnika.Vrijeme.ToString("hh:mm:ss");
			this.potrosnja = aktKorisnika.Potrosnja.ToString();
		}
	}
}
