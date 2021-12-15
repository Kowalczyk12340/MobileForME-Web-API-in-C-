using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mobile4MEWebApi.Entities
{
  public class Mobile
  {
    [Key]
    public int? Id { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public decimal EngageCapacity { get; set; }
    public int ProductionYear { get; set; }
    public int? CreatedById { get; set; }
    public virtual User CreatedBy { get; set; }
    public int UserId { get; set; }
    public virtual User User { get; set; }
    public virtual ICollection<Part> Parts { get; set; }
  }
}