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
    public class CustomerAddressController : ControllerBase
    {

        private readonly IUnitOfWork UnitOfWork;
        private readonly IMapper mapper;

        public CustomerAddressController(IUnitOfWork UnitOfWork, IMapper mapper)
        {
            this.UnitOfWork = UnitOfWork;
            this.mapper = mapper;
        }

        [HttpGet]
        [Route("~/Api/GetCustomersAddress")]
        public IActionResult GetCustomersAddress()
        {

            try
            {
                var data = UnitOfWork.CustomerAddress.Get();
                var model = mapper.Map<IEnumerable<CustomerAddressVM>>(data);
                return Ok(model);

            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet]
        [Route("~/Api/GetCustomersAddressById/{id}")]
        public IActionResult GetCustomersAddressById(int id)
        {

            try
            {
                var data = UnitOfWork.CustomerAddress.GetById(id);
                var model = mapper.Map<CustomerAddressVM>(data);
                return Ok(model);

            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost]
        [Route("~/Api/AddCustomerAddress")]
        public IActionResult AddCustomerAddress(CustomerAddressVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = mapper.Map<CustomerAddresses>(model);
                    UnitOfWork.CustomerAddress.Create(data);
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
        [Route("~/Api/UpdateCustomerAddress")]
        public IActionResult UpdateCustomerAddress(CustomerAddressVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = mapper.Map<CustomerAddresses>(model);
                    UnitOfWork.CustomerAddress.Edit(data);
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
        [Route("~/Api/DeleteCustomerAddress")]
        public IActionResult DeleteCustomerAddress(CustomerAddressVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = mapper.Map<CustomerAddresses>(model);
                    UnitOfWork.CustomerAddress.Delete(data);
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
