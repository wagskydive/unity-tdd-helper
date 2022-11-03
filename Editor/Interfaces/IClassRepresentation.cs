using System.Collections.Generic;
public interface IClassRepresentation
{
    string Name { get; }
    string Namespace { get; }
    
    string Description  { get; }

    IEnumerable<IFunctionRepresentation> Functions { get; }
    IEnumerable<IFieldRepresentation> Properties { get; }
    
}