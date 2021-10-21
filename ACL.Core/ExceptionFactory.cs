using ACL.Globalization.Development;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACL.Core
{
    /// <summary>
    /// Provides fexception creation functions.
    /// </summary>
    public static class ExceptionFactory
    {
        /// <summary>
        /// Creates an ArgumentNullException with a translated message.
        /// </summary>
        /// <param name="obj">The null argument used to generate the exception message.</param>
#pragma warning disable IDE0060 // Remove unused parameter
        public static ArgumentNullException CreateArgumentNullException(object obj)
#pragma warning restore IDE0060 // Remove unused parameter
        {
            return new ArgumentNullException(DevTranslator.Current.TranslateFormat("ArgumentNullMessage", nameof(obj)));
        }
    }
}
