using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PERSON
{
    public class PersonName
    {
        //Properties
        protected String Name;
        protected string FatherLastName;
        protected string MotherLastName;

        //Constructor
        
        public PersonName (string name, string fatherLastName, string motherLastName)
        {
            this.Name = name;
            this.FatherLastName = fatherLastName;
            this.MotherLastName = motherLastName;
        }

        //Method
        public override String ToString () //Full Name?
        {
            return "Name: "+ this.Name + " " + this.FatherLastName + " " + this.MotherLastName;
        }

    }
}
