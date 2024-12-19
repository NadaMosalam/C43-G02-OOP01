using System;
using System.Security;
namespace Demo
{
    #region  Part 15 Enum - Example 01
    class person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public Gender Gender { get; set; }
    }

    enum Branch : byte
    {
        Dokki = 200, Maadi, NasrCity, Alex = 253, BNs, SmarTVillage
    }
    enum Grade : byte
    {
        A, B, C, D, E, F  //Labels
    }
    enum Gender
    {
        Male = 1, Female = 2   //Labels
    }

    [Flags] //Attribute
    enum permissiom : byte
    {
        Read = 1, Write = 2, Delete = 4, Update = 8, 
        Execute = 16
    }
    #endregion
    class Program
    {
        static void Main()
        {
            #region Part 10 Access Modifiers for Namespace Members (file, internal, public)
            // TypeA TypeA =new TypeA();
            #endregion

            #region Part 11 Access Modifiers (private, internal, public)
            //TypeA.X=10; //Invailed Because "Private member"
            #endregion

            #region Part 13 Access Modifiers (private protected, protected, internal protected) EX02

            //TypeA obj = new TypeA();
            ////obj.x=1; "x is private"
            ////obj.y=2; "y is private"
            //obj.z = 4; //"z is internal"
            #endregion

            #region Part 15 Enum - casting from int to enum - Example 01

            //Gender MyGender = Gender.Female;
            //Console.WriteLine(mygender);

            //Grade MyGrade =Grade.A;
            //if (MyGrade == Grade.A)
            //    Console.WriteLine(":)");
            //else
            //    Console.WriteLine(":(");

            //Grade MyGrade = Grade.A;
            //MyGrade = (Grade)3; //casting from int to enum
            //MyGrade = (Grade)10;
            //MyGrade = (Grade)255;
            //Console.WriteLine(MyGrade);



            #endregion

            #region Part 16 Enum - casting from string to enum - Casting

            //using parse:
            //Gender MyGender;
            //MyGender =/*UnBoxing*/ (Gender)Enum.Parse(typeof(Gender),/*Boxing*/ "Male", true);  //Non generic  
            //MyGender = Enum.Parse<Gender>("Male", true);                  //generic
            //Console.WriteLine(MyGender);

            //using try parse:
            //Gender MyGender;
            //Enum.TryParse(typeof(Gender), "Male", true, out object? result/*Boxing*/);  //Non generic 
            //MyGender =(Gender) /*UnBoxing*/(result?? Gender.Male);

            //Enum.TryParse<Gender>("Male", true, out MyGender);                  //generic
            //Console.WriteLine(MyGender);
            #endregion

            #region Part 17 Enum - Example 02 (Permissions)

            //permissiom Mypermissioms = permissiom.Read;
            //Mypermissioms = (permissiom)255;
            //Console.WriteLine(Mypermissioms); 
            #endregion

            #region Part 18 Enum - Example 03 [Permissions] [Continued]

            ////permissiom MyP = (permissiom)14;
            ////MyP |= permissiom.Execute;
            ////MyP &= ~(permissiom.Write);
            ////MyP ^= permissiom.Update;
            ////MyP ^= permissiom.Update;
            ////Console.WriteLine(MyP);
            #endregion
        }
    }
}
