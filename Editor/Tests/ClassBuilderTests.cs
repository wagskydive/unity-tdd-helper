using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using System.IO;

public class ClassBuilderTests
{

    [Test]
    public void ClassBuilderCreatesFile()
    {
        var classBuilder = new ClassBuilder();
        string fileName = "TestFile.cstemplate";
        classBuilder.CreateFile(fileName);
        Assert.That(File.Exists(classBuilder.Workfolder+fileName));
        File.Delete(classBuilder.Workfolder+fileName);
    }



}
