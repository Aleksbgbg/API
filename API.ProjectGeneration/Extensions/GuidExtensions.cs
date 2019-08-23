namespace API.ProjectGeneration.Extensions
{
    using System;

    public static class GuidExtensions
    {
        public static string ToUpper(this Guid guid)
        {
            return guid.ToString()
                       .ToUpper();
        }
    }
}