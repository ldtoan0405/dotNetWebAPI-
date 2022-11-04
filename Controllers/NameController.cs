using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using VsCodeProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace VsCodeProject.Controllers;

[ApiController]
[Route("[controller]")]
public class NameController : ControllerBase
{
    private readonly ILogger<NameController> _logger;

    public NameController(ILogger<NameController> logger)
    {
        _logger = logger;
    }

    public IActionResult Get()
    {
        var PersonName = new Name { PersonName = "Duc Toan Le" };
        return Ok(PersonName);
    }

}
