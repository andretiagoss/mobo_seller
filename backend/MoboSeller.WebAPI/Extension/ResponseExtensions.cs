using Microsoft.AspNetCore.Mvc;
using MoboSeller.Application.Comunication;
using System.Net;

namespace MoboSeller.WebAPI.Extension
{
    public static class ResponseExtensions
    {
        public static IActionResult ToHttpResponse<TData>(this Result<TData> result)
        {
            if (result.StatusCode == HttpStatusCode.BadRequest)
                return new ObjectResult(new { result.Errors }) { StatusCode = (int)result.StatusCode };

            if (result.StatusCode == HttpStatusCode.InternalServerError)
                return new ObjectResult(null) { StatusCode = (int)result.StatusCode };

            if (result.StatusCode == HttpStatusCode.NotFound)
                return new ObjectResult(new { result.Data, result.Errors }) { StatusCode = (int)result.StatusCode };

            return new ObjectResult(new { result.Data, result.Errors }) { StatusCode = (int)result.StatusCode };
        }
    }
}
