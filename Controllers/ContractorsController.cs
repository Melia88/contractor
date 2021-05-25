using contractor.Services;
using Microsoft.AspNetCore.Mvc;

namespace contractor.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ContractorsController : ControllerBase
  {
    public readonly ContractorsService _cService;
    public readonly ContractorsJobsService _cjService;

    public ContractorsController(ContractorsService cService, ContractorsJobsService cjService)
    {
      _cService = cService;
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