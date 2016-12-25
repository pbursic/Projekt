using System;
namespace AppProject
{
	public partial class WindowMijenjajTip : Gtk.Window
	{
		public WindowMijenjajTip() :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();

			Gdk.Color colorLightBlue = new Gdk.Color();
			Gdk.Color.Parse("#3FB2F0", ref colorLightBlue);
			eventboxMijenjajTip.ModifyBg(Gtk.StateType.Normal, colorLightBlue);
			Add(eventboxMijenjajTip);
		}
	}
}
