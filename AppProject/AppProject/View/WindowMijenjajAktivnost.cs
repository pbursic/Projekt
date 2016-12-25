using System;
namespace AppProject
{
	public partial class WindowMijenjajAktivnost : Gtk.Window
	{
		public WindowMijenjajAktivnost() :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();

			Gdk.Color colorLightBlue = new Gdk.Color();
			Gdk.Color.Parse("#3FB2F0", ref colorLightBlue);
			eventboxMijenjajAktivnost.ModifyBg(Gtk.StateType.Normal, colorLightBlue);
			Add(eventboxMijenjajAktivnost);
		}
	}
}
