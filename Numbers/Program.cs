using static System.Console;

WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range { int.MinValue:N0} to {int.MaxValue:N0}.");
WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range { double.MinValue:N0} to {double.MaxValue:N0}.");
WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range { decimal.MinValue:N0} to {decimal.MaxValue:N0}.");

WriteLine();

WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue} to {int.MaxValue}.");
WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue} to {double.MaxValue}.");
WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue} to {decimal.MaxValue}.");

WriteLine();

WriteLine("Press any key in keyboard:");
ConsoleKeyInfo key = ReadKey();
WriteLine();
WriteLine("Key {0}, Char {1}, Modifiers {2}", key.Key, key.KeyChar, key.Modifiers);

ReadKey();


