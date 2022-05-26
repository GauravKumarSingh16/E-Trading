using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using E_TradingAPI.Models;

namespace E_TradingApiSprint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessOwnersController : ControllerBase
    {
        private readonly BusinessOwnerContext _context;

        public BusinessOwnersController(BusinessOwnerContext context)
        {
            _context = context;
        }

        // GET: api/BusinessOwners
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BusinessOwner>>> GetBusinessOwners()
        {
            return await _context.BusinessOwners.ToListAsync();
        }

        // GET: api/BusinessOwners/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BusinessOwner>> GetBusinessOwner(string id)
        {
            var businessOwner = await _context.BusinessOwners.FindAsync(id);

            if (businessOwner == null)
            {
                return NotFound();
            }

            return businessOwner;
        }

        // PUT: api/BusinessOwners/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBusinessOwner(string id, BusinessOwner businessOwner)
        {
            if (id != businessOwner.UserName)
            {
                return BadRequest();
            }

            _context.Entry(businessOwner).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BusinessOwnerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/BusinessOwners
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BusinessOwner>> PostBusinessOwner(BusinessOwner businessOwner)
        {
            _context.BusinessOwners.Add(businessOwner);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (BusinessOwnerExists(businessOwner.UserName))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetBusinessOwner", new { id = businessOwner.UserName }, businessOwner);
        }

        // DELETE: api/BusinessOwners/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBusinessOwner(string id)
        {
            var businessOwner = await _context.BusinessOwners.FindAsync(id);
            if (businessOwner == null)
            {
                return NotFound();
            }

            _context.BusinessOwners.Remove(businessOwner);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BusinessOwnerExists(string id)
        {
            return _context.BusinessOwners.Any(e => e.UserName == id);
        }
    }
}
