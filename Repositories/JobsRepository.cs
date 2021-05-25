using System.Data;

namespace contractor.Repositories
{
  public class JobsRepository
  {
    private readonly IDbConnection _db;

    public JobsRepository(IDbConnection db)
    {
      _db = db;
    }
    // TODO GetAll

    // TODO GetById

    // TODO Create

    // TODO Put

    // TODO Delete5
  }
}