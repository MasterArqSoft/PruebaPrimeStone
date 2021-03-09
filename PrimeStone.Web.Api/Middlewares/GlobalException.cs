using Microsoft.AspNetCore.Http;
using PrimeStone.Core.Exceptions;
using PrimeStone.Core.Interfaces;
using PrimeStone.Web.Api.Responses;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace PrimeStone.Web.Api.Middlewares
{
    public class GlobalException
    {
        private readonly RequestDelegate _next;
        private readonly ILogsService _logs;

        public GlobalException(RequestDelegate next, ILogsService logs)
        {
            _next = next;
            _logs = logs;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context).ConfigureAwait(false);
            }
            catch (Exception error)
            {
                var response = context.Response;
                response.ContentType = "application/json";
                var responseModel = new ApiResponse<string>() { Succeeded = false, Message = error?.Message };
                response.StatusCode = error switch
                {
                    CoreException => (int)HttpStatusCode.BadRequest,
                    KeyNotFoundException => (int)HttpStatusCode.NotFound,
                    _ => (int)HttpStatusCode.InternalServerError,
                };

                _logs.Save(context.Request.Path, error);
                var result = JsonSerializer.Serialize(responseModel);

                await response.WriteAsync(result).ConfigureAwait(false);
            }
        }
    }
}
