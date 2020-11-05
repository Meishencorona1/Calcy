using System;
using TechTalk.SpecFlow;
using Xunit;

namespace Calcy
{
    [Binding]
    public class TrigonometrySteps
    {
        private double x, y;
        [Given(@"a number is Pi")]
        public void GivenANumberIsPi()
        {
            x = Math.PI;
        }
        
        [When(@"the sinus is calculated")]
        public void WhenTheSinusIsCalculated()
        {
            y = Math.Sin(x);
        }
        
        [When(@"the cosinus is calculated")]
        public void WhenTheCosinusIsCalculated()
        {
            y = Math.Cos(x);
        }

        [When(@"the tangens is calculated")]
        public void WhenTheTangensIsCalculated()
        {
            y = Math.Tan(x);
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(double p0)
        {
            var expected = p0;
            var actual = y;
            Assert.Equal(expected,actual,5);
        }
    }
}
