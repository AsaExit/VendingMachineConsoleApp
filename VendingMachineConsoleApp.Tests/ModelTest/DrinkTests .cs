using System;
using System.Collections.Generic;
using System.Text;
using VendingMachineConsoleApp.Data;
using VendingMachineConsoleApp.Model;
using Xunit;

namespace VendingMachineConsoleApp.Tests.ModelTest
{
    public class DrinkTests
    {
        [Fact]
        public void ProductDrinkBeerUseStringMessageTest()
        {
            //Arrange;
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.InsertMoney(500);
            Product product = vendingMachine.Purchase(3);

            string expectedBeerMessage = "If you are 18 years and older...Just enjoy ur Beer!";

            //Act
            string result = product.Use();

            //Assert
            Assert.Equal(expectedBeerMessage, result);
        }

        [Fact]
        public void ProductDrinkBeerExamineStringContainsMessageTest()
        {
            //Arrange;
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.InsertMoney(500);
            Product product = vendingMachine.Purchase(3);

            string expectedBeerMessage = $"{3}\t{"Beer"}\t\t{30}kr"; ;

            //Act
            string result = product.Examine();

            //Assert
            Assert.Equal(expectedBeerMessage, result);
        }

    }
}
