using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace example
{
    class LoanProcess
    {
        int Loan_No;
        string Customer_Name;
        int LoanAmount;
        int EMI_Amount;
        int Account_Balance;
        int Acc_Balance;
        public void calculate_EMI(int LoanAmount)
        {
            EMI_Amount = (LoanAmount * 13 / 100) * 3;
            Console.WriteLine("Emi Amount: " + EMI_Amount);
        }
        public LoanProcess(int Loan_No, string Customer_Name, int EMI_Amount, int Account_Balance)
        {
            this.Loan_No = Loan_No;
            this.Customer_Name = Customer_Name;
            this.EMI_Amount = EMI_Amount;
            this.Account_Balance = Account_Balance;
            Console.WriteLine("Loan no: " + this.Loan_No + " customer name: " + this.Customer_Name + /*" emi amount: " + this.EMI_Amount +*/ " Account bal: " + this.Account_Balance);
        }
        public void CheckBalance()
        {
            if (Account_Balance < EMI_Amount)
            {
                throw (new CustomException("Not Sufficient Balance to repay Loan"));
            }
            else
            {
                Console.WriteLine("Remaining Balance is: {0}", Acc_Balance = Account_Balance - EMI_Amount);
            }
        }
    }
    class CustomException : ApplicationException
    {
        public CustomException(string s) : base(s)
        {





        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            LoanProcess lp = new LoanProcess(3, "vamsi", 2500, 20000);
            lp.calculate_EMI(5000);
            lp.CheckBalance();
            Console.ReadLine();
        }
    }
}
