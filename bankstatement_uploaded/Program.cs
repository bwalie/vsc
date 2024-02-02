namespace banking_management
{
   class BankDetails
   {
       private string accno;
       private string name;
       private string accountType;
       private long balance;


       public void OpenAccount()
       {
           Console.Write("Enter account No: ");
           accno = Console.ReadLine();


           Console.Write("Enter account type(debit/saving): ");
           accountType = Console.ReadLine();


           Console.Write("Enter Name: ");
           name = Console.ReadLine();


           Console.Write("Enter balance: ");
           balance = Convert.ToInt64(Console.ReadLine());
       }


       public void ShowAccount()
       {
           Console.WriteLine("Name of account holder: " + name);
           Console.WriteLine("Account no: " + accno);
           Console.WriteLine("Account type: " + accountType);
           Console.WriteLine("Balance: " + balance);
       }


       public void Deposit()
       {
           long amt;
           Console.Write("Enter the amount you want to deposit: ");
           amt = Convert.ToInt64(Console.ReadLine());
           balance += amt;
           Console.WriteLine("Balance after deposit: " + balance);
       }


       public void Withdrawal()
       {
           long amt;
           Console.Write("Enter the amount you want to withdraw: ");
           amt = Convert.ToInt32(Console.ReadLine());


           if (balance >= amt)
           {
               balance = balance-amt;
               Console.WriteLine("Balance after withdrawal: " + balance);
           }
           else
           {
               Console.WriteLine("Balance is less than " + amt + "\tTransaction failed...");
           }
       }


       public bool Search(string ac_no)
       {
           if (accno.Equals(ac_no))
           {
               ShowAccount();
               return true;
           }
           return false;
       }
   }


   class BankingManagement
   {
       static void Main(string[] args)
       {
           Console.WriteLine("How many number of customers do you want to input?");
           int n = Convert.ToInt32(Console.ReadLine());
           BankDetails[] accounts = new BankDetails[n];


           for (int i = 0; i < accounts.Length; i++)
           {
               accounts[i] = new BankDetails();
               accounts[i].OpenAccount();
           }


           int ch;


           do
           {
               Console.WriteLine("\n Banking System Application");
               Console.WriteLine("1. Display all account details");
               Console.WriteLine("2. Search by Account Number");
               Console.WriteLine("3. Deposit the amount");
               Console.WriteLine("4. Withdraw the amount");
               Console.WriteLine("5. Exit");
               Console.Write("Enter your choice: ");
               ch = Convert.ToInt32(Console.ReadLine());


               switch (ch)
               {
                   case 1:
                       for (int i = 0; i < accounts.Length; i++)
                       {
                           accounts[i].ShowAccount();
                       }
                       break;
              
               case 2:
               Console.Write("Enter account no. you want to search");
               string ac_no = Console.ReadLine();
               bool found = false;
               for (int i= 0; i< accounts.Length; i++)
               {
                  found = accounts[i].Search(ac_no);
                  if(found)
                  {
                     break;
                  }
               }
               if (!found)
                {
                    Console.WriteLine("Search failed!");
                }
                break;
           
            case 3:
               Console.Write("Enter Account no: ");
               ac_no = Console.ReadLine();
               found = false;


               for (int i= 0; i<accounts.Length; i++)
               {
                  found = accounts[i].Search(ac_no);
                  if (found)
                  {
                     accounts[i].Deposit();
                     break;
                  }
              
               }
               if (!found)
               {
                  Console.WriteLine("Search failed! Account does not exist!");
               }
               break;
            case 4:
               Console.Write("Enter account no: ");
               ac_no = Console.ReadLine();
               found = false;
               for (int i= 0; i< accounts.Length; i++)
               {
                  found = accounts[i].Search(ac_no);
                  if(found)
                  {
                     accounts[i].Withdrawal();
                     break;
                  }
               }
               if(!found)
               {
                  Console.WriteLine("Account does not exist!");
               }
               break;
            case 5:
               Console.WriteLine("See you soon..");
               break;
            }
         }


            while (ch != 5);
         
       }
   }
}








                      
              


 

