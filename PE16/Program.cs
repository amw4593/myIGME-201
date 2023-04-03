using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE16
{
    internal class Program
    {
    public interface ICustomer
        {
            void Greet();
        }
    public class ITakeOrder
        {
        
        }
        public class IMood
        {
            public string r;
        }
        public class Customer : IMood
        {
            public string name;
            private string creditCardNumber;
            public string CreditCardNumber
            {
                set
                {
                    this.creditCardNumber = value;
                }
            }
        }

        public abstract class HotDrink
        {
            public bool instant;
            public bool milk;
            private byte sugar;
            public string brand;
            public string size;

            public Customer customer;

            public HotDrink()
            {
            }

            public HotDrink(string brand)
            {
            }

            public virtual void AddSugar(byte amount)
            {
            }

            public abstract void Steam();
        }

        public class CupOfCoffee : HotDrink
        {
            public string beanType;

            public CupOfCoffee()
            {

            }

            public CupOfCoffee(string brand) : base(brand)
            {
        
            }

            public override void Steam()
            {
            }
        }

    }
}
