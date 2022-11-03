using System.Collections.Generic;

namespace UnityTDDHelper
{
    public interface IClassRepresentation
    {
        string Name { get; }
        string ClassNamespace { get; }

        string Description { get; }

        IEnumerable<IFunctionRepresentation> Functions { get; }
        IEnumerable<IFieldRepresentation> Properties { get; }

    }
}