using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace Basic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly string _connectionString;

        public EmployeeController()
        {
            _connectionString = "Data Source=172.16.18.15;Initial Catalog=EmployeeManagement;MultipleActiveResultSets=True;TrustServerCertificate=True;Uid=hbits-mihir;password=lwC655E00lZh";
        }

        [HttpGet("GetEmployee")]
        public IActionResult GetEmployee()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM tblEmployees";
                var employees = connection.Query<Employee>(query);
                return Ok(employees);
            }
        }

        [HttpPost]
        public IActionResult InsertEmployee(Employee emp)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "INSERT INTO tblEmployees (Name, Email, DepartmentId, Postion, Salary, HireDate, IDProofTypeId) " +
                                       "VALUES (@Name, @Email, @DepartmentId, @Postion, @Salary, @HireDate, @IDProofTypeId)";
                connection.Execute(query, emp);
            }
            return Ok("Inserted successfully.");
        }

        [HttpGet("{name}")]
        public IActionResult GetEmployeeById(string name)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT Id, Name, Email, DepartmentId, Postion, Salary, HireDate, IDProofTypeId FROM tblEmployees WHERE Id = @Id";
                var employee = connection.QueryFirstOrDefault<Employee>(query, new { Name=name });

                if (employee != null)
                {
                    return Ok(employee);
                }
                else
                {
                    return NotFound("Employee not found.");
                }
            }
        }
    }
}


    //[HttpGet]
    //public string GetEmployees()
    //{
    //    return "mihir";
    //}

    //[HttpGet("myemp")]
    //public string GetMyEmp(int i)
    //{
    //    return i.ToString();
    //}

    //[HttpGet("GetEmployee")]
    //public IActionResult GetEmployee(int id)
    //{
    //    if (id > 4)
    //    {
    //        return Ok(1);
    //    }

    //    else
    //    {
    //        return NotFound();
    //    }


    //}
    //[HttpPost]
    //public string Post(Employee employee)
    //{
    //    string a = employee.Name;
    //    return a;
    //}



    // return all data of employee
    //[HttpGet]
    //public async Task<IEnumerable<Employee>> GetEmployees()
    //{
    //    //var arar = await _employeeRepo.GetEmployees();
    //    //return Ok(arar);
    //    return await _employeeRepo.GetEmployees();

    //}



    // return data of employee that is specified by id

    //[HttpGet("{id:int}")]
    //    public async Task<IActionResult> GetEmployee(int Id)
    //    {
    //        var employee = await _employeeRepo.GetEmployeeById(Id);
    //        if (employee == null)
    //        {
    //            return NotFound();
    //        }
    //        return Ok(employee);
    //    }

    // add employee karega !!

    //[HttpPost]
    //public async Task<IActionResult> PostEmployee(Employee employee)
    //{
    //    if (employee == null)
    //    {
    //        return BadRequest();
    //    }
    //    await _employeeRepo.AddEmployee(employee);
    //    return Ok("added");

    //}

    // delete employee method

    //[HttpDelete("{id}")]
    //public async Task<IActionResult> DeleteEmployee(int id)
    //{
    //    var employee = _employeeRepo.GetEmployeeById(id);
    //    if (employee == null)
    //    {  return NotFound(); }

    //}




