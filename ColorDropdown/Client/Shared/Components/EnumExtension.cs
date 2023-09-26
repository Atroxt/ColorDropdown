using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text.RegularExpressions;

namespace ColorDropdown.Client.Shared.Components
{
    public static class EnumExtensions
    {
        /// <summary>
        /// Gets the display name.
        /// </summary>
        /// <param name="enumValue">The enum value.</param>
        /// <returns>Display Name Value</returns>
        public static string GetDisplayName(this Enum enumValue)
        {
            return enumValue.GetType()
                .GetMember(enumValue.ToString())
                .First()
                .GetCustomAttribute<DisplayAttribute>()?
                .GetName() ?? Regex.Replace(enumValue.ToString(), "(?<=[a-z])([A-Z])", " $1", RegexOptions.Compiled).Trim();
        }
    }
}
