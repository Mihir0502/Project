//using Basic.Models;
//using Dapper;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Data.SqlClient;
//using System.Collections.Generic;

//namespace Basic
//{
//    public class _employeeAll
//    {
//        public void GetEmployee()
//        {
//            //"DataSource=172.16.18.15;InitialCatlog=EmployeeManagement;Integrated Security=True;MultipleActiveResultSets=True;";
//            using (var connection = new SqlConnection("_connection"))
//            {
//                connection.Open();
//                string query = "SELECT Id, Name, Email, DepartmentId, Postion, Salary, HireDate, IDProofTypeId FROM tblEmployees";
//                IEnumerable<Employee> users = connection.Query<Employee>(query).ToList();
//                var data11 = connection.QueryAsync<Employee>(query);
//            }
//        }


//                //public void InsertEmployee(Employee emp)

//        //{
//        //    string connectionString = "Data Source=172.16.18.15;Initial Catalog=EmployeeManagement;MultipleActiveResultSets=True;Uid=hbits-mihir;password=lwC655E00lZh"; //"DataSource=172.16.18.15;InitialCatlog=EmployeeManagement;Integrated Security=True;MultipleActiveResultSets=True;";
//        //    using (var connection = new SqlConnection(connectionString))
//        //    {
//        //        connection.Open();
//        //        string qurey1 = "INSERT INTO tblEmployees VALUES(@Name, @Email, @DepartmentId, @Postion, @Salary, @HireDate, @IDProofTypeId)";
//        //        connection.Execute(qurey1, new
//        //        {
//        //            Name = emp.Name,
//        //            Email = emp.Email,
//        //            DepartmentId = emp.DepartmentId,
//        //            Postion = emp.Position,
//        //            Salary = emp.Salary,
//        //            HireDate = emp.HireDate,
//        //            IDProofTypeId = emp.IDProofTypeId
//        //        });
//        //    }

//        //}
//        //public Employee GetEmployeeById(int id)
//        //{
//        //    string connectionString = "Data Source=172.16.18.15;Initial Catalog=EmployeeManagement;MultipleActiveResultSets=True;Uid=hbits-mihir;password=lwC655E00lZh";
//        //    using (var connection = new SqlConnection(connectionString))
//        //    {
//        //        connection.Open();
//        //        string query = "SELECT Id, Name, Email, DepartmentId, Position, Salary, HireDate, IDProofTypeId FROM tblEmployees WHERE Id = @Id";
//        //        return connection.QueryFirstOrDefault<Employee>(query, new { Id = id });
//        //    }
//        //}
//    }
//}
