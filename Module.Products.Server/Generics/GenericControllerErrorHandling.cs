using Microsoft.AspNetCore.Mvc;

namespace Module.Products.Server.Generics;
public static class GenericControllerErrorHandling
{
    public static async Task<ActionResult<TResult>> RunServiceMethod<TResult>(Func<Task<TResult>> serviceMethod)
    {
        try
        {
            TResult result = await serviceMethod();
            return  new OkObjectResult(result);
        }
        catch (Exception exception)
        {
            return new BadRequestObjectResult((exception.InnerException ?? exception).Message);
        }
    }


    public static async Task<ActionResult<TResult>> RunServiceMethod<T,TResult>(Func<T,Task<TResult>> serviceMethod, T parameter)
    {
        try
        {
            TResult result = await serviceMethod(parameter);
            return new OkObjectResult(result);
        }
        catch (Exception exception)
        {
            return new BadRequestObjectResult((exception.InnerException ?? exception).Message);
        }
    }
}