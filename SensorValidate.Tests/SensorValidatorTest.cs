using System.Collections.Generic;
using Xunit;

namespace SensorValidate.Tests
{
    public class SensorValidatorTest
    {
        [Fact]
        public void reportsErrorWhenSOCjumps()
        {
            Assert.False(SensorValidator.validateSOCreadings(new List<double> { 0.0, 0.01, 0.5, 0.51 }, 0.05));
        }
        [Fact]
        public void reportsErrorWhenCurrentjumps()
        {
            Assert.False(SensorValidator.validateCurrentreadings(new List<double> { 0.03, 0.03, 0.03, 0.33 }, 0.1));
        }
        [Fact]
        public void NoErrorWhenCurrentJumps()
        {
            Assert.True(SensorValidator.validateCurrentreadings(new List<double> { 0.03, 0.08, 0.15, 0.21 }, 0.1));
        }
        [Fact]
        public void NoErrorWhenSOCJumps()
        {
            Assert.True(SensorValidator.validateSOCreadings(new List<double> { 0.0, 0.01, 0.05, 0.08 }, 0.05));
        }
        [Fact]
        public void NoErrorWhenSOCSameValues()
        {
            Assert.True(SensorValidator.validateSOCreadings(new List<double> { 0.00, 0.00, 0.00, 0.00 }, 0.05));
        }
        [Fact]
        public void NoErrorWhenCurrentSameValues()
        {
            Assert.True(SensorValidator.validateCurrentreadings(new List<double> { 0.10, 0.10, 0.10, 0.10 }, 0.05));
        }
        [Fact]
        public void reportsErrorWhenCurrentValuesNull()
        {
            Assert.False(SensorValidator.validateCurrentreadings(null, 0.05));
        }
        [Fact]
        public void reportsErrorWhenSOCValuesNull()
        {
            Assert.False(SensorValidator.validateSOCreadings(null, 0.05));
        }
        [Fact]
        public void reportsErrorWhenCurrentListEmpty()
        {
            Assert.False(SensorValidator.validateCurrentreadings(new List<double> { }, 0.05));
        }
        [Fact]
        public void reportsErrorWhenSOCListEmpty()
        {
            Assert.False(SensorValidator.validateSOCreadings(new List<double> { }, 0.05));
        }
    }
}
