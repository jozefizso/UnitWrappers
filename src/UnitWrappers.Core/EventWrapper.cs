using System;

namespace UnitWrappers
{
	
		
    public class EventWrapper<TOriginal, TWrapper,TEventArgs>
        where TOriginal : class
        where TWrapper : class
        where TEventArgs : EventArgs
    {
        private EventHandler<TEventArgs> _listeners;
        private readonly Func<TOriginal, TWrapper> _ctor;
        private readonly TOriginal _original;
        private readonly TWrapper _wrapper;

/// <summary>
/// 
/// </summary>
/// <param name="listener"></param>
/// <returns>True if no listeners remained, false if there are some listeners</returns>
        public bool Remove(EventHandler<TEventArgs> listener)
        {
            if (_listeners == null)
                return true;
            if (listener != null)
                _listeners -= listener;
            return _listeners == null;
        }

        public EventWrapper(Func<TOriginal, TWrapper> ctor, TOriginal original, TWrapper wrapper)
        {
            _ctor = ctor;
            _original = original;
            _wrapper = wrapper;
        }

        public void Raise(object sender, TEventArgs e)
        {
            var listeners = _listeners;
            if (listeners != null)
            {
                var original = sender as TOriginal;
                if (original != null)
                {
                    listeners(original == _original ? _wrapper : _ctor(original), e);
                }
                else
                {
                    listeners(sender, e);
                }
            }
        }

        public void Add(EventHandler<TEventArgs> listener)
        {
            _listeners += listener;
        }
    }

    public class EventWrapper<TOriginal, TWrapper>
        where TOriginal : class
        where TWrapper : class
    {
        private EventHandler _listeners;
        private readonly Func<TOriginal, TWrapper> _ctor;
        private readonly TOriginal _original;
        private readonly TWrapper _wrapper;

        public bool Remove(EventHandler listener)
        {
            if (_listeners == null)
                return true;
            if (listener != null)
                _listeners -= listener;
            return _listeners == null;
        }

        public EventWrapper(Func<TOriginal, TWrapper> ctor, TOriginal original, TWrapper wrapper)
        {
            _ctor = ctor;
            _original = original;
            _wrapper = wrapper;
        }

        public void Raise(object sender, EventArgs e)
        {
            var listeners = _listeners;
            if (listeners != null)
            {
                var original = sender as TOriginal;
                if (original != null)
                {
                    listeners(original == _original ? _wrapper : _ctor(original), e);
                }
                else
                {
                    listeners(sender, e);
                }
            }
        }

        public void Add(EventHandler listener)
        {
            _listeners += listener;
        }
    }
}