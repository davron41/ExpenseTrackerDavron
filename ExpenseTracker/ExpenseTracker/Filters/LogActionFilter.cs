using Microsoft.AspNetCore.Mvc.Filters;

namespace ExpenseTracker.Filters;

public class LogActionFilter : IActionFilter
{
    public void OnActionExecuted(ActionExecutedContext context)
    {
    }

    public void OnActionExecuting(ActionExecutingContext context)
    {
        var controller = context.Controller.GetType().Name;
        var action = context.ActionDescriptor.DisplayName;

        Console.WriteLine($"Controller: {controller}\n Action: {action}");
    }
}
