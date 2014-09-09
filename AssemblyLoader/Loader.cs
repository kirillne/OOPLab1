using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Lab1;

namespace AssemblyLoader
{
    public static class Loader
    {
        public static Dictionary<String, Type> Load(String directoryName)
        {
            var directory = new DirectoryInfo(directoryName);
            return 
                directory.GetFiles("*.dll")
                    .Select(file => Assembly.LoadFile(file.FullName))
                    .Select(assembly => assembly.GetTypes().FirstOrDefault(x => x.IsSubclassOf(typeof (Shape))))
                    .Where(shapeType => shapeType != null)
                    .ToDictionary(shapeType => shapeType.Name);
        }
    }
}
