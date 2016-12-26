using System;
using Gtk;

namespace AppProject
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Application.Init();
			Baza.Db();
			MainWindow win = new MainWindow();
			win.Show();
			Application.Run();
		}
	}
}
