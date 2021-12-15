using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mobile4MEWebApi.Entities
{
  public class Part
  {
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Manufacturer { get; set; }
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",ApplyFormatInEditMode = true)]
    [DataType(DataType.Date)]
    public DateTime Date { get; set; }
    public decimal Price { get; set; }
    public decimal BikeHours { get; set; }
    
    public int BelongsToMobileId { get; set; }
    public virtual Mobile BelongsTo { get; set; }
    public int MobileId { get; set; }
    public virtual Mobile Mobile { get; set; }
  }
}
