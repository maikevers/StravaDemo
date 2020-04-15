using CSharpFunctionalExtensions;
using Microsoft.AspNetCore.Mvc;

namespace StravaDemo.Controllers
{
    public class BaseController : ControllerBase
    {
        protected IActionResult FromResult(Result result)
        {
            return result.IsSuccess ? Ok() : BadRequest(result.Error) as IActionResult;
        }

        protected IActionResult FromResult<T>(Result<T> result)
        {
            return result.IsSuccess ? Ok(result.Value) : BadRequest(result.Error) as IActionResult;
        }
    }
}
