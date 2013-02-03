using System;
using System.ServiceModel;

namespace UnitWrappers.System.ServiceModel
{
    public class OperationContextSystem : IOperationContextSystem
    {
        public IOperationContext Current
        {
            get
            {
                if (OperationContext.Current == null)
                    return null;
                //TODO: thread local storage
                return new OperationContextWrap(OperationContext.Current);
            }

            set
            {
                OperationContext operationContext = (OperationContextWrap)value;
                OperationContext.Current = operationContext;
            }
        }
    }
}
