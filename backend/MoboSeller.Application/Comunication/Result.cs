using Flunt.Notifications;
using System.Collections.Generic;
using System.Net;

namespace MoboSeller.Application.Comunication
{
    public class Result<TData>
    {
        public HttpStatusCode StatusCode { get; }
        public TData Data { get; }
        public object Errors { get; }

        public Result(HttpStatusCode statusCode, TData data)
        {
            Data = data;
            StatusCode = statusCode;
        }

        public Result(IList<Notification> errors)
        {
            Errors = errors;
            StatusCode = HttpStatusCode.OK;
        }

        public Result(IReadOnlyCollection<Notification> errors)
        {
            Errors = errors;
            StatusCode = HttpStatusCode.OK;
        }

        public Result(Notification error)
        {
            Errors = new List<Notification>() { error };
            StatusCode = HttpStatusCode.OK;
        }
    }

    public class Result : Result<object>
    {
        public Result(HttpStatusCode statusCode, object data)
            : base(statusCode, data) { }

        public Result(IList<Notification> errors)
            : base(errors) { }

        public Result(IReadOnlyCollection<Notification> errors)
           : base(errors) { }

        public Result(Notification error)
            : base(error) { }

        public Result(HttpStatusCode statusCode, ResultMessage resultMessage)
            : base(statusCode, resultMessage) { }
    }

    public class ResultMessage
    {
        public string Id { get; set; }
        public string Message { get; set; }

        public ResultMessage(string message)
        {
            this.Message = message;
        }

        public ResultMessage(string id, string message)
        {
            this.Id = id;
            this.Message = message;
        }
    }
}
