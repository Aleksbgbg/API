namespace API.ProjectGeneration.Models
{
    using API.ProjectGeneration.Attributes;

    public enum BuildEntryType
    {
        [AsString("ActiveCfg")]
        ActiveCfg,
        [AsString("Build.0")]
        Build0
    }
}