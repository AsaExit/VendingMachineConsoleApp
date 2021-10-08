using System;
using VendingMachineConsoleApp.Data;
using VendingMachineConsoleApp.Model;
using System.Collections.Generic;
using Xunit;

namespace VendingMachineConsoleApp.Tests.ModelTest
{
    public class FoodTests
    {
        [Fact]
        public void ProductFoodClubSandwichUseStringMessageTest()
        {
            //Arrange;
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.InsertMoney(500);
            Product product = vendingMachine.Purchase(2);

            string expectedClubSandwichMessage = "If you are really hungry and want something that tast good this is a good choise. ";

            //Act
            string result = product.Use();

            //Assert
            Assert.Equal(expectedClubSandwichMessage, result);
        }

        [Fact]
        public void ProductFoodClubSandwichExamineStringContainsMessageTest()
        {
            //Arrange;
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.InsertMoney(500);
            Product product = vendingMachine.Purchase(2);

            string expectedClubSandwichMessage = $"{2}\t{"Club Sandwich"}\t\t{25}kr"; ;

            //Act
            string result = product.Examine();

            //Assert
            Assert.Equal(expectedClubSandwichMessage, result);
        }
    }
}
