using System;
public interface IFieldRepresentation
{
    string Name { get; }
    string Description { get;}
    Type FieldType { get; }
}