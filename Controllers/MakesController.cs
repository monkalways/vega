using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vega.Controllers.Resources;
using vega.Models;
using vega.Persistence;

namespace vega.Migrations
{
  [Route("api/[controller]")]
  [ApiController]
  public class MakesController : ControllerBase
  {
    private readonly VegaDbContext context;
    private readonly IMapper mapper;

    public MakesController(VegaDbContext context, IMapper mapper)
    {
      this.context = context;
      this.mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<MakeResource>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAsync()
    {
      var makes = await context.Makes.Include(m => m.Models).ToListAsync();
      return Ok(mapper.Map<List<MakeResource>>(makes));
    }
  }
}