Console.WriteLine("FileSystemApp");
Directory.CreateDirectory("MyDirectory");
var filePath = Path.Combine("MyDirectory", "MyFile.txt");
File.WriteAllText(filePath, "MyContent");
for (int i = 1; i < 11; i++)
{
    Directory.CreateDirectory("My" + i.ToString());
}