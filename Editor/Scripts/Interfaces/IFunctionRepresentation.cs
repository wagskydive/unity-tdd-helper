using System.Collections.Generic;
public interface IFunctionRepresentation
{
    string Name { get;}
    string ClassName { get; }
    IEnumerable<IFieldRepresentation> Parameters { get;}
    
    IFunctionLogic Logic { get; }

}