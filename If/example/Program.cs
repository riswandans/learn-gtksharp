using System;
using Gtk;

namespace example
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow win = new MainWindow ();
			int test;
			test = 1000;
			if (test > 900) {
				win.Title = "High";
			} else {
				win.Title = "Low";
			}
			win.Show ();
			Application.Run ();
		}
	}
}
