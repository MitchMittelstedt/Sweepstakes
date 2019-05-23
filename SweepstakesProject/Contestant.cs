using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class Contestant
    {
        //HAS
        string firstName;
        string lastName;
        string email;
        public int registrationNo;


        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("First name of contestant cannot be null.");
                }
                else
                {
                    firstName = value;
                }
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Last name of contestant cannot be null.");
                }
                else
                {
                    lastName = value;
                }
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
        }


        //CONSTRUCTOR

        public Contestant()
        {
            registrationNo = 0;
            EnterInfo();
        }
        //DOES

        public void EnterInfo()
        {
            Console.WriteLine("Please enter your first name.");
            firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name.");
            lastName = Console.ReadLine();
            Console.WriteLine("Please enter your email.");
            email = Console.ReadLine();
            registrationNo++;
        }
    }
}
