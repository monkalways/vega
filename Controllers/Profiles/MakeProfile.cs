using AutoMapper;
using vega.Controllers.Resources;
using vega.Models;

namespace vega.Controlles.Profiles
{
  public class MakeProfile : Profile
  {
    public MakeProfile()
    {
      CreateMap<Make, MakeResource>();
    }
  }
}