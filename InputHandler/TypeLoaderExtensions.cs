using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace InputHandler
{
    public static class TypeLoaderExtensions
    {
        public static IEnumerable<Type> GetLoadableTypes(this Assembly assembly)
        {
            if (assembly == null) throw new ArgumentNullException("assembly");
            try
            {
                return assembly.GetTypes();
            }
            catch (ReflectionTypeLoadException e)
            {
                return e.Types.Where(t => t != null);
            }
        }

        public static IEnumerable<Type> GetTypesWithInterface(Assembly asm, Type iType)
        {
            //var interfaceType = typeof(iType);
            return asm.GetLoadableTypes().Where(iType.IsAssignableFrom).Where(t => t != iType).ToList();
        }
    }

}