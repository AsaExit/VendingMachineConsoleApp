using System;
using System.Collections.Generic;
using System.Text;
using VendingMachineConsoleApp.Data;
using VendingMachineConsoleApp.Model;
using Xunit;

namespace VendingMachineConsoleApp.Tests.ModelTest
{
    public class ToyTests
    {
        [Fact]
        public void ProductToyStuffedAnimalCowUseStringMessageTest()
        {
            //Arrange;
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.InsertMoney(500);
            Product product = vendingMachine.Purchase(1);

            string expectedStuffedAnimalCowMessage = "If you need conferting or just a cuddling friend, so hugg it!";

            //Act
            string result = product.Use();

            //Assert
            Assert.Equal(expectedStuffedAnimalCowMessage, result);
        }

        [Fact]
        public void ProductDrinkBeerExamineStringContainsMessageTest()
        {
            //Arrange;
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.InsertMoney(500);
            Product product = vendingMachine.Purchase(1);

            string expectedStuffedAnimalCowMessage = $"{1}\t{"Stuffed animal Cow"}\t\t{100}kr"; ;

            //Act
            string result = product.Examine();

            //Assert
            Assert.Equal(expectedStuffedAnimalCowMessage, result);
        }
    }
}
