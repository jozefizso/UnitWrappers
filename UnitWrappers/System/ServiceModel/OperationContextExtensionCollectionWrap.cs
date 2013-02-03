using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace UnitWrappers.System.ServiceModel
{
    //TODO:Check that it works.
    public class OperationContextExtensionCollectionWrap : IExtensionCollection<IOperationContext>
    {
        public IExtensionCollection<OperationContext> UnderlyingObject { get; private set; }

        public OperationContextExtensionCollectionWrap(IExtensionCollection<OperationContext> underlyingObject)
        {
            UnderlyingObject = underlyingObject;
        }

        public IEnumerator<IExtension<IOperationContext>> GetEnumerator()
        {
            IEnumerable<IExtension<IOperationContext>> wrap = UnderlyingObject.Select(x => new OperationContextExtensionWrap(x) as IExtension<IOperationContext>);
            return wrap.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(IExtension<IOperationContext> item)
        {
            IWrap<IExtension<OperationContext>> wrap = (OperationContextExtensionWrap)item;
            UnderlyingObject.Add(wrap.UnderlyingObject);
        }

        public void Clear()
        {
            UnderlyingObject.Clear();
        }

        public bool Contains(IExtension<IOperationContext> item)
        {
            IWrap<IExtension<OperationContext>> wrap = (OperationContextExtensionWrap)item;
            return UnderlyingObject.Contains(wrap.UnderlyingObject);
        }

        public void CopyTo(IExtension<IOperationContext>[] array, int arrayIndex)
        {
            var underlyingObjects = array.Cast<IWrap<IExtension<OperationContext>>>().Select(x => x.UnderlyingObject).ToArray();
            UnderlyingObject.CopyTo(underlyingObjects, arrayIndex);
        }

        public bool Remove(IExtension<IOperationContext> item)
        {
            IWrap<IExtension<OperationContext>> wrap = (OperationContextExtensionWrap)item;
            return UnderlyingObject.Remove(wrap.UnderlyingObject);
        }

        public int Count
        {
            get { return UnderlyingObject.Count; }
        }

        public bool IsReadOnly
        {
            get { return UnderlyingObject.IsReadOnly; }
        }

        public E Find<E>()
        {
            if (typeof(E) == typeof(IExtension<OperationContext>))
            {
                throw new InvalidOperationException(string.Format("Use {0} instead.", typeof(IExtension<IOperationContext>)));
            }
            if (typeof(E) == typeof(IExtension<IOperationContext>))
            {
                IExtension<OperationContext> underlyingObject = UnderlyingObject.Find<E>() as IExtension<OperationContext>;
                IExtension<IOperationContext> wrap = new OperationContextExtensionWrap(underlyingObject);
                return (E)(wrap);
            }
            return UnderlyingObject.Find<E>();
        }

        public Collection<E> FindAll<E>()
        {
            if (typeof(E) == typeof(IExtension<OperationContext>))
            {
                throw new InvalidOperationException(string.Format("Use {0} instead.", typeof(IExtension<IOperationContext>)));
            }
            if (typeof(E) == typeof(IExtension<IOperationContext>))
            {
                Collection<IExtension<OperationContext>> underlyingObjects = UnderlyingObject.FindAll<E>() as Collection<IExtension<OperationContext>>;
                IList<E> wraps = underlyingObjects.Select(x => (E)(new OperationContextExtensionWrap(x) as IExtension<IOperationContext>)).ToList();
                Collection<E> wrapsToReturn = new Collection<E>(wraps);
                return wrapsToReturn;
            }
            return UnderlyingObject.FindAll<E>();
        }
    }
}
