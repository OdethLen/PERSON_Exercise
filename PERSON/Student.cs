using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PERSON
{
    public class Student: Person
    {
        //Properties
        string Carrer;
        double Average;
        string Matricula;

        //Constructor 

        public Student(string carrer, double average,string matricula, DateTime bornDate, string name, string fatherLastName, string motherLastName): base (bornDate, name, fatherLastName, motherLastName) 
        {
            this.Carrer = carrer;
            this.Average = average;
            this.Matricula = matricula;
        }

        //Method

        public override string ToString()
        {
            return base.ToString() + " Carreer: " + Carrer +" Average:  "+ Average +" ID: "+ Matricula;
        }

        //public string PrintStudent()
        //{  
        //    return ""+ ToSting(); 
        //}
    }
}
