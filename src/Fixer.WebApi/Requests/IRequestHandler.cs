using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Fixer.WebApi.Requests
{
    public interface IRequestHandler<in TRequest, TResult> where TRequest : class, IRequest
    {
        Task<TResult> HandleAsync(TRequest request);
    }
}
