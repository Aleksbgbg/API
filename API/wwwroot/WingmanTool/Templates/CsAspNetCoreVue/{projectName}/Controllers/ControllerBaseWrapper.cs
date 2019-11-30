namespace {projectName}.Controllers
{
    using System.Collections.Generic;
    using System.Linq;

    using Microsoft.AspNetCore.Mvc;

    using {projectName}.Extensions;

    public class ControllerBaseWrapper : ControllerBase
    {
        private protected ActionResult ValidationFailed()
        {
            Dictionary<string, string[]> errorList = ModelState.ToDictionary(keyValuePair => keyValuePair.Key.ToCamelCase(),
                                                                             keyValuePair => keyValuePair.Value
                                                                                                         .Errors
                                                                                                         .Select(error => error.ErrorMessage)
                                                                                                         .ToArray());

            return BadRequest(errorList);
        }
    }
}