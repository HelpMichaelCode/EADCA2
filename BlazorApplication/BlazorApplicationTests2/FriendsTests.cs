using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlazorApplication;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BlazorApplication.Tests
{
    [TestClass()]
    public class FriendsTests
    {
        [TestMethod()]
        public void SortTableTestInAscendingOrerBasedOnCharacterNames()
        {
            // Arrange
            QueryFriends friend = new QueryFriends
            {
                listOfQuotes = new List<FriendsResponseData>()
            };

            var expectedOrder = friend.listOfQuotes;
            var actualResult = "";
            var expectedResult = "";

            FriendsResponseData friend1 = new FriendsResponseData
            {
                quote = "Pivot! Pivot! Pivot! Pivot! Pivot!",
                character = "Ross"
            };
            FriendsResponseData friend2 = new FriendsResponseData
            {
                quote = "Joey doesn't share food!",
                character = "Joey"
            };
            FriendsResponseData friend3 = new FriendsResponseData
            {
                quote = "Guys can fake it? Unbelievable! The one thing that’s ours!",
                character = "Monica"
            }; FriendsResponseData friend4 = new FriendsResponseData
            {
                quote = "It's a moo point. It's like a cow's opinion; it doesn't matter. It's moo.",
                character = "Joey"
            };


            // Act
            friend.listOfQuotes.Add(friend1);
            friend.listOfQuotes.Add(friend2);
            friend.listOfQuotes.Add(friend3);
            friend.listOfQuotes.Add(friend4);

            friend.SortTable("Character");
            expectedOrder = expectedOrder.OrderBy(name => name.character).ToList();

            foreach (var item in friend.listOfQuotes)
            {
                actualResult += $"{item.character},";
            }
            foreach (var item in expectedOrder)
            {
                expectedResult += $"{item.character},";
            }

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void SortTableTestInDescendingOrerBasedOnCharacterNames()
        {
            // Arrange
            QueryFriends friend = new QueryFriends
            {
                listOfQuotes = new List<FriendsResponseData>()
            };

            var expectedOrder = friend.listOfQuotes;
            var actualResult = "";
            var expectedResult = "";

            FriendsResponseData friend1 = new FriendsResponseData
            {
                quote = "Pivot! Pivot! Pivot! Pivot! Pivot!",
                character = "Ross"
            };
            FriendsResponseData friend2 = new FriendsResponseData
            {
                quote = "Joey doesn't share food!",
                character = "Joey"
            };
            FriendsResponseData friend3 = new FriendsResponseData
            {
                quote = "Guys can fake it? Unbelievable! The one thing that’s ours!",
                character = "Monica"
            }; FriendsResponseData friend4 = new FriendsResponseData
            {
                quote = "It's a moo point. It's like a cow's opinion; it doesn't matter. It's moo.",
                character = "Joey"
            };


            // Act
            friend.listOfQuotes.Add(friend1);
            friend.listOfQuotes.Add(friend2);
            friend.listOfQuotes.Add(friend3);
            friend.listOfQuotes.Add(friend4);

            friend.SortTable("Character");
            friend.SortTable("Character");
            expectedOrder = expectedOrder.OrderByDescending(name => name.character).ToList();

            foreach (var item in friend.listOfQuotes)
            {
                actualResult += $"{item.character},";
            }
            foreach (var item in expectedOrder)
            {
                expectedResult += $"{item.character},";
            }

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CheckIfSearchValueForCharacterIsWorking()
        {
            // Arrange
            QueryFriends friend = new QueryFriends
            { 
                listOfQuotes = new List<FriendsResponseData>()
            };

            FriendsResponseData friend1 = new FriendsResponseData
            {
                character = "Ross"
            };

            FriendsResponseData friend2 = new FriendsResponseData
            {
                character = "Chandler"
            };

            FriendsResponseData friend3 = new FriendsResponseData
            {
                character = "Monica"
            };

            // Act
            friend.listOfQuotes.Add(friend1);
            friend.listOfQuotes.Add(friend2);
            friend.listOfQuotes.Add(friend3);

            friend.InputValue = "Ross";

            // Assert
            //Assert.IsTrue(friend.IsVisible(friend));
        }

        [TestMethod]
        public void CheckIfSearcKeyWordForQuoteIsWorking()
        {
            //// Arrange
            //QueryFriends friend = new QueryFriends();
            //var quoteSearch = new FriendsResponseData { quote = "Pivot! Pivot! Pivot! Pivot! Pivot!" };

            //quoteSearch.InputValue = "332";
            //// Act

            //// Assert
            //Assert.IsTrue(friend.IsVisible(quoteSearch));
        }
    }
}