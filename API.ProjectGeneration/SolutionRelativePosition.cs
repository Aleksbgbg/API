﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.ProjectGeneration
{
    public enum SolutionRelativePosition
    {
        [ToString("preSolution")]
        PreSolution,
        [ToString("postSolution")]
        PostSolution
    }
}