using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStreaming.Infraestructure.Data.Entity.Contract
{
    public enum State
    {
        Added,
        Unchanged,
        Modified,
        Deleted
    }

    public interface IObjectWithState
    {
        State State { get; set; }
    }
}
