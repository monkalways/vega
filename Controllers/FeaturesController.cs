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
  [Route("/api/[controller]")]
  [ApiController]
  public class FeaturesController : ControllerBase
  {
    private readonly VegaDbContext context;
    private readonly IMapper mapper;

    public FeaturesController(VegaDbContext context, IMapper mapper)
    {
      this.context = context;
      this.mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<FeatureResource>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAsync()
    {
      var features = await context.Features.ToListAsync();
      return Ok(mapper.Map<List<FeatureResource>>(features));
    }
  }
}