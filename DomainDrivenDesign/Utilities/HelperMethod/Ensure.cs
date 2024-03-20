using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DomainDrivenDesign.Utilities.HelperMethod
{
    public static class Ensure
    {
        public static void NotNullOrEmpty(
            this string? value, 
            [CallerArgumentExpression("value")] string? paramName = null) 
        {
        
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(paramName);
            }

        }


    }
}
