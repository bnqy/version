using System.Diagnostics;


Trace.Listeners.Add(new TextWriterTraceListener(File.CreateText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "log.txt"))));

Trace.AutoFlush = true;

Debug.WriteLine("Debug, !");
Trace.WriteLine("Trace, !");