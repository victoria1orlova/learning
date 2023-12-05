Console.WriteLine("FileSystemApp");

string mainDir = "MyDirectory";
Directory.CreateDirectory(mainDir);
var filePath = Path.Combine(mainDir, "MyFile.txt");
File.WriteAllText(filePath, "MyContent");
for (int i = 1; i < 11; i++)
{
    string subDirPath = Path.Combine(mainDir,"My" + i.ToString());
    Directory.CreateDirectory(subDirPath);
}