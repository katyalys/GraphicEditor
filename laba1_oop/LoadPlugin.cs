using laba1_OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace laba1_oop
{
    public class LoadPlugin
    {
        public static string PluginPath = "C:/Users/1/Downloads/course_work/laba1_oop/bin/Debug/Plugins/ClassLibrary2.dll";
        public static IPluginGeneral JsonLoad()
        {
            IPluginGeneral varJson;

            Assembly.LoadFile(PluginPath);
            Type interfaceType = typeof(IPluginGeneral);

            //Fetch all types that implement the interface IPlugin and are a class
            Type[] types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(a => a.GetTypes())
                .Where(p => interfaceType.IsAssignableFrom(p) && p.IsClass)
                .ToArray();

            return varJson = (IPluginGeneral)Activator.CreateInstance(types[0]);
        }
    }
}
