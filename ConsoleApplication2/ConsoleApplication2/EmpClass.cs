using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class EmpClass
    {
        public int empId;
        public string empName;
        public string bloodGroup;
        public long contactNumber;
        public string empAddress;

        public int EmpId
        {
            get
            {
                return empId;
            }
            set
            {
                empId = value;
            }
        }

        public string EmpName
        {
            get
            {
                return empName;
            }
            set
            {
                empName = value;
            }
        }

        public string BloodGroup
        {
            get
            {
                return bloodGroup;
            }
            set
            {
                bloodGroup = value;
            }
        }

        public long ContactNumber
        {
            get
            {
                return contactNumber;
            }
            set
            {
                contactNumber = value;
            }
        }

        public string EmpAddress
        {
            get
            {
                return empAddress;
            }
            set
            {
                empAddress = value;
            }
        }
    }
}
