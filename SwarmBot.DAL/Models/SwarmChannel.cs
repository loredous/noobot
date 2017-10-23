
using SwarmBot.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SwarmBot.DAL.Models
{
    class SwarmChannel : ICRUDInternal
    {
        public int? ID { get; private set; }
        public string SlackChannel { get; set; }
        public string Name { get; set; }

        public string CreateSQL { get { return "INSERT INTO Channels (SlackChannel, Name) VALUES (@SlackChannel, @Name)"; } }

        public string RetrieveSQL { get { return "SELECT ID, SlackChannel, Name FROM Channels"; } }

        public string UpdateSQL { get { return "UPDATE Channels SET Name=@Name, SlackChannel=@SlackChannel WHERE ID=@ID"; } }

        public string DeleteSQL { get { return "DELETE FROM Channels WHERE ID=@ID"; } }

        public SqlParameter[] parameters
        {
            get
            {
                return new SqlParameter[]
                {
                    new SqlParameter("ID", ID.Value),
                    new SqlParameter("SlackChannel", SlackChannel),
                    new SqlParameter("Name",Name)
                };
            }
        }

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
