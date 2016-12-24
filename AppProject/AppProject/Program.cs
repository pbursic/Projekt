using System;
using Gtk;

namespace AppProject
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Application.Init();
			MainWindow win = new MainWindow();
			win.Show();
			Baza.Db();
			Application.Run();
		}
	}
}
