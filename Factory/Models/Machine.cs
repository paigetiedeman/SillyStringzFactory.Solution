using System.Collections.Generic;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.JoinEntities = new HashSet<MachineEngineer>();
    }

    public int MachineID { get; set; }
    public string MachineName { get; set; }
    public string Status { get; set; }
    public virtual ICollection<MachineEngineer> JoinEntities { get; set; }
  }
}