using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using CleaningServiceManagement.Models;

namespace CleaningServiceManagement.Services
{
    public static class DatabaseService
    {
        private static SqlConnection _connection;
        private static readonly string ConnectionString =
            ConfigurationManager.ConnectionStrings["CleaningServiceDB"].ConnectionString;

        public static void Initialize()
        {
            _connection = new SqlConnection(ConnectionString);
            TestConnection();
        }

        private static void TestConnection()
        {
            try
            {
                _connection.Open();
                _connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception($"Database connection failed: {ex.Message}");
            }
        }

        public static User ValidateUser(string email, string password)
        {
            const string query = @"
                SELECT UserId, Name, Role 
                FROM Users 
                WHERE Email = @Email AND PasswordHash = HASHBYTES('SHA2_256', @Password)";

            using (var cmd = new SqlCommand(query, _connection))
            {
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);

                _connection.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new User
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Role = reader.GetString(2)
                        };
                    }
                }
                _connection.Close();
            }
            return null;
        }

        public static DataTable GetClientBookings(int clientId)
        {
            var table = new DataTable();
            const string query = @"
                SELECT BookingId, ServiceType, Date, Status 
                FROM Bookings 
                WHERE ClientId = @ClientId";

            using (var adapter = new SqlDataAdapter(query, _connection))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@ClientId", clientId);
                adapter.Fill(table);
            }
            return table;
        }

        public static void Cleanup()
        {
            if (_connection?.State != ConnectionState.Closed)
                _connection?.Close();
            _connection?.Dispose();
        }
    }
}
