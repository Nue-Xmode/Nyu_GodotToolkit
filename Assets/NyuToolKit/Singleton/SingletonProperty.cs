using System;

namespace NyuToolKit.Singleton
{
    /// <summary>
    /// 单例工具类
    /// </summary>
    public class SingletonProperty<T> where T : class, ISingleton
    {
        private static T _mInstance;
        private static readonly object _mLock = new object();

        /// <summary>
        /// 获取单例
        /// </summary>
        public static T Instance
        {
            get
            {
                if (_mInstance == null)
                {
                    lock (_mLock)
                    {
                        _mInstance = (T)Activator.CreateInstance(typeof(T));
                    }
                }
                
                return _mInstance;
            }
        }
        
        /// <summary>
        /// 释放
        /// </summary>
        public static void Dispose()
        {
            _mInstance = null;
        }
    }
}