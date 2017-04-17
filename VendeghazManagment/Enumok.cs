using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VendeghazManagment
{
    
    public enum SzobaEmelet
    {
        Szuterén,
        Földszint,
        [Description("Első emelet")]
        Első_emelet,
        [Description("Második emelet")]
        Második_emelet,
        Tetőtér
    }

    public enum VendegNem
    {
        Férfi,
        Nő
    }

    public enum VendegOkmanyTipus
    {
        Személyi,
        Útlevél
    }


    public enum IgenNem
    {
        Nem,
        Igen
    }
    static class Enumok
    {
        public static string Bovebben(this Enum value)
        {
            Type type = value.GetType();
            string name = Enum.GetName(type, value);
            if (name != null)
            {
                FieldInfo field = type.GetField(name);
                if (field != null)
                {
                    DescriptionAttribute attr =
                        Attribute.GetCustomAttribute(field,
                            typeof(DescriptionAttribute)) as DescriptionAttribute;
                    if (attr != null)
                    {
                        return attr.Description;
                    }
                }
                return name;
            }
            return null;
        }
    }
}
