using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }
    [Required(ErrorMessage = "* The Machine name can't be empty.")]
    public string MachineName { get; set; }
    [Required(ErrorMessage = "* The Course Number can't be empty.")]
    
    // Collection Navigation Property
    public List<MachineEngineer> JoinEntities { get; set; }
  }
}