using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Owner.API.Data;
using Owner.API.Model;


namespace Owner.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : Controller
    {

        // GET
        [Route("All")]
        [HttpGet]
        public IActionResult GetOwners()
        {
            var ownersDatas = new OwnerData().GetAll();
            return Ok(ownersDatas);
        }
        //POST
        [Route("Create")]
        [HttpPost]
        [Consumes("application/json")]
        public IActionResult CreateOwner(OwnerModel owner)
        {
            if (owner.Description.ToLower().Contains("hack"))
                return BadRequest("You cannot add a description containing hack keyword"); 
            else
            {
                var ownersDatas = new OwnerData().GetAll();
                ownersDatas.Add(owner);
                return Ok(ownersDatas);
            }
        }
        //PUT
        [HttpPut("{id:int}")]
        public IActionResult UpdateOwner(int id,OwnerModel owner)
        {
            if (id != owner.Id)
            {
                return BadRequest("Owner id did not match.");
            }
            else if (owner.Description.ToLower().Contains("hack"))
            {
                return BadRequest("You cannot update a description containing hack keyword");
            }
            else
            {
                var ownersDatas = new OwnerData().GetAll();
                var ownerId = ownersDatas.FirstOrDefault(x => x.Id == id);
                ownerId.Name = owner.Name;
                ownerId.Surname = owner.Surname;
                ownerId.Description = owner.Description;
                ownerId.Date = owner.Date;
                ownerId.Type = owner.Type;
                return Ok(ownersDatas);
                
            }

        }

        //DELETE
        [HttpDelete("{id:int}")]
        public IActionResult DeleteOwner(int id)
        {
            var ownersDatas = new OwnerData().GetAll();
            var ownerId = ownersDatas.FirstOrDefault(x => x.Id == id);
            if (ownerId==null)
            {
                return NotFound("Owner's id did not found.");

            }
            else
            {
                ownersDatas.Remove(ownerId);
                return Ok("Owner deleted successfully.");
            }
        }
      

    }
}

