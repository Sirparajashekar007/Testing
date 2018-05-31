using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class EmpDetails
    {
        EmpClass empClass = new EmpClass();
        public EmpDetails(int eId, string eName, string bGroup, long cNumber, string eAddress)
        {
           
            empClass.EmpId = eId;
            empClass.EmpName = eName;
            empClass.BloodGroup = bGroup;
            empClass.ContactNumber = cNumber;
            empClass.EmpAddress = eAddress;
        }
        public void EmpDetails1(bool TF)
        {
            Console.WriteLine("Empleyee Details {0} {1} {2} {3} " +empClass.EmpId, empClass.EmpName, empClass.BloodGroup, +empClass.ContactNumber, empClass.EmpAddress);
            Console.ReadLine();
        }
    }
}
