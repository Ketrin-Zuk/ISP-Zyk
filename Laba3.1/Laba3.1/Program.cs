using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SHAKF
{
    private string Naz { get; set; }
    private string Material { get; set; }
    private static int Number = 0;
    private int ID { get; set; }

    public SHAKF(string Nazz, string Materiall)
    {
        Number++;
        this.Naz = Nazz;
        Material = Materiall;
        ID = Number;
    }

    public string NAZ
    {
        get
        {
            return Naz;
        }
        set
        {
            Naz = value;
        }
    }

    public string MATERIAL
    {
        get
        {
            return Material;
        }
        set
        {
            Material = value;
        }
    }

    public string this[string propname]
    {
        get
        {
            switch (propname)
            {
                case "Название изделия: ": return Naz;
                case "Материал: ": return Material;
                default: return null;
            }
        }
        set
        {
            switch (propname)
            {
                case "Название изделия":
                    Naz = value;
                    break;
                case "Материал":
                    Material = value;
                    break;

            }
        }
    }

    public string Vivod()
    {
        string rez = "ID: " + ID + " Название изделия: \"" + Naz + "\" материал: " + Material;
        return rez;
    }

}

namespace Laba3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            SHAKF shkaf = new SHAKF("Шкаф", "Дуб");
            SHAKF shkaf1 = new SHAKF("Шкаф2", "Ель");
            Console.WriteLine(shkaf.Vivod());
            Console.WriteLine(shkaf1.Vivod());
            Console.WriteLine(shkaf.MATERIAL);

            shkaf.MATERIAL = "Берёза";
            shkaf1["Название изделия"] = "Ш-1";
            Console.WriteLine(shkaf.Vivod());
            Console.WriteLine(shkaf1.Vivod());
            Console.ReadKey();
        }
    }
}
