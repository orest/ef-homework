using System.Linq;
using ShoppingCart.Data;

namespace ShoppingCart {
    class Program {
        static void Main(string[] args) {
            using (var context=new MyStoreContext())
            {
                var customers = context.Customers.ToList();
            }
        }
    }
}
