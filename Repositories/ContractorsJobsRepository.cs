using System.Data;

namespace contractor.Repositories
{
  public class ContractorsJobsRepository
  {
    private readonly IDbConnection _db;

    public ContractorsJobsRepository(IDbConnection db)
    {
      _db = db;
    }

    // TODO GetAll

    // TODO GetById

    // TODO GetJobsByContractorId (GetContractorsJobs) Need a get for get all jobs by the contractors Id this needs the dependancy from cjService since we are sending this through the cjService

    // TODO Create

    // TODO Put

    // TODO Delete
  }
}