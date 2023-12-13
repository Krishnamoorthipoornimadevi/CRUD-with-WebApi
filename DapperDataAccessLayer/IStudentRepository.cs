using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDataAccessLayer
{
    
        public interface IStudentDetailsRepository
        {
            public StudentDetails InsertSP(StudentDetails studentDetails);
            public StudentDetails UpdateSP(long id, StudentDetails studentDetails);
            public IEnumerable<StudentDetails> GetStudentDetailsSP();
            public void DeleteStudentDetailsSP(long id);
        }
    
}
