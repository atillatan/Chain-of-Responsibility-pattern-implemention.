using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cr
{
    public abstract class Middleware
    {
        protected Middleware next;

        public Middleware Use(Middleware middleware)
        {
            this.next = middleware;
            return middleware;
        }

        public abstract void Run(object request);
    }
}