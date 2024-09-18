namespace ExpenseTracker.Middlewares;

public class ExceptionHandlerMiddleware : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            await next(context);
        }
        catch (Exception ex)
        {
            await HandlerAsync(context, ex);
        }
    }

    private static async Task HandlerAsync(HttpContext context, Exception exception)
    {
        context.Response.StatusCode = 500;
        await context.Response.WriteAsync("Something went wrong.");
    }
}
