using System.Collections.Generic;
using Api.Models;
using Commander.Data;

namespace Api.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command> {
                new Command { Id= 0, HowTo="Boil and egg", Line="boild water", Platform= "kettle" },
                new Command { Id= 1, HowTo="cut bread", Line="boild water", Platform= "knife a choppong board" },
                new Command { Id= 2, HowTo="Make a cup a tea", Line="boild water", Platform= "kettle" }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id= 0, HowTo="Boil and egg", Line="boild water", Platform= "kettle" };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}