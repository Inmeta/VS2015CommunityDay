using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._2_Using_ExpressionBodies
{
    public class CustomerCollection
    {
        public Store TheStore { get; } 
        public CustomerCollection(Store store)
        {
            TheStore = store;
        }
        
        public Customer this[int id] => TheStore.FindCustomer(id);

    }

    public class Customer
    {
        public string Name { get; }
        int Id { get; }
        public Customer(string name,int id)
        {
            Name = name;
            Id = id;
        }

        public string Identification => "Kundeno: \{Id}  " + Name;

    }

        public class Store
        {
            public Customer FindCustomer(int id)
            {
                return new Customer("xxxx", id);
            }
        }

}
