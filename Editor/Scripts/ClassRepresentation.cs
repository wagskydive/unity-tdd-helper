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

        IFunctionRepresentation[] functions;


        public IFunctionRepresentation[] Functions { get => functions; }

        public IFieldRepresentation[] properties;

        public IFieldRepresentation[] Properties { get => properties; }


        public ClassRepresentation(string name, string classNamespace, string description, IFunctionRepresentation[] Functions = null, IFieldRepresentation[] Properties= null)
        {
            this.name = name;
            this.classNamespace = classNamespace;
            this.description = description;
            this.functions = Functions;
            this.properties = Properties;
        }


    }
}