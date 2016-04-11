## Tutorial Show MessageBox

Add this code to your project "program.cs"

```
public class MessageBox 
	{ 
		public static void Show(Gtk.Window parent_window, DialogFlags flags, MessageType msgtype, ButtonsType btntype, string msg) 
		{ 
			MessageDialog md = new MessageDialog (parent_window, flags, msgtype, btntype, msg); 
			md.Run (); 
			md.Destroy(); 
		} 

		public static void Show(string msg) 
		{ 
			MessageDialog md = new MessageDialog (null, DialogFlags.Modal, MessageType.Other, ButtonsType.Ok, msg); 
			md.Run (); 
			md.Destroy(); 
		} 
	}	
```

After that, at main you call class MessageBox

Example
```
MessageBox.Show ("Hello World");
```

Example full code at main

```
class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow win = new MainWindow ();
			win.Show ();
			MessageBox.Show ("Hello World");
			Application.Run ();
		}
	}
```
