using System;
using System.IO;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;


namespace UnityTDDHelper
{
    public class Keywords
    {

        public string template_test_class_keyword { get; private set; }

        public string template_test_function_keyword { get; private set; }

        public static Keywords LoadKeywords(string keywordsFilePath)
        {

            var input = new StringReader(File.ReadAllText(keywordsFilePath));

            var deserializer = new DeserializerBuilder()
                .WithNamingConvention(UnderscoredNamingConvention.Instance)
                .Build();

            return deserializer.Deserialize<Keywords>(input);
        }

    }
}