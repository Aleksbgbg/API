namespace {projectName}.Extensions
{
    public static class StringExtensions
    {
        public static string ToCamelCase(this string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return name;
            }

            return string.Concat(name.Substring(0, 1).ToLowerInvariant(), name.Substring(1));
        }
    }
}