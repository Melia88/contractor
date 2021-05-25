using System;

namespace contractor.Models
{
  public class Contractor
  {
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public string Name { get; set; }
    public string Skill { get; set; }
  }
}