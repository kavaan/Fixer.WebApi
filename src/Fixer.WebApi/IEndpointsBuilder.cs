using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Fixer.WebApi
{
    public interface IEndpointsBuilder
    {
        IEndpointsBuilder Get(string path, Func<HttpContext, Task> context = null);
        IEndpointsBuilder Get<T>(string path, Func<T, HttpContext, Task> context = null) where T : class;
        IEndpointsBuilder Get<T, U>(string path, Func<T, HttpContext, Task> context = null) where T : class;
        IEndpointsBuilder Post(string path, Func<HttpContext, Task> context = null);
        IEndpointsBuilder Post<T>(string path, Func<T, HttpContext, Task> context = null) where T : class;
        IEndpointsBuilder Put(string path, Func<HttpContext, Task> context = null);
        IEndpointsBuilder Put<T>(string path, Func<T, HttpContext, Task> context = null) where T : class;
        IEndpointsBuilder Delete(string path, Func<HttpContext, Task> context = null);
        IEndpointsBuilder Delete<T>(string path, Func<T, HttpContext, Task> context = null) where T : class;
    }
}
