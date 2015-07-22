using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitWrappers
{
	public class WrapBase<T>:IWrap<T>
	{
		public T UnderlyingObject { get; private set; }

		public WrapBase(T underlyingObject)
		{
			UnderlyingObject = underlyingObject;
		}

		public static implicit operator WrapBase<T>(T o)
		{
			return new WrapBase<T>(o);
		}

		public static implicit operator T(WrapBase<T> o)
		{
			return o.UnderlyingObject;
		}
	}
}
