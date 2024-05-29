using Microsoft.Data.SqlClient;

using Dapper;
using Basic.Models;
using System.Data;
namespace Basic
{
    public class DepartmentAll
    {
        public void GetDepartment()
        {
            /*string connectionString = "Data Source=172.16.18.15;Initial Catalog=EmployeeManagement;MultipleActiveResultSets=True;TrustServerCertificate=True;Uid=hbits-mihir;password=lwC655E00lZh"; *///"DataSource=172.16.18.15;InitialCatlog=EmployeeManagement;Integrated Security=True;MultipleActiveResultSets=True;";
            using (var connection = new SqlConnection("connectionString"))
            using (var SqlCommand = new SqlCommand())  
            {
                connection.Open();
                var data12 = connection.QueryFirstOrDefault<Department>("usp_GetDepartments", commandType: CommandType.StoredProcedure);
                //SqlCommand = new SqlCommand("GetDepartments",connection);
                //SqlCommand.CommandType= System.Data.CommandType.StoredProcedure;
                //string query = "SELECT * FROM tblDepartments";
                //IEnumerable<Department> users = connection.Query<Department>(query).ToList();
                //var data11 = connection.QueryAsync<Department>(query);
            }
        }
    }
}
