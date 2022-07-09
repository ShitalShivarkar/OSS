using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvFeatureDemoApp
{
    internal class Program
    {
        //Hello Topper
        
            static void Main(string[] args)
            {
                //C# 3.0 : 
                // annonymous Type
                // partial Class
                // extension method
                // LinQ

                //Annonymous Type
                // ti is a dynamic type

                var instance = new
                {
                    FirstName = "Shital",
                    LastName = "Shivarkar",
                    Age = 47,
                    Email = "shital123@gmail.com",
                    ContactNumber = "9898237896",
                    CompanyOwner =false
                };

                Console.WriteLine(instance.FirstName + " " + instance.LastName + " Owner=" + instance.CompanyOwner);
                Console.ReadLine();


            }
        }
    }

