using System;
namespace AppProject
{
	public partial class WindowDodajTip : Gtk.Window
	{
		public WindowDodajTip() :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();
		}
	}
}
