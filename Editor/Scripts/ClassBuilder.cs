using System;
using System.IO;
using UnityEngine;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;


namespace UnityTDDHelper
{
    public class ClassBuilder
    {
        public string Workfolder { get => "Assets/unity-tdd-helper/Resources/"; }

        Keywords keywords;
        public Keywords KeywordsInstance { get => keywords; }


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


        public Architecture ReadArchitecture(string architecturePath)
        {    
            return Deserializer.ArchitectureFromJSON(architecturePath);
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

        public void ReadTemplate(string templatePath)
        {
            // TODO: Create Template Type to construct the final files
        }
    }
}