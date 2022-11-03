using System;
public interface IFieldRepresentation
{
    string Name { get; }
    Type ParameterType { get; }
}