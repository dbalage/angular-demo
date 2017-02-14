using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace HajoVerseny.Models
{
    public enum HajoTipus
    {
        [Display(Name = "Kalóz")]
        Kaloz,
        [Display(Name = "Optimist")]
        Optimist,
        [Display(Name = "Finn")]
        Finn,
        [Display(Name = "Kadett")]
        Kadett
    }

    public enum Nem
    {
        [Display(Name = "Férfi")]
        Ferfi,
        [Display(Name = "Nő")]
        No,
    }

    public static class EnumExtesions
    {
        public static string GetDisplayName(this Enum value)
        {
            Type enumType = value.GetType();
            var enumValue = Enum.GetName(enumType, value);
            MemberInfo member = enumType.GetMember(enumValue)[0];

            var attrs = member.GetCustomAttributes(typeof(DisplayAttribute), false);
            foreach (var attr in attrs)
            {
                return ((DisplayAttribute)attr).Name;
            }

            return value.ToString();
        }
    }
    
}