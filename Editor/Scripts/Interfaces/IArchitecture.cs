using System.Collections.Generic;


namespace UnityTDDHelper
{
    public interface IArchitecture
    {
        string ProjectName { get; }
        string Path { get; }
        string Remote { get; }
        string How { get; }
        IClassRepresentation[] Classes { get; }

    }
}