using System;
using System.Collections.Generic;
using System.Linq;

namespace IoCContainer
{
    class Container
    {
        Dictionary<Type, Func<object>> reg = new Dictionary<Type, Func<object>>();

        public void Binde<TInterface, TImpl>() where TImpl : TInterface
        {
            Console.WriteLine($"Registration of {typeof(TImpl).Name} as a {typeof(TInterface).Name}");
            reg.Add(typeof(TInterface), () => Get(typeof(TImpl)));
        }

        public object Get(Type type)
        {
            Console.WriteLine($"I'm trying to get {type.Name}");
            if (reg.TryGetValue(type, out Func<object> creator))
            {
                return creator();
            }
            return CreateInstance(type);
        }

        private object CreateInstance(Type type)
        {
            Console.WriteLine($"I'm trying to crete {type.Name}");
            var ctor = type.GetConstructors().Single();
            var parameterTypes = ctor.GetParameters().Select(p => p.ParameterType);
            var dependencies = parameterTypes.Select(t => Get(t)).ToArray();

            return Activator.CreateInstance(type, dependencies);
        }
    }
}
