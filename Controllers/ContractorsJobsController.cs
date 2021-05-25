using contractor.Services;
using Microsoft.AspNetCore.Mvc;

namespace contractor.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ContractorsJobsController : ControllerBase
  {
    private readonly ContractorsJobsService _cjService;

    public ContractorsJobsController(ContractorsJobsService cjService)
    {
      _cjService = cjService;
    }

    // TODO GetAll

    // TODO GetById

    // TODO GetJobsByContractorId (GetContractorsJobs) Need a get for get all jobs by the contractors Id this needs the dependancy from cjService since we are sending this through the cjService

    // TODO Create

    // TODO Put

    // TODO Delete

  }
}