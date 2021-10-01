using System;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            // SOLID
        }


        /*// Bad Example
        public class SendEmail
        {
            public bool SendEmailForX(string input, string mailAddress)
            {
                return IsMailAddressValid(mailAddress);
            }

            private bool IsMailAddressValid(string mailAddress)
            {
                // doSomething
                return true;
            }
        }*/

        // Good Example
        public class MailAddressValid
        {
            public bool IsMailAddressValid(string mailAddress)
            {
                // doSomething
                return true;
            }
            
        }

        public class SendEmail
        {
            public MailAddressValid validation { get; set; } = new MailAddressValid();
            public bool SendEmailForX(string input, string mailAddress)
            {
                if (!validation.IsMailAddressValid(mailAddress))
                {
                    return false;
                }
                // doSomething
                return true;
            }
        }
    }
}