using SwarmBot.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwarmBot.DAL.Models
{
    class SwarmUser : ICRUDInternal
    {
        public int? ID { get; private set; }
        public string SlackUser { get; set; }
        public string UserName { get; set; }

        public string CreateSQL => throw new NotImplementedException();

        public string RetrieveSQL => throw new NotImplementedException();

        public string UpdateSQL => throw new NotImplementedException();

        public string DeleteSQL => throw new NotImplementedException();

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
