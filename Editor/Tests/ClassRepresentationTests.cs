using UnityTDDHelper;
using NUnit.Framework;

public class ClassRepresentationTests
{
    string testNameString = "test name";
    string testDescriptionString = "test description";


    [Test]
    public void Contains_Relevant_Data()
    {
        ClassRepresentation classRepresentation = new ClassRepresentation(testNameString,testDescriptionString);
    
        Assert.That(classRepresentation.Name == testNameString);

        Assert.That(classRepresentation.Description == testDescriptionString);
    }
}
