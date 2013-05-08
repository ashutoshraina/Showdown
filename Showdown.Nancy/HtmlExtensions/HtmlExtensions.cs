using System;
using System.Collections.Generic;
using System.Linq;
using Nancy.ViewEngines.Razor;

namespace Showdown.Nancy.HtmlExtensions
{
    public static class EnumUtil
        {
        public static IEnumerable<T> GetValues<T> ()
            {
            return Enum.GetValues ( typeof ( T ) ).Cast<T> ( );
            }
        }

    public static class HtmlExtensions
    {
        public static IHtmlString CheckBox<T> ( this HtmlHelpers<T> helper, string name, dynamic modelProperty )
            {
                string output;
                bool checkedState = false;

                if (!bool.TryParse ( modelProperty.ToString ( ), out checkedState ))
                    {
                    output = "<input name=\"" + name + "\" type=\"checkbox\" value=\"true\" />";
                    }
                else
                    {
                    if (checkedState)
                        output = "<input name=\"" + name + "\" type=\"checkbox\" value=\"true\" checked />";
                    else
                        output = "<input name=\"" + name + "\" type=\"checkbox\" value=\"true\" />";
                    }

              return new NonEncodedHtmlString ( output );
            
            }
    }
}