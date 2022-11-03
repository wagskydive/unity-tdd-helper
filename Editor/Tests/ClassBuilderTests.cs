using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using System.IO;
using UnityTDDHelper;

public class ClassBuilderTests
{
    string fileName = "TestFile.cstemplate";

    string configPath = "Assets/unity-tdd-helper/architecture-config.yml";
    string keywordsPath = "Assets/unity-tdd-helper/template-keywords.yml";
    string fileTestContent = "TestContent";

    [Test]
    public void ClassBuilder_CreatesFile()
    {
        var classBuilder = new ClassBuilder(configPath, keywordsPath);
        classBuilder.CreateFile(fileName);

        Assert.That(File.Exists(classBuilder.Workfolder+fileName));
        File.Delete(classBuilder.Workfolder+fileName);
    }


    [Test]
    public void ClassBuilder_WritesIntoFile()
    {
        var classBuilder = new ClassBuilder(configPath, keywordsPath);
        classBuilder.CreateFile(fileName);
        classBuilder.WriteIntoFile(classBuilder.Workfolder+fileName,fileTestContent);


        
        Assert.That(File.ReadAllText(classBuilder.Workfolder+fileName).Contains(fileTestContent));
        File.Delete(classBuilder.Workfolder+fileName);
    }

    [Test]
    public void ClassBuilder_Reads__template_test_class_keyword__TEST_CLASS_NAME_FROM_ArchitectureConfigYML()
    {
        var classBuilder = new ClassBuilder(configPath,keywordsPath);


        string keyword = "TEST_CLASS_NAME";

        Assert.That(classBuilder.TemplateTestClassNameKeyWord == keyword);
    }




}
