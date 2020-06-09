using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command{id = 0, HowTo = "Light a fire", Line = "Get a lighter", Plataform = "Anywhere"},
                new Command{id = 1, HowTo = "Get water", Line = "Open the tap", Plataform = "Sink"},
                new Command{id = 2, HowTo = "Cry", Line = "Go to the shower", Plataform = "Bathroom"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command(id = 0, HowTo = "Light a fire", Line = "Get a lighter", Plataform = "Anywhere");
        }
    }
}