using System;
namespace liveonswagger.Model
{
    public class PagSeguroTransactionGet
    {
        public string Code { get; set; }
        public DateTime DateOfCreation { get; set; }
        public DateTime DateOfLastEvent { get; set; }
        public string Status { get; set; }
        public decimal NetAmount { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    }


    public class PagSeguroTransactionPost
    {
        public CustomerGet Customer { get; set; }
        public decimal NetAmount { get; set; }
    }

    public class PagSeguroTransactionGetDetail
    {
        public string Code { get; set; }
        public DateTime DateOfCreation { get; set; }
        public DateTime DateOfLastEvent { get; set; }
        public string Status { get; set; }
        public decimal NetAmount { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public CustomerGet Customer { get; set; }
    }


}
