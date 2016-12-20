using System;
namespace AppProject
{
	public partial class WindowMijenjajKorisnika : Gtk.Window
	{
		public WindowMijenjajKorisnika() :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();
		}
	}
}
