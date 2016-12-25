using System;
namespace AppProject
{
	public partial class WindowMijenjajKorisnika : Gtk.Window
	{
		public WindowMijenjajKorisnika() :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();

			Gdk.Color colorLightBlue = new Gdk.Color();
			Gdk.Color.Parse("#3FB2F0", ref colorLightBlue);
			eventboxMijenjajKorisnika.ModifyBg(Gtk.StateType.Normal, colorLightBlue);
			Add(eventboxMijenjajKorisnika);
		}
	}
}
