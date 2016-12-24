using System;
namespace AppProject
{
	public class KorisnikNode : Gtk.TreeNode
	{
		public Korisnik korisnik = null;

		[Gtk.TreeNodeValue(Column = 0)]
		public String ime;

		[Gtk.TreeNodeValue(Column = 1)]
		public String prezime;

		[Gtk.TreeNodeValue(Column = 2)]
		public String datum_rodjenja;

		[Gtk.TreeNodeValue(Column = 3)]
		public String visina;

		[Gtk.TreeNodeValue(Column = 4)]
		public String tezina;

		public KorisnikNode(Korisnik k)
		{
			this.korisnik = k;
			this.ime = k.Ime;
			this.prezime = k.Prezime;
			this.datum_rodjenja = k.Datum_rodjenja.ToString("d");
			this.visina = k.Visina.ToString();
			this.tezina = k.Tezina.ToString();
		}
	}
}
