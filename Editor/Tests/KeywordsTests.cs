using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using System.IO;
using UnityTDDHelper;

public class KeywordsTests
{

    string testingFolder = "Assets/unity-tdd-helper/";

    string testingKeywordsPath = "template-keywords.yml";


    /*
    Assumes that template-keywords-yml contains the following:

    --------------------------------
    # Template Keywords
    template_test_class_keyword: TEST_CLASS_NAME
    template_test_function_keyword: TEST_FUNCTION_NAME
    --------------------------------

    */

    [Test]
    public void KeywordsTests_Serializes_From_Template_template_keywords_yml()
    {

        Keywords keywords = Keywords.LoadKeywords(testingFolder+testingKeywordsPath);
        string classKeyword = "TEST_CLASS_NAME";
        string functionKeyword = "TEST_FUNCTION_NAME";



        Assert.That(keywords.template_test_class_keyword == classKeyword);
        Assert.That(keywords.template_test_function_keyword == functionKeyword);
    }
}