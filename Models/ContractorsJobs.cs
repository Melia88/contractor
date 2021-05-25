using System.ComponentModel.DataAnnotations;

namespace contractor.Models
{
  public class ContractorsJobs
  {
    public int Id { get; set; }
    [Required]
    public int ProductId { get; set; }
    [Required]
    public int WarehouseId { get; set; }

  }
  public class ContractorsJobsViewModel : Job
  {

    public int ContractorId { get; set; }
    public int JobId { get; set; }
    public int ContractorsJobsId { get; set; }
    public string ContractorName { get; set; }
    public string Skill { get; set; }

  }

}