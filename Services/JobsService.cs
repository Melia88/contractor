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

    // GetAll

    public List<Job> GetAll()
    {
      return _repo.GetAll();
    }

    // GetById
    public Job GetById(int id)
    {
      Job job = _repo.GetById(id);
      if (job == null)
      {
        throw new Exception("Invalid Job Id");
      }
      return job;
    }

    // Create
    public Job CreateJob(Job newJob)
    {
      return _repo.Create(newJob);
    }

    // TODO Put
    public Job UpdateJob(Job update)
    {
      Job original = GetById(update.Id);
      original.Name = update.Name.Length > 0 ? update.Name : original.Name;
      original.Description = update.Description.Length > 0 ? update.Description : original.Description;
      original.Location = update.Location.Length > 0 ? update.Location : original.Location;
      original.Salary = update.Salary > 0 ? update.Salary : original.Salary;

      if (_repo.UpdateJob(original))
      {
        return original;
      }
      throw new Exception("Something went wrong??");
    }

    // Delete
    public void Delete(int id)
    {
      Job job = GetById(id);
      if (!_repo.Delete(id))
      {
        throw new Exception("Something has gove VERY wrong!");
      }
    }










  }
}