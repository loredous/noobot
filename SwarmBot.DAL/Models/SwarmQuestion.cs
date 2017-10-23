using SwarmBot.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwarmBot.DAL.Models
{
    class SwarmQuestion : ICRUDCapable
    {
        public int? ID { get; private set; }
        public SwarmUser Asker { get; set; }
        public SwarmChannel AskedInChannel { get; set; }

        public bool DeleteFromDatabase()
        {
            throw new NotImplementedException();
        }

        public bool ReadFromDatabase(int ID)
        {
            throw new NotImplementedException();
        }

        public bool WriteToDatabase()
        {
            throw new NotImplementedException();
        }
    }
}
