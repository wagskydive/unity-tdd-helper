using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using System.IO;

public class ClassBuilderTests
{
    string fileName = "TestFile.cstemplate";

    string fileTestContent = "TestContent";

    [Test]
    public void ClassBuilder_CreatesFile()
    {
        var classBuilder = new ClassBuilder();
        classBuilder.CreateFile(fileName);

        Assert.That(File.Exists(classBuilder.Workfolder+fileName));
        File.Delete(classBuilder.Workfolder+fileName);
    }


    public void ClassBuilder_WritesIntoFile()
    {
        var classBuilder = new ClassBuilder();
        classBuilder.CreateFile(fileName);
        classBuilder.WriteIntoFile(classBuilder.Workfolder+fileName,fileTestContent);


        
        Assert.That(File.ReadAllText(classBuilder.Workfolder+fileName).Contains(fileTestContent));
        File.Delete(classBuilder.Workfolder+fileName);
    }



}
