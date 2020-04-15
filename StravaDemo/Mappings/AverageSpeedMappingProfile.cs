using System.Collections.Generic;
using AutoMapper;
using CSharpFunctionalExtensions;
using StravaDemo.Models;
using StravaDemo.StravaClients.Activities;

namespace StravaDemo.Mappings
{
    public class AverageSpeedMappingProfile : Profile
    {
        public AverageSpeedMappingProfile()
        {
            CreateMap<List<ActivityDto>, Result<AverageSpeed>>().ConvertUsing<ActivitiesToAverageSpeedConverter>();
        }
    }
}
