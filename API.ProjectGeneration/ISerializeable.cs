﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.ProjectGeneration
{
    public interface ISerializeable
    {
        StringBuilder Serialize(StringBuilder into);
    }
}