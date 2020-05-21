using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCart.Data;
using ShoppingCart.Models;
using ShoppingCart.Repository;

namespace ShoppingCart.Test {
    [TestClass]
    public class ShoppingCartTest {
        private ShoppingCartRepository _repository;


        [TestInitialize]
        public void Init() {
            ReInitRepo();
        }

        private void ReInitRepo() {
            var context = new MyStoreContext();
            _repository = new ShoppingCartRepository(context);
        }


        [TestMethod]
        public void CreateCustomerTest() {
            //Arrange
            var customer = new Customer() { FirstName = "Bob", LastName = "Smith" }; // populate all properties

            //Act
            _repository.AddCustomer(customer);

            //Assert
            var customerId = customer.CustomerId;
            Assert.IsTrue(customerId > 0);
            ReInitRepo();
            // get customerById
            var customerFromDb = _repository.CustomerRetrieve(customerId);
            Assert.AreEqual(customer.FirstName, customerFromDb.FirstName);
            Assert.AreEqual(customer.LastName, customerFromDb.LastName);
            //TODO Check All properties
        }

        [TestMethod]
        public void CreateProductTest() {
            //Arrange
            var product = new Product() { Name = "Razer Deathadder Elite Optical Gaming Mouse", SKU = "RDEOGM-1", Description = "Razer Deathadder Elite Optical Gaming Mouse", Price = (decimal)89.45 }; // populate all properties

            //Act
            _repository.AddProduct(product);

            //Assert
            var productId = product.ProductId;
            Assert.IsTrue(productId > 0);
            ReInitRepo();

            var fromDb = _repository.ProductRetrieve(productId);
            Assert.AreEqual(product.Name, fromDb.Name);
            Assert.AreEqual(product.Description, fromDb.Description);
            //TODO Check All properties

        }


        [TestMethod]
        public void GetAllCustomersTest() {
        }


        [TestMethod]
        public void GetCustomerByIdTest() {
            //Arrange
            var customerId = 1;

            //Act
            Customer customer = _repository.CustomerRetrieve(customerId);

            //Assert
            Assert.IsNotNull(customer);
            Assert.AreEqual(customerId, customer.CustomerId);
        }

        [TestMethod]
        public void GetAllCustomerTest() {
            List<Customer> customers = _repository.CustomerRetrieve();
            Assert.IsTrue(customers.Any());
        }


        [TestMethod]
        public void UpdateCustomersTest() {
        }

        [TestMethod]
        public void UpdateProductTest () {
        }


        [TestMethod]
        public void CreateOrderWithOneProductTest() {

        }

        [TestMethod]
        public void AddItemToExistingOrderTest() {

        }

        [TestMethod]
        public void UpdateProductQuantityOrderTest() {

        }


        [TestMethod]
        public void RemoveProductFromOrderTest() {

        }

        [TestMethod]
        public void CompleteOrderTest() {
            //Set Order.IsComplete=true
            //Order.TransactionId = some random string

        }


        [TestMethod]
        public void GetCustomersWithNotCompletedOrdersTest () {
        }

     


    }
}
