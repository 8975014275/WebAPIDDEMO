using Microsoft.AspNetCore.Mvc;
using WebAPIDDEMO.Models;
using WebAPIDDEMO.Services;

namespace WebAPIDDEMO.Controllers
{
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _service;
        public CustomerController(ICustomerService service)
        {
            _service = service;
        }
        [HttpGet]
        [Route("GetAllCustomers")]
        public IActionResult GetAllCustomers()
        {
            try
            {
                return new ObjectResult(_service.GetAllCustomers());

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }
        [HttpGet]
        [Route("GetCustomerById/{id}")]
        public IActionResult GetCustomerById(int? id)
        {
            try
            {
                return new ObjectResult(_service.GetCustomerById(id));

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        [HttpPost]
        [Route("AddCustomer")]
        public IActionResult AddCustomer([FromBody] Customer cst)
        {
            try
            {
                int res = _service.AddCustomer(cst);
                if (res == 1)
                {
                    return StatusCode(StatusCodes.Status201Created);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }
        [HttpPost]
        [Route("UpdateCustomer")]
        public IActionResult UpdateCustomer([FromBody] Customer cst)
        {
            try
            {
                int res = _service.UpdateCustomer(cst);
                if (res == 1)
                {
                    return StatusCode(StatusCodes.Status200OK);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }
        [HttpGet]
        [Route("DeleteCustomer/{id}")]
        public IActionResult DeleteCustomer(int? id)
        {
            try
            {
                int res = _service.DeleteCustomer(id);
                if (res == 1)
                {
                    return StatusCode(StatusCodes.Status200OK);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        [HttpGet]
        [Route("GetAddresses")]
        public IActionResult GetAddresses()
        {
            try
            {
                return new ObjectResult(_service.GetAddresses());

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }
    }
}
