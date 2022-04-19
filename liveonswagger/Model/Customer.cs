using System;
namespace liveonswagger.Model
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }

    }


    public class CustomerPut : Customer
    {
        public int IdCustomer { get; set; }
        public String Password { get; set; }
    }

    public class CustomerPost : Customer
    {
        public String Password { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class CustomerGet : Customer
    {
        public int IdCustomer { get; set; }
        public DateTime CreatedAt { get; set; }
    }


}
