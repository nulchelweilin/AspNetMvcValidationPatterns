using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspNetMvcValidationPatterns.Models
{
    public class DateRangeViewModel : IValidatableObject
    {
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (EndDate <= StartDate)
            {
                yield return new ValidationResult(
                    "End Date must be after Start Date.",
                    new[] { nameof(EndDate) });
            }
        }
    }
}