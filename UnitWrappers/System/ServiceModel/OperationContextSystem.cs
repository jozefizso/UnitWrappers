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
                return new OperationContextWrap(OperationContext.Current);
            }

            set
            {
                OperationContextWrap operationContextWrap = (OperationContextWrap)value;
                OperationContext.Current = operationContextWrap.UnderlyingObject;
            }
        }
    }
}
