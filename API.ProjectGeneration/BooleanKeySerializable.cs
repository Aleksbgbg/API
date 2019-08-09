using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.ProjectGeneration
{
    public class BooleanKeySerializable : ISerializeable
    {
        private readonly string _key;
        private readonly bool _value;

        public BooleanKeySerializable(string key, bool value)
        {
            _key = key;
            _value = value;
        }

        public StringBuilder Serialize(StringBuilder @into)
        {
            into.AppendFormat("{0} = {1}", _key, _value.ToString().ToUpper());
            return into;
        }
    }
}
