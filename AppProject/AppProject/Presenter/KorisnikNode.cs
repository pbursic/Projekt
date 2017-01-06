using System;
namespace AppProject
{
	public class KorisnikNode : Gtk.TreeNode
	{
		public Korisnik korisnik = null;

		public int id;
		public string datum_rodjenja;
		public int god;

		[Gtk.TreeNodeValue(Column = 0)]
		public String ime;

		[Gtk.TreeNodeValue(Column = 1)]
		public String prezime;

		[Gtk.TreeNodeValue(Column = 2)]
		public String dob;

		[Gtk.TreeNodeValue(Column = 3)]
		public String visina;

		[Gtk.TreeNodeValue(Column = 4)]
		public String tezina;

		public KorisnikNode(Korisnik k)
		{
			god = DateTime.Today.Year - k.Datum_rodjenja.Year;
			if (k.Datum_rodjenja > DateTime.Now.AddYears(-god)) god--;

			this.korisnik = k;
			this.id = k.Id;
			this.ime = k.Ime;
			this.prezime = k.Prezime;
			this.datum_rodjenja = k.Datum_rodjenja.ToString();
			this.dob = god.ToString();
			this.visina = k.Visina.ToString();
			this.tezina = k.Tezina.ToString();
		}
	}
}
