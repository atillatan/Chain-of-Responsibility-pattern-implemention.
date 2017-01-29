using System;

namespace cr
{
    internal class LogManager : Middleware
    {
        public LogManager()
        {
        }

        public override void Run(object request)
        {
            Console.WriteLine("Begin LogManager.");

            next?.Run(request);

            Console.WriteLine("End LogManager.");
        }
    }
}