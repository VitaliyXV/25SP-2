using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CreationalPattern
{

    /// <summary>
    /// Класс, сервис локатора выполненный синглтоном
    /// </summary>
    public class SingletonServiceLocator : IDisposable
    {
        #region VARIABLES
        private static SingletonServiceLocator _instance;

        private Dictionary<Type, object> _services;
        #endregion


        private SingletonServiceLocator()
        {
            _services = new Dictionary<Type, object>();
            _instance = this;
        }


        public static SingletonServiceLocator Instance()
        {
            if (_instance == null)
            {
                _instance = new SingletonServiceLocator();
            }
            return _instance;
        }

        #region SERVICE LOCATOR INTERFACE METHODS
        public void Add<T>(object service)
        {

            #region ASSERTS
            Assert.AreNotEqual(null, service, "service is null");
            #endregion

            if (service is T)
            {
                _services.Add(typeof(T), service);
            }
            else
            {
                throw new Exception(string.Format("service <{0}> have not implemented interface: {1} !",
                    service, typeof(T)));
            }
        }

        public void Remove<T>()
        {
            _services.Remove(typeof(T));
        }

        public T Get<T>()
        {
            try
            {
                return (T)_services[typeof(T)];
            }
            catch (KeyNotFoundException)
            {
                throw new Exception(string.Format("service <{0}> is not registered !",
                    typeof(T)));
            }
        }

        #endregion




        private void Clear()
        {
            _services.Clear();
        }




        public void Dispose()
        {
            Clear();
            _instance = null;
        }
    }
}
