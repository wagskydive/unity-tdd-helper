using System;
using System.IO;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

internal class KeyWords
{

    public string template_test_class_keyword{get; private set;}

    public string template_test_function_keyword{get; private set;}

    public static KeyWords LoadKeyWords(string keywordsFilePath)
    {
        File.ReadAllText(keywordsFilePath);

        var input = new StringReader(File.ReadAllText(keywordsFilePath));

        var deserializer = new DeserializerBuilder()
            .WithNamingConvention(UnderscoredNamingConvention.Instance)
            .Build();

        return deserializer.Deserialize<KeyWords>(input);
    }

}