using System;
using System.Collections.Generic;
using contractor.Models;
using contractor.Services;
using Microsoft.AspNetCore.Mvc;

namespace contractor.Controllers
{
  public class JobsController
  {
    private readonly JobsService _jService;

    public JobsController(JobsService jService)
    {
      _jService = jService;
    }

    // TODO GetAll
    [HttpGet]
    public ActionResult<List<Job>> GetAll()
    {
      try
      {

      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }


    // TODO GetById

    // TODO Create

    // TODO Put

    // TODO Delete

  }
}