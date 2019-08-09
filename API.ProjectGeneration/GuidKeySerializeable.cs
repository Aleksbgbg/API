using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.ProjectGeneration
{
    public class GuidKeySerializeable : ISerializeable
    {
        private readonly string _key;
        private readonly Guid _value;

        public GuidKeySerializeable(string key, Guid value)
        {
            _key = key;
            _value = value;
        }

        public StringBuilder Serialize(StringBuilder @into)
        {
            into.AppendFormat("{0} = {{{1}}}", _key, _value.ToSolutionFormat());
            return into;
        }
    }
}
