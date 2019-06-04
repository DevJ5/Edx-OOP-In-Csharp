using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_Lab1
{
    public class ManagedWord : IDisposable
    {
        private bool _isDisposed;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool isDisposing)
        {
            if(_isDisposed)
            {
                return;
            }
            if(isDisposing)
            {
                // Release managed resources
            }
            // Always release unmanaged resources

            _isDisposed = true;
        }

        public void OpenWordDocument(string filePath)
        {
            if(_isDisposed)
            {
                throw new ObjectDisposedException("ManagedWord");
            }
        }
    }
}
