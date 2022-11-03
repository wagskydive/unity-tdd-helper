using System;
using System.Collections.Generic;

namespace UnityTDDHelper
{
    public class ClassRepresentation : IClassRepresentation
    {
        string name;
        public string Name { get => name; }

        string description;
        public string Description { get => description; }

        public IFieldRepresentation[] properties;

        public IFieldRepresentation[] Properties { get => properties; }



        IFunctionRepresentation[] functions;

        public IFunctionRepresentation[] Functions { get => functions; }


        public ClassRepresentation(string name, string description, IFunctionRepresentation[] Functions = null, IFieldRepresentation[] Properties = null)
        {
            this.name = name;
            this.description = description;
            this.functions = Functions;
            this.properties = Properties;
        }


    }
}