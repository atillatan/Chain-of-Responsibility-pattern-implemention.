using System;

namespace cr
{
    public class AppBuilder : Middleware
    {
        public AppBuilder()
        {
        }

        public override void Run(object request)
        {
            Console.WriteLine("Begin AppBuilder.");

            next?.Run(request);

            Console.WriteLine("End AppBuilder.");

            Console.ReadKey();
        }
    }
}