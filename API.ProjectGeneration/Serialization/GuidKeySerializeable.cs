namespace API.ProjectGeneration.Serialization
{
    using System;
    using System.Text;

    using API.ProjectGeneration.Extensions;

    public class GuidKeySerializeable : ISerializeable
    {
        private readonly string _key;
        private readonly Guid _value;

        public GuidKeySerializeable(string key, Guid value)
        {
            _key = key;
            _value = value;
        }

        public StringBuilder Serialize(StringBuilder into)
        {
            into.AppendFormat("{0} = {{{1}}}", _key, _value.ToUpper());
            return into;
        }
    }
}