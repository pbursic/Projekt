using System;
namespace AppProject
{
	public partial class WindowDodajAktivnost : Gtk.Window
	{
		public WindowDodajAktivnost() :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();
		}
	}
}
