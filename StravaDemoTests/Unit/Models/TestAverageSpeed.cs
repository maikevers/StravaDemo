using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using CSharpFunctionalExtensions;
using NUnit.Framework;
using StravaDemo.Models;
using UnitsNet;

namespace StravaDemoTests.Unit.Models
{
    [TestFixture]
    public class TestAverageSpeed
    {
        private const double Tolerance = 0.001;

        private static IEnumerable<TestCaseData> GetTestCases()
        {
            yield return new TestCaseData(new List<Speed>
            {
                Speed.FromKilometersPerHour(0)
            }).SetName("One activity, speed zero");

            yield return new TestCaseData(new List<Speed>
            {
                Speed.FromKilometersPerHour(0),
                Speed.FromKilometersPerHour(0),
            }).SetName("Two activities, all speeds zero");

            yield return new TestCaseData(new List<Speed>
            {
                Speed.FromKilometersPerHour(0),
                Speed.FromKilometersPerHour(1),
                Speed.FromKilometersPerHour(2),
            }).SetName("Three activities, average should be 1");
        }

        [Test]
        [TestCaseSource(nameof(GetTestCases))]
        public void TestGetAverageSpeedReturnsExpectedAverage(List<Speed> speedsPerActivity)
        {
            double expectedAverage = GetExpectedAverageSpeedInKilometersPerHour(speedsPerActivity);

            AverageSpeed averageSpeed = AverageSpeed.Create(speedsPerActivity.ToImmutableList()).Value;
            double computedAverage = averageSpeed.GetAverage().KilometersPerHour;

            Assert.AreEqual(expectedAverage, computedAverage, Tolerance);
        }

        [Test]
        [TestCaseSource(nameof(GetTestCases))]
        public void TestAverageSpeedConstructorReturnsResultOkIfGivenNonEmptyList(List<Speed> speedsPerActivity)
        {
            Result<AverageSpeed> averageSpeed = AverageSpeed.Create(speedsPerActivity.ToImmutableList());
            Assert.True(averageSpeed.IsSuccess);
        }

        [Test]
        public void TestAverageSpeedConstructorReturnsResultFailureIfGivenEmptyList()
        {
            Result<AverageSpeed> averageSpeed = AverageSpeed.Create(new List<Speed>().ToImmutableList());
            Assert.True(averageSpeed.IsFailure);
        }

        private static double GetExpectedAverageSpeedInKilometersPerHour(List<Speed> speedsPerActivity)
        {
            return speedsPerActivity.Sum(p => p.KilometersPerHour) / speedsPerActivity.Count;
        }
    }
}
