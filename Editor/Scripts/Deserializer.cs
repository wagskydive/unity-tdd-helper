using System;
using System.IO;
using System.Collections.Generic;
using SimpleJSON;

namespace UnityTDDHelper
{

    public class Deserializer
    {
        static Dictionary<string, Type> typeLookup = new Dictionary<string, Type>
{
    { "bool",typeof(bool) },
    {"byte",typeof(byte)},
    {"char",typeof(char)},
    {"decimal",typeof(decimal)},
    {"double",typeof(double)},
    {"float",typeof(float)},
    {"int",typeof(int)},
    {"long",typeof(long)},
    {"object",typeof(object)},
    {"sbyte",typeof(sbyte)},
    {"short",typeof(short)},
    {"string",typeof(string)},
    {"uint",typeof(uint)},
    {"ulong",typeof(ulong)},
    {"void",typeof(void)}



};

        internal static Architecture ArchitectureFromJSON(string filePath)
        {

            string architectureJsonString = File.ReadAllText(filePath);
            JSONObject architectureJson = JSONObject.Parse(architectureJsonString).AsObject;


            string projectName = architectureJson.GetValueOrDefault("Project Name", architectureJson);
            string projectNamespace = architectureJson.GetValueOrDefault("Namespace", architectureJson);
            string description = architectureJson.GetValueOrDefault("Description", architectureJson);
            string projectPath = architectureJson.GetValueOrDefault("Project Path", architectureJson);
            // Path, Remote, How
            string remote = architectureJson.GetValueOrDefault("Remote", architectureJson);
            string how = architectureJson.GetValueOrDefault("How", architectureJson);


            JSONArray classesArray = architectureJson.GetValueOrDefault("Classes", architectureJson).AsArray;
            //Classes)

            ClassRepresentation[] classes = new ClassRepresentation[classesArray.Count];

            for (int i = 0; i < classesArray.Count; i++)
            {
                JSONObject classObject = classesArray[i].AsObject;
                ClassRepresentation classRepresentation = ClassRepresentationFromJSON(classObject);

                classes[i] = classRepresentation;
            }
            return new Architecture(projectName, projectNamespace, description, projectPath, remote, how, classes);


        }

        private static ClassRepresentation ClassRepresentationFromJSON(JSONObject classObject)
        {
            string className = classObject.GetValueOrDefault("Name", classObject);
            string classDescription = classObject.GetValueOrDefault("Description", classObject);
            //JSONArray functionsArray = classObject.GetValueOrDefault("Functions", classObject).AsArray;
            JSONArray propertiesArray = classObject.GetValueOrDefault("Properties", classObject).AsArray;

            //FunctionRepresentation functionRepresentation = new FunctionRepresentation();

            //FunctionRepresentation[] functions = new FunctionRepresentation[functionsArray.Count];



            FieldRepresentation[] properties = new FieldRepresentation[propertiesArray.Count];
            for (int i = 0; i < propertiesArray.Count; i++)
            {
                JSONObject propertyObject = propertiesArray[i].AsObject;
                string propertyName = propertyObject.GetValueOrDefault("Name", propertyObject);
                string propertyDescription = propertyObject.GetValueOrDefault("Description", propertyObject);
                string propertyTypeString = propertyObject.GetValueOrDefault("Type", propertyObject);

                Type propertyType = Type.GetType(propertyTypeString);

                if (propertyType == null)
                {
                    if(typeLookup.TryGetValue(propertyTypeString, out Type foundType))
                    {
                        propertyType = foundType;
                    }
                }

                FieldRepresentation property = new FieldRepresentation(propertyName, propertyDescription, propertyType);
                properties[i] = property;
            }



            ClassRepresentation classRepresentation = new ClassRepresentation(className, classDescription);
            return classRepresentation;
        }



        //static ClassRepresentation ClassRepresentationFromJSON(string classRepresentationJsonString)
        //{

        //}
    }
}
