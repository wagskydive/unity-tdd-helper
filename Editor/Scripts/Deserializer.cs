using System;
using System.IO;
using System.Collections.Generic;
using SimpleJSON;

namespace UnityTDDHelper
{
    public class Deserializer
    {
        internal static Architecture ArchitectureFromJSON(string filePath)
        {

            string architectureJsonString = File.ReadAllText(filePath);
            JSONObject architectureJson = JSONObject.Parse(architectureJsonString).AsObject;


            string projectName = architectureJson.GetValueOrDefault("Project Name",architectureJson);
            string description = architectureJson.GetValueOrDefault("Description",architectureJson);
            string projectPath = architectureJson.GetValueOrDefault("Project Path",architectureJson);
            // Path, Remote, How
            string remote = architectureJson.GetValueOrDefault("Remote",architectureJson);
            string how = architectureJson.GetValueOrDefault("How",architectureJson);

            ClassRepresentation[] classes = new ClassRepresentation[0];

            return new Architecture(projectName,description,projectPath,remote,how,classes);

            
        }

        //static ClassRepresentation ClassRepresentationFromJSON(string classRepresentationJsonString)
        //{

        //}
    }
}
