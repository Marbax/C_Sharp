using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptions
{
    class Test_final : IDisposable
    {
        public string Name { get; set; }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        private void ReleaseUnmanagmentResources()
        {
            Console.WriteLine("ReleaseUnmanagmentResources");
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                    Console.WriteLine(" dispose managed state (managed objects).");
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                ReleaseUnmanagmentResources();
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        ~Test_final()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(false);
            Console.WriteLine("finnalize");
            Console.WriteLine("GC");

        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            GC.SuppressFinalize(this);
            Console.WriteLine("self");

        }
        #endregion
    }
}
