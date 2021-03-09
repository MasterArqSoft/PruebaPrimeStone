using System;

namespace PrimeStone.Core.Interfaces
{
    public interface ILogsService
    {
        void Save(string url, Exception ex);
    }
}
