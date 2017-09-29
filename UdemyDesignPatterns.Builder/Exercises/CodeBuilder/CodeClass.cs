using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyDesignPatterns.Builder.Exercises.CodeBuilder
{
    public class CodeClass : Code
    {
        public string ClassName { get; set; }
        public string AccessModifier { get; set; }
        public List<CodeClassMember> Members { get; set; }
        
        public CodeClass()
        {
            AccessModifier = "public";
            Members = new List<CodeClassMember>();
        }


        public override string ToString()
        {
            return ToStringImpl(0);
        }

        private string ToStringImpl(int indent)
        {
            StringBuilder sb = new StringBuilder();

            var i = new string(' ', indentSize * indent);
            sb.AppendLine($"{i}{AccessModifier} class {ClassName}");
            sb.AppendLine($"{i}{{");

            foreach (var e in Members)
                sb.Append(e.ToStringImpl(indent + 1));

            sb.AppendLine($"{i}}}");

            return sb.ToString();
        }
    }
}
