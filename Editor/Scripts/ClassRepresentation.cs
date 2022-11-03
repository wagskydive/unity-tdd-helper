using System;
using System.Collections.Generic;

namespace UnityTDDHelper
{
    public class ClassRepresentation : IClassRepresentation
    {
        string name;
        public string Name { get => name; }

        string classNamespace;
        public string ClassNamespace { get => classNamespace; }

        string description;
        public string Description { get => description; }

        IEnumerable<IFunctionRepresentation> functions;


        public IEnumerable<IFunctionRepresentation> Functions { get => functions; }

        public IEnumerable<IFieldRepresentation> properties;

        public IEnumerable<IFieldRepresentation> Properties { get => properties; }


        public ClassRepresentation(string name, string classNamespace, string description, IEnumerable<IFunctionRepresentation> Functions = null, IEnumerable<IFieldRepresentation> Properties= null)
        {
            this.name = name;
            this.classNamespace = classNamespace;
            this.description = description;
            this.functions = Functions;
            this.properties = Properties;
        }


    }
}