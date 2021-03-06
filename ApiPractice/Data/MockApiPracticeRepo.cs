﻿using ApiPractice.Models;
using System.Collections.Generic;

namespace ApiPractice.Data
{
    public class MockApiPracticeRepo : IApiPracticeRepo //implementation of the interface repo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Boil an Egg", Line = "Boil Water", Platform = "Kettle and Pan" },
                new Command { Id = 1, HowTo = "Fry an Egg", Line = "Oil Pan", Platform = "Pan" },
                new Command { Id = 2, HowTo = "Make a Brew", Line = "Put teabag in cup", Platform = "Kettle and cup" }
            };

            return commands;
        }                         
                                  
        public Command GetCommandById(int Id)
        {
            return new Command { Id = 0, HowTo = "Boil an Egg", Line = "Boil Water", Platform = "Kettle and Pan" };
        }

        void IApiPracticeRepo.CreateCommand(Command cmd) //the two not implemented were made later just put them here to avoid errors
        {                                                //this is no longer in use just an example
            throw new System.NotImplementedException();
        }

        void IApiPracticeRepo.DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        bool IApiPracticeRepo.SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        void IApiPracticeRepo.UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}
