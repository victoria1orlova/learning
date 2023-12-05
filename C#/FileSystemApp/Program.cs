// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Console.WriteLine("FileSystemApp");
Directory.CreateDirectory("MyDirectory");
var filePath = Path.Combine("MyDirectory", "MyFile.txt");
File.WriteAllText(filePath, "MyContent");