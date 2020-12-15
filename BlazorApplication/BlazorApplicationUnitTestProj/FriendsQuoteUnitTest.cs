using Microsoft.AspNetCore.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorApplicationUnitTestProj
{
    [TestClass]
    public class FriendsQuoteUnitTest
    {
        [TestMethod]
        public void CheckThatItTurnsTheRightQuote()
        {
            // Arrange
           var handlerMock = new Mock<HttpMessageHandler>();
           var httpContext = new DefaultHttpContext();
           var response = new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(@"[{ ""id"": 1, ""title"": ""Cool post!""}, { ""id"": 100, ""title"": ""Some title""}]"),
            };

            var httpClient = new HttpClient(handlerMock.Object)
            {
                BaseAddress = new Uri("https://friends-quotes-api.herokuapp.com/quotes")
            };

            // Act
            
            // Assert
            //Assert.AreEqual("Hello", actualData);
        }

        [TestMethod]
        public void CheckForSortedArray() 
        {
            // Arrange
            Friends friend = new Friends();





            // Act


            // Assert
        }
    }
}
