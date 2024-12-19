using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Common
{
    internal class TypeB /*:TypeA*/
    {
        #region Part 10 Access Modifiers for Namespace Members (file, internal, public)
        // TypeA TypeA = new TypeA();
        #endregion

        #region Part 11 Access Modifiers (private, internal, public)
        //public TypeB()
        //{
        //    //TypeA.X=10; //Invailed Because "Private member"
        //}
        #endregion

        #region Part 13 Access Modifiers (private protected, protected, internal protected) EX02

        //public void test()
        //{
        //    TypeA obj = new TypeA();
        //    //obj.x=1; "x is private"
        //    //obj.y=2; "y is private"
        //    obj.z = 4; //"z is internal"
        //}

        ///public TypeB()
        //{
        //    // h IS Not Inherited.
        //    // X IS Inherited as Private.
        //    // y IS Inherited as Private.
        //    // z IS Inherited as Private.
        //}
        #endregion
    }
}
