using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cr
{
    public class Program
    {
        private static AppBuilder app = new AppBuilder();

        public static void Main(string[] args)
        {
            app.Use(new LogManager())
               .Use(new AuthorizationManager())
               .UseCacheManager();

            //Run 1
            app.Run("data");
        }
    }
}