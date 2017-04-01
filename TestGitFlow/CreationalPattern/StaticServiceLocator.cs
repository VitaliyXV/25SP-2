using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern
{
    public static class StaticServiceLocator
    {
        private static Dictionary<Type, object> services = new Dictionary<Type,object>();
        public static void Registrate(Type type, object obj)
        {
            services.Add(type, obj);
        }

        public static T GetService<T>()
        {
            var service = services.FirstOrDefault(x => x.Key == typeof(T)).Value;
            return (T)service;
        }
    }
}
