using System;

namespace DapperDataAccessLayer
{
    public class StudentDetails
    {
         
        public long id { get; set; }
        public string Name { get; set; }
        public string Emailid { get; set; }

        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public long MobileNumber { get; set; }
    }
}

