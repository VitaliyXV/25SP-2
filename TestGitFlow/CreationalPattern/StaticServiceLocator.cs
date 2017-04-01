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
        public static void Registrate<T>(object obj)
        {
            services[typeof(T)] = obj;
        }

        public static T GetService<T>()
        {
            return (T)services[typeof(T)];
        }
    }
}
