using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cr
{
    public class CacheManager : Middleware
    {
        public CacheManager()
        {
        }

        public override void Run(object request)
        {
            Console.WriteLine("Begin CacheManager.");

            next?.Run(request);

            Console.WriteLine("End CacheManager.");
        }
    }

    public static class CacheManagerExtension
    {
        public static Middleware UseCacheManager(this Middleware middleware)
        {
            return middleware.Use(new CacheManager());
        }
    }
}