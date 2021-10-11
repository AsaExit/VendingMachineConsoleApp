using System;
using VendingMachineConsoleApp.Data;
using VendingMachineConsoleApp.Model;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VendingMachineConsoleApp.Tests.DataTest
{
    public class VendingMachineTests
    {
        [Fact]
        public void MoneyDenominationsContainsCorrectAmounChange()
        {
            //Arange
            int expectedLength = 8;
            int[] expetedMoneyDenomination = new int[] { 1, 5, 10, 20, 50, 100, 500, 1000 };
            //Act
            int[] result = expetedMoneyDenomination;

            //Assert
            Assert.Equal(expectedLength, result.Length);
            Assert.NotNull(result);
            Assert.Equal(result, expetedMoneyDenomination);
        }
        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(50)]
        [InlineData(100)]
        [InlineData(500)]
        [InlineData(1000)]
        public void InsertMoneyCurrency(int currecy)
        {
            //Arrange;
             VendingMachine vendingMachine = new VendingMachine();

            //Act
            vendingMachine.InsertMoney(currecy);

            //Act
            Assert.Equal(currecy, vendingMachine.MoneyPool);

        }
        [Theory]
        [InlineData(0)]
        [InlineData(400)]
        [InlineData(1500)]
        [InlineData(300.0)]
        [InlineData(-300)]
        public void InsertMoneyCurrencyThrowExceptionWithIncorrectMoneyDenomination(int currecy)
        {
            //Arrange;
            VendingMachine vendingMashine = new VendingMachine();
            int moneyPool = vendingMashine.MoneyPool;

            //Act
            ArgumentException result = Assert.Throws<ArgumentException>(() => vendingMashine.InsertMoney(currecy));

            //Assert
            Assert.Equal("Have you inserted the correctfull amout to the denominations?", result.Message);
        }
        [Fact]
        public void PurchaseProductWithInsuffitientCurrencyShouldThrowException()
        {
            //Arrange;
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.InsertMoney(10);
            // Product id 1 stuffed animal Cow 100Kr
            //Act
            ArgumentException result = Assert.Throws<ArgumentException>(() => vendingMachine.Purchase(1));

            //Assert
            Assert.Equal("You dont have sufficient amout of money for this product?", result.Message);
        }
        [Fact]

        public void EndTransactionTestDFoodClubSandwich()
        {
            //Arrange;
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.InsertMoney(500);
            Product product = vendingMachine.Purchase(2);

            // Product id 2. Club Sandwich 25 kr 500-25=475 4 st hundralappar/1st 50 lapp 1 st 20 lapp och en 5:a
            Dictionary<int, int> expectedChangeClubSandwich = new Dictionary<int, int> { { 100, 4 }, { 50, 1 }, { 20, 1 }, { 5, 1 } };

            //Act
            Dictionary<int, int> result = vendingMachine.EndTransaction(product.productId);

            //Assert
            Assert.Equal(expectedChangeClubSandwich, result);
        }
        [Fact]
        public void PurchaseProductWithNoExistingProductIdShouldThrowException()
        {
            //Arrange;
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.InsertMoney(500);

            //Act
            ArgumentException result = Assert.Throws<ArgumentException>(() => vendingMachine.Purchase(0));

            //Assert
            Assert.Equal("the product you are looking for dose not exist", result.Message);
        }
        [Fact]
        public void PurchaseProductFoodClubSandwichWithCorrectProductId()
        {
            //Arrange;
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.InsertMoney(500);
            Food expectedClubSandwich = new Food();

            //Act
            Product result = vendingMachine.Purchase(2);

            //Assert
            Assert.Equal(expectedClubSandwich.productId, result.productId);
        }
        [Fact]
        public void PurchaseProductDrinkBeerWithCorrectProductId()
        {
            //Arrange;
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.InsertMoney(500);
            Drink expectedBeer = new Drink();

            //Act
            Product result = vendingMachine.Purchase(3);

            //Assert
            Assert.Equal(expectedBeer.productId, result.productId);
        }
        [Fact]
        public void PurchaseProductToyStuffedAnimalCowWithCorrectProductId()
        {
            //Arrange;
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.InsertMoney(500);
            Toy expectedStuffedAnimalCow = new Toy();

            //Act
            Product result = vendingMachine.Purchase(1);

            //Assert
            Assert.Equal(expectedStuffedAnimalCow.productId, result.productId);
        }
        [Fact]
        public void EndTransactionTestForToyStuffedAnimalCow()
        {
            //Arrange;
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.InsertMoney(500);
            Product product = vendingMachine.Purchase(1);

            // Product id 1. Stuffed animal Cow 100 kr 500-100=400 4 st hundralappar
            Dictionary<int, int> expectedChangeCow = new Dictionary<int, int> { { 100, 4 } };

            //Act
            Dictionary<int, int> result = vendingMachine.EndTransaction(product.productId);

            //Assert
            Assert.Equal(expectedChangeCow, result);
        }
        [Fact]
        public void EndTransactionTestForDrinkBeer()
        {
            //Arrange;
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.InsertMoney(500);
            Product product = vendingMachine.Purchase(3);

            // Product id 3. Beer 30Kr 500-30=470 4 st hundralappar 1st 50 lapp 1 20 lapp
            Dictionary<int, int> expectedChangeBeer = new Dictionary<int, int> { { 100, 4 }, { 50, 1 }, { 20, 1 } };

            //Act
            Dictionary<int, int> result = vendingMachine.EndTransaction(product.productId);

            //Assert
            Assert.Equal(expectedChangeBeer, result);
        }

    }
}
