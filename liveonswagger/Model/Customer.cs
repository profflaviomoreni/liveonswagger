using System;
namespace liveonswagger.Model
{
    /// <summary>
    ///     Cliente 
    /// </summary>
    /// <remarks>
    ///     Entidade que representa a entidade de cliente do sistema
    /// </remarks>
    public class Customer
    {
        /// <summary>
        ///     Primeiro Nome
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        ///     Último nome
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        ///     CPF
        /// </summary>
        public string SocialSecurity { get; set; }

        public string Email { get; set; }

        /// <summary>
        ///     Ativo
        /// </summary>
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
