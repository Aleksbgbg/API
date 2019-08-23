namespace API.ProjectGeneration.Serialization
{
    using System.Text;

    public interface ISerializeable
    {
        StringBuilder Serialize(StringBuilder into);
    }
}