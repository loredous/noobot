using SwarmBot.DAL.Interfaces;
using System;


namespace SwarmBot.DAL
{
    public class DALBase
    {
        private static DALBase DALInstance = null;
        private static object LockObject = new object();
        private bool isInitialized = false;
        private System.Data.SqlClient.SqlConnection DBConnection;

        private DALBase()
        {

        }

        private void Initialize()
        {
            DBConnection = new System.Data.SqlClient.SqlConnection();
        }

        internal static bool SaveObject(ICRUDInternal dbObject)
        {
            
        }

        /// <summary>
        /// Returns an instance of the DAL to ensure only a single instance exists at all times
        /// </summary>
        /// <returns>A singleton instance of the DAL</returns>
        public static DALBase GetInstance()
        {
            if (DALInstance == null)
            {
                lock (LockObject)
                {
                    if (DALInstance == null)
                    {
                        DALInstance = new DALBase();
                    }
                }
            }
                return DALInstance;
        }
    }
}
