using System.Collections.Generic;


namespace UnityTDDHelper
{
    public interface IProjectDetails
    {
        string ProjectName { get; }
        string Path { get; }
        string Remote { get; }
        string How { get; }
    }
}