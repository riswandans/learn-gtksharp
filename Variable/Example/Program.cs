using System;
using Gtk;

namespace Example
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow win = new MainWindow ();
			string title;
			title = "Your Title";
			win.Title = title;
			win.Show ();
			Application.Run ();
		}
	}
}
