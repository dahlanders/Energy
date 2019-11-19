using System;
using System.Collections.Generic;
using System.Text;
using Energy.Domain;


namespace Energy.Domain
{
    public class CalculationOfAllRT 
    {
        public static void RWoodUMethod(List<MaterialAndThickness> materialwiththickness, Material material)
        {
            var rse = 0.04f;
            var rsi = 0.13f;
            var x = materialwiththickness;
            decimal sum = 0;
            
            foreach (var item in materialwiththickness)
            {



                if (item.Name == EnumForMaterial.luftspalt.ToString()|| item.Name == EnumForMaterial.luftspalt.ToString() || item.Name == EnumForMaterial.isolering.ToString())
                {
                    sum += 0;
                }
                else
                {
                    Console.WriteLine(item.Name + " " + item.Thickness + " " + item.UValue);
                    sum += item.Thickness / item.UValue;
                }

            }
            var xs = (Convert.ToDecimal(rse + rsi) + sum);
            Console.WriteLine("{0:F2}", xs);

        }
        public static void RTIsolering(List<MaterialAndThickness> materialwiththickness)
        {
            var rse = 0.04f;
            var rsi = 0.13f;
            var x = materialwiththickness;
            decimal sum = 0;
            foreach (var item in materialwiththickness)
            {



                if (item.Name == EnumForMaterial.luftspalt.ToString() || item.Name == EnumForMaterial.diffspärr.ToString() || item.Name == EnumForMaterial.trä.ToString())
                {
                    sum += 0;
                }
                else
                {
                    Console.WriteLine(item.Name + " " + item.Thickness + " " + item.UValue);
                    sum += item.Thickness / item.UValue;
                }

            }
            var xs = (Convert.ToDecimal(rse + rsi) + sum);
            Console.WriteLine("{0:F2}", xs);

        }
        public static void RTLamda(List<MaterialAndThickness> materialwiththickness)
        {
            var rse = 0.04f;
            var rsi = 0.13f;
            var x = materialwiththickness;
            decimal sum = 0;

            
            foreach (var item in materialwiththickness)
            {



                if (item.Name == EnumForMaterial.luftspalt.ToString() || item.Name == EnumForMaterial.diffspärr.ToString())
                {
                    sum += 0;
                }
                else if(item.Name == "trä" )
                {

                    sum += ((45 / 600) * item.UValue) + ((555 / 600) * item.UValue);
                }
                else
                {
                    Console.WriteLine(item.Name + " " + item.Thickness + " " + item.UValue);
                    sum += item.Thickness / item.UValue;
                }

            }
            var xs = (Convert.ToDecimal(rse + rsi) + sum);
            Console.WriteLine("{0:F2}", xs);

        }
    }
}
