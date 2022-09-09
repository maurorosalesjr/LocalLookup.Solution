using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LocalApi.Models;

namespace LocalApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class LocalsController : ControllerBase
  {
    private readonly LocalApiContext _db;

    public LocalsController(LocalApiContext db)
    {
      _db = db;
    }

    // GET: api/Locals
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Local>>> Get(string blerb, string location, string country, int minimumRating)
    {
      IQueryable<Local> query = _db.Locals.AsQueryable();

      if (blerb != null)
      {
        query = query.Where(entry => entry.Blerb == blerb);
      }
      if (location != null)
      {
        query = query.Where(entry => entry.Location == location);
      }
      if (country != null)
      {
        query = query.Where(entry => entry.Country == country);
      }
      if (minimumRating > 0)
      {
        query = query.Where(entry => entry.Rating >= minimumRating);
      }
      return await query.ToListAsync();
    }

    // GET: api/Locals/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Local>> GetLocal(int id)
    {
        var local = await _db.Locals.FindAsync(id);

        if (local == null)
        {
            return NotFound();
        }

        return local;
    }

    // PUT: api/Locals/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Local local)
    {
      if (id != local.LocalId)
      {
        return BadRequest();
      }

      _db.Entry(local).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!LocalExists(id))
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

    // POST: api/Locals
    [HttpPost]
    public async Task<ActionResult<Local>> Post(Local local)
    {
      _db.Locals.Add(local);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetLocal), new { id = local.LocalId }, local);
    }

    // DELETE: api/Locals/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteLocal(int id)
    {
      var local = await _db.Locals.FindAsync(id);
      if (local == null)
      {
        return NotFound();
      }

      _db.Locals.Remove(local);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    private bool LocalExists(int id)
    {
      return _db.Locals.Any(e => e.LocalId == id);
    }
  }
}