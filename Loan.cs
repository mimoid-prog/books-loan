using System;
namespace zaliczenie
{
    public class Loan
    {
        public string itemId;
        public string loanerName;

        public Loan(string itemId, string loanerName)
        {
            this.itemId = itemId;
            this.loanerName = loanerName;
        }
    }
}

