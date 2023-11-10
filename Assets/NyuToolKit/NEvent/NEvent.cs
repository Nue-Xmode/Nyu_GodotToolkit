using System;

namespace NyuToolKit.NEvent
{
    public class NEvent<T> 
    {
        private event Action<T> _onEvent = e => { };

        public void Register(Action<T> onEvent) => _onEvent += onEvent;

        public void UnRegister(Action<T> onEvent) => _onEvent -= onEvent;

        public void Trigger(T t) => _onEvent?.Invoke(t);
    }
    
}

