using System;
using Gtk;

namespace ek
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow win = new MainWindow ();
			win.Title = "Form login with GTK#";
			win.Show ();
			Application.Run ();
		}
	}
}
