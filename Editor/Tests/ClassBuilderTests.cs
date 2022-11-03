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

    string architecturePath = "Assets/unity-tdd-helper/architecture-planned.json";
    string fileTestContent = "TestContent";


    Architecture CreateTestArchitecture()
    {
        return new ClassBuilder(configPath, keywordsPath).ReadArchitecture(architecturePath);

    }


    [Test]
    public void CreatesFile()
    {
        var classBuilder = new ClassBuilder(configPath, keywordsPath);
        classBuilder.CreateFile(fileName);

        Assert.That(File.Exists(classBuilder.Workfolder + fileName));
        File.Delete(classBuilder.Workfolder + fileName);
    }


    [Test]
    public void WritesIntoFile()
    {
        var classBuilder = new ClassBuilder(configPath, keywordsPath);
        classBuilder.CreateFile(fileName);
        classBuilder.WriteIntoFile(classBuilder.Workfolder + fileName, fileTestContent);



        Assert.That(File.ReadAllText(classBuilder.Workfolder + fileName).Contains(fileTestContent));
        File.Delete(classBuilder.Workfolder + fileName);
    }

    [Test]
    public void Reads_template_test_class_keyword_ArchitectureConfigYML()
    {
        var classBuilder = new ClassBuilder(configPath, keywordsPath);


        string keyword = "TEST_CLASS_NAME";

        Assert.That(classBuilder.Keywords.template_test_class_keyword == keyword);
    }

    [Test]
    public void Reads_template_class_cstemplate_File()
    {
        Assert.That(false);
    }

    [Test]
    public void Replaces_Keywords_As_Defined()
    {
        Assert.That(false);
    }

    [Test]
    public void Creates_Output_In_architecture_json()
    {
        Assert.That(false);
    }

    [Test]
    public void Creates_Architecture_Instance_With_Project_Name()
    {
        var classBuilder = new ClassBuilder(configPath, keywordsPath);
        Architecture architecture = classBuilder.ReadArchitecture(architecturePath);
        Assert.That(architecture.ProjectName == "project-name");
    }


    [Test]
    public void Creates_Architecture_Instance_With_All_Details()
    {
        var classBuilder = new ClassBuilder(configPath, keywordsPath);
        Architecture architecture = classBuilder.ReadArchitecture(architecturePath);

        Assert.That(architecture.ProjectName == "project-name");
        Assert.That(architecture.ProjectNamespace == "MyNamespace");
        Assert.That(architecture.Description == "This is my amazing project");
        Assert.That(architecture.Path == "/MY_UNITY_PROJECT/");
        Assert.That(architecture.Remote == "https://gitcloud.com/god/heaven-and-earth");
        Assert.That(architecture.How == "Description of the system in more detail, will be added to README.md");
    }

    [Test]
    public void Creates_Architecture_Instance_With_Class_Name_AndDescription()
    {

        Architecture architecture = CreateTestArchitecture();

        Assert.That(architecture.Classes[0].Name == "MyMainClass");
        Assert.That(architecture.Classes[0].Description == "My main class purpose");
    }

    [Test]
    public void Creates_Architecture_Instance_With_Class_With_Property()
    {
        Architecture architecture = CreateTestArchitecture();

        Assert.That(architecture.Classes[0].Properties[0].Name == "my private property name");
        Assert.That(architecture.Classes[0].Properties[0].FieldType == typeof(int));
        Assert.That(architecture.Classes[0].Properties[0].Description ==  "This is my private property description");

    }
}
