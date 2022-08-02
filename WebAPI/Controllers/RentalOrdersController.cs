using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalOrdersController : ControllerBase
    {
        IRentalOrderService _rentalOrderService;

        public RentalOrdersController(IRentalOrderService rentalOrderService)
        {
            _rentalOrderService = rentalOrderService;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _rentalOrderService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("GetCarDetails")]
        public IActionResult GetCarDetails()
        {
            var result = _rentalOrderService.GetCarDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("Add")]
        public IActionResult Add(RentalOrder rentalOrder)
        {
            var result = _rentalOrderService.Add(rentalOrder);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("Delete")]
        public IActionResult Delete(RentalOrder rentalOrder)
        {
            var result = _rentalOrderService.Delete(rentalOrder);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("Update")]
        public IActionResult Update(RentalOrder rentalOrder)
        {
            var result = _rentalOrderService.Update(rentalOrder);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
