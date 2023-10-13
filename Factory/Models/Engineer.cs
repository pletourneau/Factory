using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Factory.Models
{
  public class Engineer
  {
    [Required(ErrorMessage = "* Engineer name cannot be empty.")]
    public string Name { get; set; }
    public int EngineerId { get; set; }

    // Collection Navigation Property
    public List<MachineEngineer> JoinEntities { get; set; }
  }
}