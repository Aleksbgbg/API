namespace {projectName}.Extensions
{
    using System;
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc.ModelBinding;

    public static class ModelStateDictionaryExtensions
    {
        public static void AddIdentityErrors(this ModelStateDictionary modelState, IdentityResult identityResult)
        {
            modelState.AddIdentityErrors(identityResult.Errors);
        }

        public static void AddIdentityErrors(this ModelStateDictionary modelState, IEnumerable<IdentityError> errors)
        {
            foreach (IdentityError error in errors)
            {
                string key;

                if (error.Description.Contains("user name", StringComparison.OrdinalIgnoreCase))
                {
                    key = "Username";
                }
                else if (error.Description.Contains("password", StringComparison.OrdinalIgnoreCase))
                {
                    key = "Password";
                }
                else
                {
                    key = string.Empty;
                }

                modelState.AddModelError(key, error.Description);
            }
        }
    }
}