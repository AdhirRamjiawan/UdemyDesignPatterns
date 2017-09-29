using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyDesignPatterns.Builder.Exercises.CodeBuilder
{
    public class CodeClassMember : Code
    {
        public String Name { get; set; }
        public String DataType { get; set; }
        public String AccessModifier { get; set; }

        public CodeClassMember()
        {
            AccessModifier = "public";
        }
        
        public string ToStringImpl(int indent)
        {
            StringBuilder sb = new StringBuilder();

            var i = new string(' ', indentSize * indent);
            sb.AppendLine($"{i}{AccessModifier} {DataType} {Name};");

            return sb.ToString();
        }
    }
}
