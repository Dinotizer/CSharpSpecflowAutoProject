using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheridanProject.Utilities
{
    public static class Extensions
    {
        public static bool IsDisplayed(this IWebElement element, By _googleTermsAccept)
        {
			bool result;
			try
			{
				result = element.Displayed;
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}
    }
}