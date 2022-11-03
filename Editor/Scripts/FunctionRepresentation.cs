using System.Collections.Generic;

namespace UnityTDDHelper
{
    public class FunctionRepresentation : IFunctionRepresentation
    {
        string name;
        string className;

        IFieldRepresentation[] parameters;
        IFunctionLogic logic;

        public string Name { get => name; } 
        public string ClassName { get => className; }
        public IFieldRepresentation[] Parameters { get => parameters; }
        public IFunctionLogic Logic { get => logic; }





        // constructor
        public FunctionRepresentation(string name, string className,IFieldRepresentation[] parameters,IFunctionLogic logic)
        {
            this.name = name;
            this.className = className;
            this.parameters = parameters;
            this.logic = logic;
        }
    }
}