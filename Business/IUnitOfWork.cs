using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
