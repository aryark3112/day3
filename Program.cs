using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12july
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DataTypes
            //byte myByte=12;
            //sbyte mySByte=1;
            //short mySShort = 12;
            //int myInt=12;
            //long myLong = 12;
            //double myDouble = 12.5;
            //float myFloat = 12.5F;
            //decimal myDecimal = 12;
            //char myChar = 'A';
            //string myString = "Our String";
            //DateTime myDateTime = new DateTime(day: 12, month: 12, year: 2022);
            //bool mybool = false;

            try
            {
                byte ourByte;
                Console.WriteLine("Enter a Number");

                ourByte = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("Number is " + ourByte);
            }catch(FormatException ex)
            {
                Console.WriteLine("Format Exception" +ex.Message);
            }
            catch(OverflowException ex) 
            {
                Console.WriteLine("Overflow Exception" + ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error!!!" + ex.Message);
            }
            finally
            {
                Console.WriteLine("End of Program!!!");
                Console.ReadKey();
            }
            
        }
    }
}
