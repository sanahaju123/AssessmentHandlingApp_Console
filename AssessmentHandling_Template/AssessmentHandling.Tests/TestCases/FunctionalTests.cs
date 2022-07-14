using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace AssessmentHandling.Tests.TestCases
{
    public class FunctionalTests
    {
        /// Creating referance variable of ITestOutputHelper and injecting in constructor
        /// </summary>
        private readonly ITestOutputHelper _output;
        private Assessment _assessment;
        private static string type = "Functional";
        public FunctionalTests(ITestOutputHelper output)
        {
            _output = output;
            _assessment = new Assessment()
            {
                AssessmentId = 2,
                AssessmentName = "Assessment",
                AssessmentDate = DateTime.Now,
                AssessmentType = "Type",
                track = "Track"
            };
        }

        [Fact]
        public async Task<bool> TestFor_AddAssessment()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            try
            {
                IEnumerable<Object> result = Program.AddAssessment(_assessment);
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

        [Fact]
        public async Task<bool> TestFor_UpdateAssessment()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            try
            {
                var result = Program.UpdateAssessment(_assessment);

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



        [Fact]
        public async Task<bool> TestFor_ShowAllAssessments()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            string jsonValue = "";
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


        [Fact]
        public async Task<bool> TestFor_GetAssessmentById()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            int AssessmentId = 2;
            testName = CallAPI.GetCurrentMethodName();
            try
            {
                var result = Program.GetAssessmentById(AssessmentId);
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


        [Fact]
        public async Task<bool> TestFor_DeleteAssessment()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            var assessmentId = 1;
            testName = CallAPI.GetCurrentMethodName();
            try
            {
                List<Assessment> result = (List<Assessment>)Program.RemoveAssessmentById(assessmentId);
                //Act
                if (result[1] == null)
                {
                    res = true;
                }
            }
            catch (Exception ex)
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