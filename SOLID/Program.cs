using System;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            // SOLID
        }
        

        // Bad Example
        public class SendEmail
        {
            public bool SendEmailForX(string input, string mailAddress)
            {
                if (!IsMailAddressValid(mailAddress))
                {
                    return false;
                }
                return true;
            }

            private bool IsMailAddressValid(string mailAddress)
            {
                // doSomething
                return true;
            }
        }
    }
}