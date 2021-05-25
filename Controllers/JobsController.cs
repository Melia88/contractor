using System;
using System.Collections.Generic;
using contractor.Models;
using contractor.Services;
using Microsoft.AspNetCore.Mvc;

namespace contractor.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class JobsController : ControllerBase
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
        List<Job> jobs = _jService.GetAll();
        return Ok(jobs);
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }


    // TODO GetById
    [HttpGet("{id}")]
    public ActionResult<Job> GetById(int id)
    {
      try
      {
        Job found = _jService.GetById(id);
        return Ok(found);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    // TODO Create
    [HttpPost]
    public ActionResult<Job> CreateJob([FromBody] Job newJob)
    {
      try
      {
        Job job = _jService.CreateJob(newJob);
        return Ok(job);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    // TODO Put
    [HttpPut("{id}")]
    public ActionResult<Job> Update([FromBody] Job update)
    {
      try
      {
        Job job = _jService.UpdateJob(update);
        return Ok(job);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    // TODO Delete
    [HttpDelete("{id}")]
    public ActionResult<Job> Delete(int id)
    {
      try
      {
        _jService.Delete(id);
        return Ok("Succesfully Deleted");
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}