using System;
using System.IO;

public class ClassBuilder
{
    public ClassBuilder()
    {

    }

    public string Workfolder { get => "Assets/unity-tdd-helper/Resources/";}

    public object CreateFile(string fileName)
    {
        FileStream file = File.Create(Workfolder+fileName);
        file.Close();
        return file;
    }
}