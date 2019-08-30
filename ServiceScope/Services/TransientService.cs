using System;

namespace ServiceScope.Services
{
    public interface ITransientService : IService { }

    public class TransientService : ITransientService
    {
        private string _guid;

        public TransientService()
        {
            _guid = Guid.NewGuid().ToString();
        }

        public string GetGuid()
        {
            return _guid;
        }
    }
}
