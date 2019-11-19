using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Energy.Data;
using Energy.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.SqlServer.Server;

namespace Energy.App
{
    public class Program
    {
        static void Main(string[] args)
        {
            var x = MaterialWithThickness();
            CalculationOfAllRT.RTLamda(x);
            Console.Read();
        }

        private static void AddMaterialWithLamdaValue()
        {
            var newMaterial = new Material();
            newMaterial.NameofTheMaterial = "melon";
            newMaterial.LamdaValue = Convert.ToDecimal(0.421);

            using (var context = new EnergyContext())
            {
                context.Materials.Add(newMaterial);
                context.SaveChanges();
            }
        }
        private static List<MaterialAndThickness> MaterialWithThickness()
        {
               

            var list = new List<MaterialAndThickness>();
            while (true)
            {
                Console.WriteLine("Ange Material");
                var userInputMaterial = Console.ReadLine();
                
                decimal userInputThicknessMaterial = 0;
                while (true)
                {
                    Console.WriteLine("Ange tjockleken på materialet");
                    userInputThicknessMaterial = decimal.Parse(Console.ReadLine());
                    if (userInputThicknessMaterial >= 1)
                    {
                        Console.WriteLine("Materialets tjocklek är för tjockt");
                        continue;
                    }
                    
                    break;
                }

                list.Add(new MaterialAndThickness()
                {
                    Name = userInputMaterial,
                    Thickness = userInputThicknessMaterial,
                    UValue = GetOneMaterial(userInputMaterial)
                    
                });



                Console.WriteLine(" Vill du ange ett material till? Yes or No");
                var UserGivesOneMoreMAterial = Console.ReadLine();
                if (UserGivesOneMoreMAterial == "No")
                {
                    break;
                }
            }
            
            return list;

        }
        public static void PrintaListan(List<MaterialAndThickness> MaterialWithThickness)
        {
            var x = MaterialWithThickness;
            decimal sum = 0;
            foreach (var item in MaterialWithThickness)
            {
                Console.WriteLine(item.Name + " "+ item.Thickness + " " +item.UValue);
                sum += item.Thickness * item.UValue;
            }
            Console.WriteLine(sum);
        }

        
        private static decimal GetOneMaterial(string materialname )
        {
            using (var context = new EnergyContext())
            {
                
                var materials = context.Materials.Where(name => name.NameofTheMaterial == materialname).FirstOrDefault();

                return materials.LamdaValue;            
            }
           
        }
        private static void RIsolationUMethod(List<MaterialAndThickness> materialwiththickness)
        {
            var x = materialwiththickness;
            decimal sum = 0;
            foreach (var item in materialwiththickness)
            {
                

                
                if (item.Name == "luftspalt" || item.Name == "diffspärr"|| item.Name == "trä")
                {
                    sum += 0;
                }
                else
                {
                    Console.WriteLine(item.Name + " " + item.Thickness + " " + item.UValue);
                    sum += item.Thickness / item.UValue;
                }
                
            }
            Console.WriteLine(sum);
        }
        
        


        private static Door GetAreaAndUvalueFromDoor()
        {
            var door = new Door();

            Console.WriteLine("Enter the area of the door");
            door.Area = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Uvalue of the door");
            door.TheDoorUvalue = Convert.ToDouble(Console.ReadLine());
            return door;
        }
    }
}
