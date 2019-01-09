using System;
using System.Collections.Generic;
using System.Linq;

namespace IoCContainer
{
    public class Container
    {
        public readonly Dictionary<Type, Func<object>> reg = new Dictionary<Type, Func<object>>();

        public void Binde<TInterface, TImpl>() where TImpl : TInterface
        {
            reg.Add(typeof(TInterface), () => Get(typeof(TImpl)));
        }

        public void Binde<TInterface>(Func<TInterface> classGenerator)
        {
            reg.Add(typeof(TInterface), () => classGenerator());
        }

        public void BindeSingleton<TInterface>(TInterface instanse)
        {
            reg.Add(typeof(TInterface), () => instanse);
        }

        public void BindeSingleton<TInterface>(Func<TInterface> classGenerator)
        {
            var lazy = new Lazy<TInterface>(classGenerator);
            Binde(() => lazy.Value);
        }

        public object Get(Type type)
        {
            Func<object> creator;
            if (reg.TryGetValue(type, out creator))
            {
                return creator();
            }
            //if (!reg.TryGetValue(type, out creator) && !type.IsAbstract)
            //{
            //    return Activator.CreateInstance(type);
            //}
            else if (!type.IsAbstract)
            {
                return CreateInstance(type);
            }
            throw new InvalidOperationException($"No implementation for {type}");
        }

        private object CreateInstance(Type type)
        {
            var ctor = type.GetConstructors().Single();
            var parameterTypes = ctor.GetParameters().Select(p => p.ParameterType);
            var dependencies = parameterTypes.Select(t => Get(t)).ToArray();

            return Activator.CreateInstance(type, dependencies);
        }
    }
}
