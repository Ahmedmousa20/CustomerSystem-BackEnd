using AutoMapper;
using CustomerSystem.BL.Interface;
using CustomerSystem.BL.Models;
using CustomerSystem.DAL.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSystem.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IUnitOfWork UnitOfWork;
        private readonly IMapper mapper;

        public CustomerController(IUnitOfWork UnitOfWork, IMapper mapper)
        {
            this.UnitOfWork = UnitOfWork;
            this.mapper = mapper;
        }

        [HttpGet]
        [Route("~/Api/GetCustomers")]
        public IActionResult GetCustomers()
        {

            try
            {
                var data = UnitOfWork.Customer.Get();
                var model = mapper.Map<IEnumerable<CustomerVM>>(data);
                return Ok(model);

            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet]
        [Route("~/Api/GetCustomerById/{id}")]
        public IActionResult GetCustomerById(int id)
        {
 
            try
            {
                var data = UnitOfWork.Customer.GetById(id);
                var model = mapper.Map<CustomerVM>(data);
                return Ok(model);

            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost]
        [Route("~/Api/AddCutomer")]
        public IActionResult AddCutomer(CustomerVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = mapper.Map<Customer>(model);
                    UnitOfWork.Customer.Create(data);
                    return Ok("success");
                }
                return Ok("Data Is Invalid");

            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPut]
        [Route("~/Api/UpdateCustomer")]
        public IActionResult UpdateCustomer(CustomerVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = mapper.Map<Customer>(model);
                    UnitOfWork.Customer.Edit(data);
                    return Ok("success");
                }
                return Ok("Data Is Invalid");

            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete]
        [Route("~/Api/DeleteCustomer")]
        public IActionResult DeleteCustomer(CustomerVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = mapper.Map<Customer>(model);
                    UnitOfWork.Customer.Delete(data);
                    return Ok();
                }
                return Ok("Data is InValid");

            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }






    }
}
