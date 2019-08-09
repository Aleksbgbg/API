using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.ProjectGeneration
{
    public static class EnumExtensions
    {
        public static T GetAttribute<T>(this Enum enumValue)
        {
            return enumValue.GetType()
                            .GetMember(enumValue.ToString())
                            .Single()
                            .GetCustomAttributes(typeof(T), false)
                            .Cast<T>()
                            .Single();
        }

        public static string AsString(this Enum enumValue)
        {
            return enumValue.GetAttribute<ToStringAttribute>()
                            .StringRepresentation;
        }
    }
}
