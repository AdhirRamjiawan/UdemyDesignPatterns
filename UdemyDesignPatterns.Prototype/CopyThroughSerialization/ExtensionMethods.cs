using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace UdemyDesignPatterns.Prototype.CopyThroughSerialization
{
    public static class ExtensionMethods
    {
        public static T DeepCopy<T>(this T self)
        {
            var stream = new MemoryStream();
            var binFormater = new BinaryFormatter();
            binFormater.Serialize(stream, self);
            stream.Seek(0, SeekOrigin.Begin);
            object copy = binFormater.Deserialize(stream);
            stream.Close(); // put stream in a using clause
            return (T) copy;
        }
    }
}
