using System.Collections.Generic;
using FluentValidation.Results;

namespace CoreLayer.Extensions
{
    public class ValidationErrorDetails : ErrorDetails
    {
        public IEnumerable<ValidationFailure> ValidationErrors { get; set; }
    }
}