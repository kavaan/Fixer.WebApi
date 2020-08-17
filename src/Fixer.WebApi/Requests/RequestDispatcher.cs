using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Fixer.WebApi.Requests
{
    public class RequestDispatcher : IRequestDispatcher
    {
        private readonly IServiceScopeFactory _serviceFactory;

        public RequestDispatcher(IServiceScopeFactory serviceFactory)
        {
            _serviceFactory = serviceFactory;
        }

        public Task<TResult> DispatchAsync<TRequest, TResult>(TRequest request) where TRequest : class, IRequest
        {
            using (var scope = _serviceFactory.CreateScope())
            {
                var handler = scope.ServiceProvider.GetRequiredService<IRequestHandler<TRequest, TResult>>();

                return handler.HandleAsync(request);
            }
        }
    }
}
