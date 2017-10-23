using System;
using System.Collections.Generic;
using System.Text;

namespace SwarmBot.DAL.Interfaces
{
    public interface ICRUDCapable
    {
        int? ID { get; }

        bool WriteToDatabase();
        bool ReadFromDatabase(int ID);
        bool DeleteFromDatabase();
    }

    internal interface ICRUDInternal : ICRUDCapable
    {
        string CreateSQL { get; }
        string RetrieveSQL { get; }
        string UpdateSQL { get; }
        string DeleteSQL { get; }
        System.Data.SqlClient.SqlParameter[] parameters { get; }
    }

}
