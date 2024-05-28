using Microsoft.Data.SqlClient;

using Dapper;
namespace Basic
{
    public class DepartmentAll
    {
        public void GetDepartment()
        {
            string connectionString = "Data Source=172.16.18.15;Initial Catalog=EmployeeManagement;MultipleActiveResultSets=True;TrustServerCertificate=True;Uid=hbits-mihir;password=lwC655E00lZh"; //"DataSource=172.16.18.15;InitialCatlog=EmployeeManagement;Integrated Security=True;MultipleActiveResultSets=True;";
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM tblDepartments";
                IEnumerable<Department> users = connection.Query<Department>(query).ToList();
                var data11 = connection.QueryAsync<Department>(query);
            }
        }
    }
}
