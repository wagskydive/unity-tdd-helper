using System.Collections.Generic;

namespace UnityTDDHelper
{
    public interface IFunctionRepresentation
    {
        string Name { get; }
        string ClassName { get; }
        IFieldRepresentation[] Parameters { get; }

        IFunctionLogic Logic { get; }

    }
}