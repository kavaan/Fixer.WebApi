using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Fixer.WebApi.Requests
{
    public interface IRequestDispatcher
    {
        Task<TResult> DispatchAsync<TRequest, TResult>(TRequest request) where TRequest : class, IRequest;
    }
}
