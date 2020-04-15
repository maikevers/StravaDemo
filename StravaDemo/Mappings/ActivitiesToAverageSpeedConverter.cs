using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using AutoMapper;
using CSharpFunctionalExtensions;
using StravaDemo.Models;
using StravaDemo.StravaClients.Activities;
using UnitsNet;

namespace StravaDemo.Mappings
{
    public class ActivitiesToAverageSpeedConverter : ITypeConverter<List<ActivityDto>, Result<AverageSpeed>>
    {
        public Result<AverageSpeed> Convert(List<ActivityDto> source, Result<AverageSpeed> destination, ResolutionContext context)
        {
            IEnumerable<float> speedsFromDto = source.Select(p => p.average_speed);
            IEnumerable<Speed> convertedSpeeds = speedsFromDto.Select(Convert);
            return AverageSpeed.Create(convertedSpeeds.ToImmutableList());
        }

        private static Speed Convert(float source)
        {
            return Speed.FromKilometersPerHour(source);
        }
    }
}
