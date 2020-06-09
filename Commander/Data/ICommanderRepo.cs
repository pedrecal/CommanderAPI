using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using commander.Models;

namespace Commander.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAppComands();
        Command GetCommandById(int id);
    }
}
