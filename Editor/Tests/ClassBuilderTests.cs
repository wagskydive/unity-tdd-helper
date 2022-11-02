using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class ClassBuilderTests
{

    [Test]
    public void ClassBuilderCreatesFileObject()
    {
        var classBuilder = new ClassBuilder();
        var file = classBuilder.CreateFile();
        Assert.That(file, Is.Not.Null);
    }


}
