namespace API.ProjectGeneration.Serialization
{
    using System.Text;

    public class BooleanKeySerializable : ISerializeable
    {
        private readonly string _key;
        private readonly bool _value;

        public BooleanKeySerializable(string key, bool value)
        {
            _key = key;
            _value = value;
        }

        public StringBuilder Serialize(StringBuilder into)
        {
            into.AppendFormat("{0} = {1}", _key, _value.ToString().ToUpper());
            return into;
        }
    }
}