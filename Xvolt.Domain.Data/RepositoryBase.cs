using System.Collections.Generic;
using Xvolt.Domain.Repositories;

namespace Xvolt.Domain.Data
{
    public abstract class RepositoryBase
    {
        #region Disposable

        private bool _disposed;
        public virtual void Dispose()
        {
            Dispose(_disposed);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                // TODO
            }

            _disposed = true;
        }
        #endregion
    }
}