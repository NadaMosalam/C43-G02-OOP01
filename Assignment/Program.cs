

using System.Xml.Linq;
using Assignment.Helper;

namespace Assignment
{
    class Program
    {
        static void Main()
        {
            #region Question 1
            //1.Try all what we have learned in the lecture.

            //Access Modifiers:
            //1.Private.
            //2.Private Protected.
            //3.Protected.
            //4.Internal
            //5.Internal Protected
            //6.Public.
            //7.File.

            //TypeA.X = 10; //Invailed Because "Private member"
            //TypeA.Y = 15; //vailed 
            //TypeA.Z = 20; //vailed 
            #endregion

            #region Question 2
            //1.Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members.
            //Then, write a C# program that prints out all the days of the week using this enum.

            ///The first solution
            ///WeekDays WeekDays = (WeekDays)63;
            ///WeekDays |= WeekDays.Sunday;
            ///Console.WriteLine(WeekDays);

            ///Another solution
            ///foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            ///{
            ///    Console.WriteLine(day);
            ///}
            #endregion

            #region Question 3
            //2.Create an enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members.
            //Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season.
            //Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            //Console.WriteLine("Please Enter The Season Name (Spring, Summer, Autumn, Winter) : ");
            //String? SeasonName = Console.ReadLine();
            //if (Enum.TryParse(SeasonName, true, out Seas season))
            //{
            //    switch (season)
            //    {
            //        case Seas.Spring:
            //            Console.WriteLine("spring march to may");
            //            break;
            //        case Seas.Summer:
            //            Console.WriteLine("summer june to august");
            //            break;
            //        case Seas.Autumn:
            //            Console.WriteLine("autumn September to November");
            //            break;
            //        case Seas.Winter:
            //            Console.WriteLine("winter December to February");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid season.");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid SeasonName. Please Enter a Valid Season Name.");
            //}
            #endregion

            #region Question 4
            //3.Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            //⮚	Create Variable from previous Enum to Add and Remove Permission from variable,
            //check if specific Permission is existed inside variable

            //Permissions Mypermissioms = Permissions.Read;
            //Console.WriteLine(Mypermissioms);
            //Mypermissioms |= Permissions.Write;
            //Mypermissioms |= Permissions.Delete;
            //Mypermissioms |= Permissions.Execute;
            //Mypermissioms &= ~(Permissions.Execute);
            //Mypermissioms &= ~(Permissions.Delete);
            //Mypermissioms &= ~(Permissions.Write);
            //Console.WriteLine(Mypermissioms);

            /////Another solution
            //Permissions Mypermissioms = Permissions.Read;
            //Mypermissioms |= Permissions.Write;
            //Mypermissioms |= Permissions.Delete;
            //Console.WriteLine(Mypermissioms);
            //if ((Mypermissioms & Permissions.Read) == Permissions.Read)
            //{
            //    Console.WriteLine("Read permission exists.");
            //}

            //if ((Mypermissioms & Permissions.Execute) != Permissions.Execute)
            //{
            //    Console.WriteLine("Execute permission does not exist.");
            //}
            //Mypermissioms &= ~Permissions.Write;
            //Console.WriteLine(Mypermissioms);
            //Mypermissioms |= Permissions.Execute;
            //Console.WriteLine(Mypermissioms);
            #endregion

            #region Question 5
            //4.Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members.
            //Write a C# program that takes a color name as input from the user and displays
            //a message indicating whether the input color is a primary color or not.

            //Console.WriteLine("Please Enter The color (Red, Green, Blue,) : ");
            //String? Color = Console.ReadLine();
            //if (Enum.TryParse(Color, true, out Colors color))
            //{
            //    Console.WriteLine($"{color} is a primary color");
            //}
            //else
            //{
            //    Console.WriteLine($"{Color} is not a primary color.");
            //}
        }
        #endregion
    }

}


