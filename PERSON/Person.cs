using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PERSON
{
    public class Person: PersonName
    {
        //Property
        DateTime BornDate;

        //Constructor
      public Person (DateTime bornDate, string name, string fatherLastName, string motherLastName) :base (name, fatherLastName, motherLastName)
        {
            this.BornDate = bornDate;
        }

        //Method
        public override string ToString()
        {
            return base.ToString() + "Born date: "+ BornDate;
        }

    }
}
