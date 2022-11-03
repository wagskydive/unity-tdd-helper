using System.Collections.Generic;

namespace UnityTDDHelper
{
    public interface IClassRepresentation
    {
        string Name { get; }
        string ClassNamespace { get; }

        string Description { get; }

        IFunctionRepresentation[] Functions { get; }
        IFieldRepresentation[] Properties { get; }

    }
}