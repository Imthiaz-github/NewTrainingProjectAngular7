using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Http;
using System.Web.Http.Results;
using WebAPI.Models;

namespace WebAPI.Controllers.Tests
{
    [TestClass()]
    public class TrainingControllerTest
    {
        [TestMethod()]
        public void PutTrainingPostTraining()
        {
            var controller = new TrainingController();
            Training training = new Training
            {
                TrainingName = "Test Training",  
                StartDate = System.DateTime.Now,
                EndDate = System.DateTime.Now
            };
            // Act  
            IHttpActionResult actionResult = controller.PostTraining(training);
            var createdResult = actionResult as CreatedAtRouteNegotiatedContentResult<Training>;
            // Assert  
            Assert.IsNotNull(createdResult);
            Assert.AreEqual("DefaultApi", createdResult.RouteName);
            Assert.IsNotNull(createdResult.RouteValues["id"]);
        }
    }
}