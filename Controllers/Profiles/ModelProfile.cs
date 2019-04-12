using AutoMapper;
using vega.Controllers.Resources;
using vega.Models;

namespace vega.Controllers.Profiles
{
  public class ModelProfile : Profile
  {
    public ModelProfile()
    {
      CreateMap<Model, ModelResource>();
    }
  }
}