using System;
using System.Collections.Generic;

namespace AppProject
{
	public class AktKorisnikaNodeStore : Gtk.NodeStore
	{
		public AktKorisnikaNodeStore() : base(typeof(AktKorisnikaNode))
		{
		}

		public void Add(AktivnostKorisnika k)
		{
			this.AddNode(new AktKorisnikaNode(k));
		}

		public void Dodaj(List<AktivnostKorisnika> aktivnosti)
		{
			foreach (var a in aktivnosti)
			{
				this.Add(a);
			}
		}

		public void Brisi(AktKorisnikaNode aktKorisnika)
		{
			this.RemoveNode(aktKorisnika);
		}
	}
}
