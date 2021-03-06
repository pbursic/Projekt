﻿using System;
namespace AppProject
{
	public class TipAktivnostiNode : Gtk.TreeNode
	{
		public TipAktivnosti aktivnostiTip = null;

		public int id;

		[Gtk.TreeNodeValue(Column = 0)]
		public String naziv;

		[Gtk.TreeNodeValue(Column = 1)]
		public String tip;

		[Gtk.TreeNodeValue(Column = 2)]
		public String kalorijeJedinica;

		public TipAktivnostiNode(TipAktivnosti aktTip)
		{
			this.aktivnostiTip = aktTip;
			this.id = aktTip.Id;
			this.naziv = aktTip.Naziv;
			this.tip = aktTip.JedinicaMjere;
			this.kalorijeJedinica = aktTip.KcalPoJediniciMjere.ToString();
		}
	}
}
