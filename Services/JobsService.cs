using System;
using System.Collections.Generic;
using contractor.Models;
using contractor.Repositories;

namespace contractor.Services
{
  public class JobsService
  {
    private readonly JobsRepository _repo;

    public JobsService(JobsRepository repo)
    {
      _repo = repo;
    }

    // TODO GetAll
    internal List<Job> GetAll()
    {
      return _repo.GetAll();
    }

    // TODO GetById
    internal Job GetById(int id)
    {
      throw new NotImplementedException();
    }

    // TODO Create
    internal Job CreateJob(Job newJob)
    {
      throw new NotImplementedException();
    }

    // TODO Put
    internal Job UpdateJob(Job update)
    {
      throw new NotImplementedException();
    }

    // TODO Delete
    internal void Delete(int id)
    {
      throw new NotImplementedException();
    }










  }
}