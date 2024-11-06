using Microsoft.AspNetCore.Mvc;
using ProyectArg.Services;
using ProyectoMejoramiento.Models;

namespace ProyectoMejoramiento.Controllers
{ 
    [ApiController]
    [Route("api/[controller]")]


    public class EmployeeController : Controller
    {
        public readonly EmployeeService _serviceemployee;

        public EmployeeController(EmployeeService employeeService)
        {
            _serviceemployee = employeeService;
        }

        [HttpPost("RegisterEmployee")]
        public IActionResult create( Employee employee)
        {
            try
            {
                _serviceemployee.create(employee);
                return Ok(new
                {
                    message = "Empleado Resgitrado exitosamente"   
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.ToString());
            }
        }
        [HttpGet("GetEmployees")]
        public ActionResult<IEnumerable<Employee>> list()
        {
            try
            {
                var employees = _serviceemployee.GetEmployees();
                return Ok(employees);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.ToString());
            }


        }
    }
}
