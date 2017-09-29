using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyDesignPatterns.Builder.Exercises.CodeBuilder
{
    public class CodeBuilder
    {
        public CodeClass Class { get; set; }

        public CodeBuilder(string className)
        {
            Class = new CodeClass() { ClassName = className };
        }

        public CodeBuilder AddField(string fieldName, string fieldDataType)
        {
            Class.Members.Add(new CodeClassMember() { Name = fieldName, DataType = fieldDataType });
            return this;
        }

        public override string ToString()
        {
            return Class.ToString();
        }
    }
}
