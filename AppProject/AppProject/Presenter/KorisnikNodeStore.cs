using System;
using System.Collections.Generic;

namespace AppProject
{
	public class KorisnikNodeStore : Gtk.NodeStore
	{
		public KorisnikNodeStore() : base(typeof(KorisnikNode))
		{
		}

		public void Add(Korisnik k)
		{
			this.AddNode(new KorisnikNode(k));
		}

		public void Dodaj(List<Korisnik> korisnik)
		{
			foreach (var k in korisnik)
			{
				this.Add(k);
			}
		}
		public void Brisi(KorisnikNode korisnik)
		{
			this.RemoveNode(korisnik);
		}
	}
}
