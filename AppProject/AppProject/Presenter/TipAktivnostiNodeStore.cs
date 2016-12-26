using System;
using System.Collections.Generic;

namespace AppProject
{
	public class TipAktivnostiNodeStore : Gtk.NodeStore
	{
		public TipAktivnostiNodeStore() : base(typeof(TipAktivnostiNode))
		{
		}

		public void Add(TipAktivnosti t)
		{
			this.AddNode(new TipAktivnostiNode(t));
		}

		public void Dodaj(List<TipAktivnosti> tipovi)
		{
			foreach (var t in tipovi)
			{
				this.Add(t);
			}
		}
	}
}
