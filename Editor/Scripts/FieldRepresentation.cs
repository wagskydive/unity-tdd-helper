using System;

namespace UnityTDDHelper
{
    public class FieldRepresentation : IFieldRepresentation
    {

        string name;
        string description;

        Type fieldType;


        public FieldRepresentation(string name, string description, Type fieldType)
        {
            this.name = name;
            this.description = description;
            this.fieldType = fieldType;
        }

        public string Name {get => name;}

        public string Description{get => description;}

        public Type FieldType{get => fieldType;}
    }
}