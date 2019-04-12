using AutoMapper;
using vega.Controllers.Resources;
using vega.Models;

namespace vega.Controllers.Profiles
{
  public class FeatureProfile : Profile
  {
    public FeatureProfile()
    {
      CreateMap<Feature, FeatureResource>();
    }
  }
}