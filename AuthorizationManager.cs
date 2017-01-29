using System;

namespace cr
{
    public class AuthorizationManager : Middleware
    {
        public AuthorizationManager()
        {
        }

        public override void Run(object request)
        {
            Console.WriteLine("Begin AuthorizationManager.");

            next?.Run(request);

            Console.WriteLine("End AuthorizationManager.");
        }
    }
}