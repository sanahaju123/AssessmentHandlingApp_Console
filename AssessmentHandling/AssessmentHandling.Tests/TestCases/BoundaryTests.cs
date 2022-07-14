using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace AssessmentHandling.Tests.TestCases
{
    public class BoundaryTests
    {
        // <summary>
        /// Creating referance variable of ITestOutputHelper and injecting in constructor
        /// </summary>
        private readonly ITestOutputHelper _output;
        private Assessment _assessment;
        private static string type = "Boundary";
        public BoundaryTests(ITestOutputHelper output)
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
        /// Validate Show All Assessments.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestFor_ValidateShowAllAssessments()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            try
            {
                var result = Program.ShowAllAssessments();
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

