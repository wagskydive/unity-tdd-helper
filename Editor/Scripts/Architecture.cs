using System.Collections.Generic;


namespace UnityTDDHelper
{
    public class Architecture : IArchitecture
    {
        private string projectName;
        private string description;
        private string projectPath;
        private string remote;
        private string how;

        private IClassRepresentation[] classes;
        public string ProjectName { get => projectName; }

        public string Description { get => description; }

        public string Path { get => projectPath; }

        public string Remote { get => remote; }

        public string How { get => how; }

        public IClassRepresentation[] Classes { get => classes; }

        public Architecture(string projectName, string description, string projectPath, string remote, string how, IClassRepresentation[] classes)
        {
            this.projectName = projectName;
            this.description = description;
            this.projectPath = projectPath;
            this.remote = remote;
            this.how = how;
            this.classes = classes;
        }

        public static Architecture Create(string filePath)
        {
            return Deserializer.ArchitectureFromJSON(filePath);
        }

    }
}