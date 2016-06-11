using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collector_Dispose 
{
    class Calculator : IDisposable
    {

        private bool disposed = false;

        // Constructor
        public Calculator()
        {
            Console.WriteLine("Calculator being created");
        }

        // public Divide Method
        public int Divide(int first, int second)
        {
            return first / second;
        }

        // Destructor
        ~Calculator()
        {
            this.Dispose();
            Console.WriteLine("Calculator being finalized");
        }

        public void Dispose()
        {
            if(!disposed)
                Console.WriteLine("Calculator being disposed");
            this.disposed = true;
            GC.SuppressFinalize(this);
        }
        
    }
}
