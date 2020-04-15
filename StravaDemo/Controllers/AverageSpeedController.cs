using System.Collections.Generic;
using AutoMapper;
using CSharpFunctionalExtensions;
using Microsoft.AspNetCore.Mvc;
using StravaDemo.Models;
using StravaDemo.StravaClients.Activities;
using UnitsNet;

namespace StravaDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AverageSpeedController : BaseController
    {
        private readonly ActivitiesClient _activitiesClient;
        private readonly IMapper _mapper;

        public AverageSpeedController(ActivitiesClient activitiesClient, IMapper mapper)
        {
            _activitiesClient = activitiesClient;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAverages()
        {
            List<ActivityDto> activities = _activitiesClient.GetActivities();
            Result<AverageSpeed> model = _mapper.Map<Result<AverageSpeed>>(activities);
            Result<Speed> averageSpeed = model.Map(p => p.GetAverage());
            Result<double> kilometersPerHour = averageSpeed.Map(p => p.KilometersPerHour);
            return FromResult(kilometersPerHour);
        }
    }
}
