using System.Collections.Generic;

namespace UnityTDDHelper
{
    public interface IClassRepresentation
    {
        string Name { get; }
        string Description { get; }

        IFieldRepresentation[] Properties { get; }

        IFunctionRepresentation[] Functions { get; }


    }
}