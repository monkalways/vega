using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vega.Controllers.Resources;
using vega.Persistence;

namespace vega.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ModelsController : ControllerBase
  {
    private readonly VegaDbContext context;
    private readonly IMapper mapper;

    public ModelsController(VegaDbContext context, IMapper mapper)
    {
      this.context = context;
      this.mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<ModelResource>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAsync()
    {
      var models = await context.Models.ToListAsync();
      return Ok(mapper.Map<List<ModelResource>>(models));
    }
  }
}