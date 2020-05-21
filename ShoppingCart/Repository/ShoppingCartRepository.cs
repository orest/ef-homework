using System;
using System.Collections.Generic;
using ShoppingCart.Data;
using ShoppingCart.Models;

namespace ShoppingCart.Repository {
    public class ShoppingCartRepository {
        private readonly MyStoreContext _context;

        public ShoppingCartRepository(MyStoreContext context) {
            _context = context;
        }

        public void AddCustomer(Customer customer) {
            throw new NotImplementedException();
        }
        public void AddProduct(Product product) {
            throw new NotImplementedException();
            //_context.Products.Add(product);
            //_context.SaveChanges();
        }

        public Customer CustomerRetrieve(int customerId) {
            throw new NotImplementedException();
        }
        public List<Customer> CustomerRetrieve() {
            throw new NotImplementedException();
        }


        public Product ProductRetrieve(int productId) {
            throw new NotImplementedException();
            //var product = _context.Products.Find(productId);
            //return product;
        }
        public List<Product> ProductRetrieve() {
            throw new NotImplementedException();
        }
    }
}
