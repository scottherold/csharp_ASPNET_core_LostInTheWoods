using System;
using System.Collections.Generic;
using System.Data;
using LostInTheWoods.Models;
using MySql.Data.MySqlClient;
using Dapper;
using System.Linq;
using Microsoft.Extensions.Options;

namespace LostInTheWoods.Factories {
    public class TrailFactory 
    {
        private MySqlOptions _options;
        public TrailFactory(IOptions<MySqlOptions> config)
        {
            _options = config.Value;
        }
        internal IDbConnection Connection
        {
            get
            {
                return new MySqlConnection(_options.ConnectionString);
            }
        }
        public void AddNewTrail(Trail trail)
        {
            using (IDbConnection dbConnection = Connection)
            {
                // Queries the DB to insert the form data.
                string query = "INSERT INTO trails (name, description, length, elevation, longitude, latitude, created_at) VALUES (@Name, @Description, @Length, @Elevation, @Longitude, @Latitude, NOW())";
                dbConnection.Open();
                dbConnection.Execute(query, trail);
            }
        }
        public List<Trail> GetAllTrails()
        {
            using (IDbConnection dbConnection = Connection)
            {
                using(IDbCommand command = dbConnection.CreateCommand())
                {
                    string query = "SELECT * FROM trails";
                    dbConnection.Open();
                    return dbConnection.Query<Trail>(query).ToList();
                }
            }
        }
        public List<Trail> GetAllTrailsByLength()
        {
            using (IDbConnection dbConnection = Connection)
            {
                using(IDbCommand command = dbConnection.CreateCommand())
                {
                    string query = "SELECT * FROM trails ORDER BY length DESC";
                    dbConnection.Open();
                    return dbConnection.Query<Trail>(query).ToList();
                }
            }
        }
                public List<Trail> GetAllTrailsByElevation()
        {
            using (IDbConnection dbConnection = Connection)
            {
                using(IDbCommand command = dbConnection.CreateCommand())
                {
                    string query = "SELECT * FROM trails ORDER BY elevation DESC";
                    dbConnection.Open();
                    return dbConnection.Query<Trail>(query).ToList();
                }
            }
        }
        public Trail TrailFind(int trailId)
        {
            using(IDbConnection dbconnection = Connection)
            {
                string query = "SELECT * FROM trails WHERE trail_id = @ID";
                var arg = new {ID=trailId};
                
                dbconnection.Open();
                var result = dbconnection.Query<Trail>(query, arg);
                return result.FirstOrDefault();
            }
        }
    }
}