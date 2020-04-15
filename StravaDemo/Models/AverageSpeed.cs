using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using CSharpFunctionalExtensions;
using UnitsNet;
using UnitsNet.Units;

namespace StravaDemo.Models
{
    public class AverageSpeed : ValueObject
    {
        private readonly IImmutableList<Speed> _averagesPerActivity;

        private AverageSpeed(IImmutableList<Speed> averagesPerActivity)
        {
            _averagesPerActivity = averagesPerActivity;

            Result checkResult = InvalidStateCheck(averagesPerActivity);
            checkResult.OnFailure(error => throw new InvalidOperationException(error));
        }

        public static Result<AverageSpeed> Create(IImmutableList<Speed> averagesPerActivity)
        {
            Result checkResult = InvalidStateCheck(averagesPerActivity);
            return checkResult.Map(() => new AverageSpeed(averagesPerActivity)); 
        }

        private static Result InvalidStateCheck(IImmutableList<Speed> averagesPerActivity)
        {
            if (!averagesPerActivity.Any())
            {
                return Result.Failure("Constructor argument list of averages should not be empty.");
            }

            return Result.Ok();
        }

        public Speed GetAverage()
        {
            return _averagesPerActivity.Average(SpeedUnit.KilometerPerHour);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            foreach (Speed speed in _averagesPerActivity)
            {
                yield return speed;
            }
        }
    }
}
