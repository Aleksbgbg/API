namespace API.ProjectGeneration.Extensions
{
    using System;
    using System.Linq;

    using API.ProjectGeneration.Attributes;

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
            return enumValue.GetAttribute<AsStringAttribute>()
                            .StringRepresentation;
        }
    }
}