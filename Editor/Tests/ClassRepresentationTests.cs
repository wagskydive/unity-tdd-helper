using UnityTDDHelper;
using NUnit.Framework;

public class ClassRepresentationTests
{
    string testNameString = "test name";
    string testNameSpace = "test name space";
    string testDescriptionString = "test description";


    [Test]
    public void Contains_Relevant_Data()
    {
        ClassRepresentation classRepresentation = new ClassRepresentation(testNameString,testNameSpace,testDescriptionString);
    
        Assert.That(classRepresentation.Name == testNameString);
        Assert.That(classRepresentation.ClassNamespace == testNameSpace);
        Assert.That(classRepresentation.Description == testDescriptionString);
    }
}
