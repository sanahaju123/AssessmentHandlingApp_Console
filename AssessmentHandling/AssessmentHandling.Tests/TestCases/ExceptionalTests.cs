using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace AssessmentHandling.Tests.TestCases
{
    public class ExceptionalTests
    {
        // <summary>
        /// Creating referance variable of ITestOutputHelper and injecting in constructor
        /// </summary>
        private readonly ITestOutputHelper _output;
        private Assessment _assessment;
        private static string type = "Exception";
        public ExceptionalTests(ITestOutputHelper output)
        {
            _output = output;
            _assessment = new Assessment()
            {
                AssessmentId = 1,
                AssessmentName = "Assessment",
                AssessmentDate = DateTime.Now,
                AssessmentType = "Type",
                track = "Track"
            };
        }

        /// <summary>
        /// If passing null will return false.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestFor_ReturnNull_AddAssessment()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            _assessment = null;
            testName = CallAPI.GetCurrentMethodName();
            try
            {
                var result = Program.AddAssessment(_assessment);
                //Act
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            ///Assert
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

    }
}

