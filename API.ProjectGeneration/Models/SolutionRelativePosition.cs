namespace API.ProjectGeneration.Models
{
    using API.ProjectGeneration.Attributes;

    public enum SolutionRelativePosition
    {
        [AsString("preSolution")]
        PreSolution,
        [AsString("postSolution")]
        PostSolution
    }
}