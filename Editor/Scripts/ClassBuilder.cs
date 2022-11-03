using System;
using System.IO;
using UnityEngine;

namespace UnityTDDHelper
{
    public class ClassBuilder
    {
        public string Workfolder { get => "Assets/unity-tdd-helper/Resources/"; }



        Keywords keywords;
        public string TemplateTestClassNameKeyword { get => keywords.template_test_class_keyword; }



        public ClassBuilder(string configPath, string keywordsPath)
        {
            if (!File.Exists(configPath) || !File.Exists(keywordsPath))
            {
                throw new ArgumentException("Config or Keywords file not found");
            }
            else
            {
                ReadKeywords(keywordsPath);
            }
        }




        public object CreateFile(string fileName)
        {
            FileStream file = File.Create(Workfolder + fileName);
            file.Close();
            return file;
        }

        public void WriteIntoFile(string filePath, string content)
        {

            File.WriteAllText(filePath, content);

        }

        public void ReadKeywords(string keywordsPath)
        {
            keywords = Keywords.LoadKeywords(keywordsPath);
        }
    }
}