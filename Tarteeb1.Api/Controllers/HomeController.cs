//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free to use to bring order in your workplace
//==================================================

using Microsoft.AspNetCore.Mvc;

namespace Tarteeb1.Api.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]

    public class HomeController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> GetHomeMessage() => "Tarteeb is running...";
    }
}