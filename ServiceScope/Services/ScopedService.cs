using System;

namespace ServiceScope.Services
{
    public interface IScopedService : IService { }

    public class ScopedService : IScopedService
    {
        private readonly string _guid;

        public ScopedService()
        {
            _guid = Guid.NewGuid().ToString();
        }

        public string GetGuid()
        {
            return _guid;
        }
    }
}
