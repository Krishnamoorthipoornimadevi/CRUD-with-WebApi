using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

namespace DapperDataAccessLayer
{
    public class StudentDetailsRepository : IStudentDetailsRepository
    {

        public StudentDetails InsertSP(StudentDetails studentDetails)
        {
            try
            {
                var connectionstring = "Data source = DESKTOP-Q9V2K5P\\SQLEXPRESS;initial catalog = batch7; user id = sa; password=Anaiyaan@123;";
                var Con = new SqlConnection(connectionstring);
                Con.Open();
                var InsertQuery = $"exec StudentDetailsInsert '{ studentDetails.Name}','{ studentDetails.Emailid}','{ studentDetails.DateOfBirth}','{studentDetails.Address}','{studentDetails.MobileNumber}'";
                Con.Execute(InsertQuery);
                Con.Close();
            }
#pragma warning disable CS0168 // The variable 'sql' is declared but never used
            catch (SqlException sql)
#pragma warning restore CS0168 // The variable 'sql' is declared but never used
            {
                throw;
            }
#pragma warning disable CS0168 // The variable 'sql' is declared but never used
            catch (Exception sql)
#pragma warning restore CS0168 // The variable 'sql' is declared but never used
            {
                throw;

            }
            return studentDetails;
        }
        public StudentDetails UpdateSP(long id, StudentDetails studentDetails)
        {
            try
            {
                var connectionString = "Data source = DESKTOP-Q9V2K5P\\SQLEXPRESS;initial catalog = batch7; user id = sa; password=Anaiyaan@123;";

                var con = new SqlConnection(connectionString);
                con.Open();
                var UpdateQuery = $" exec StudentDetailsUpdate {id},'{studentDetails.Name}','{studentDetails.Emailid}','{studentDetails.DateOfBirth}','{studentDetails.Address}','{studentDetails.MobileNumber}'";
                var studs = con.QueryFirstOrDefault<StudentDetails>(UpdateQuery);
                con.Execute(UpdateQuery);
                Console.WriteLine(UpdateQuery);
                con.Close();
                return studentDetails;
            }
#pragma warning disable CS0168 // The variable 'sql' is declared but never used
            catch (SqlException sql)
#pragma warning restore CS0168 // The variable 'sql' is declared but never used
            {
                throw;
            }
#pragma warning disable CS0168 // The variable 'sql' is declared but never used
            catch (Exception sql)
#pragma warning restore CS0168 // The variable 'sql' is declared but never used
            {
                throw;
            }

        }
        public IEnumerable<StudentDetails> GetStudentDetailsSP()
        {
            try
            {
                var connectionString = "Data source = DESKTOP-Q9V2K5P\\SQLEXPRESS;initial catalog = batch7; user id = sa; password=Anaiyaan@123;";

                var con = new SqlConnection(connectionString);
                con.Open();
                var selectQuery = $"StudentDetailsRead";
                var StudentDetails = con.Query<StudentDetails>(selectQuery);
                con.Close();
                return StudentDetails.ToList();
            }
#pragma warning disable CS0168 // The variable 'sql' is declared but never used
            catch (SqlException sql)
#pragma warning restore CS0168 // The variable 'sql' is declared but never used
            {
                throw;
            }
#pragma warning disable CS0168 // The variable 'sql' is declared but never used
            catch (Exception sql)
#pragma warning restore CS0168 // The variable 'sql' is declared but never used
            {
                throw;
            }


        }
        public void DeleteStudentDetailsSP(long id)
        {
            try
            {
                var connectionString = "Data source = DESKTOP-Q9V2K5P\\SQLEXPRESS;initial catalog = batch7; user id = sa; password=Anaiyaan@123;";

                var con = new SqlConnection(connectionString);
                con.Open();
                var DeleteQuery = $"StudentDetailsDelete {id}";
                con.Execute(DeleteQuery);
                con.Close();
            }
#pragma warning disable CS0168 // The variable 'sql' is declared but never used
            catch (SqlException sql)
#pragma warning restore CS0168 // The variable 'sql' is declared but never used
            {
                throw;
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                throw;
            }
        }


    }



}


