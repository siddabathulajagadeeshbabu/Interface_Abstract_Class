using System;

namespace Interface_Abstract_Class
{
    abstract class Payment
    {
        public string PaymentId { get; set; }

        public abstract void MakePayment(decimal amount);
        //here we are not defining the body of the method
        //This is an abstract method that must be implemented by derived classes

        public void GenrateReceipt()
        {
            //This is a concrete method that can be used by derived classes
            Console.WriteLine($"Receipt generated for payment ID: {PaymentId}");
        }
    }
}
