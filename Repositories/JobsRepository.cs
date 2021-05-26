using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using contractor.Models;
using Dapper;

namespace contractor.Repositories
{
  public class JobsRepository
  {
    private readonly IDbConnection _db;

    public JobsRepository(IDbConnection db)
    {
      _db = db;
    }
    // GetAll
    internal List<Job> GetAll()
    {
      string sql = "SELECT * FROM jobs";
      return _db.Query<Job>(sql).ToList();
    }

    // GetById
    internal Job GetById(int id)
    {
      string sql = @"
      SELECT 
      j.*
      FROM jobs j 
      WHERE id = @id";
      return _db.QueryFirstOrDefault<Job>(sql, new { id });
    }

    // Create
    internal Job Create(Job newJob)
    {
      string sql = @"
      INSERT INTO jobs 
      (name, description, location, salary)
      VALUES
      (@Name, @Description, @Location, @Salary);
      SELECT LAST_INSERT_ID()";
      newJob.Id = _db.ExecuteScalar<int>(sql, newJob);
      return newJob;
    }
    // TODO Put
    internal bool UpdateJob(Job original)
    {
      string sql = @"
      SET 
        name = @Name,
        description = @Description,
        location = @Location,
        salary = @Salary
        WHERE id = @id;";
      int affectedRows = _db.Execute(sql, original);
      return affectedRows == 1;
    }
    // Delete
    internal bool Delete(int id)
    {
      string sql = "DELETE FROM jobs WHERE id = @id LIMIT 1";
      int affectedRows = _db.Execute(sql, new { id });
      return affectedRows == 1;
    }
  }
}