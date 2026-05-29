using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MVC_Assignment.CustomValidations;

namespace MVC_Assignment.CustomValidations
{
    public class NumericOnlyAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
                return false;

            return long.TryParse(value.ToString(), out _);
        }
    }
}