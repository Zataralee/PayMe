using System;
using System.Collections.Generic;
using System.Reactive;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

public class PaymentDatabase
{
    public string host { get; set; }
    public uint port { get; set; }
    public string userName { get; set; }
    public string password { get; set; }
    public string database { get; set; }

    public PaymentDatabase(string host="localhost", uint port=0, string userName="", string password="", string database="")
    {
        this.host = host;
        this.port = port;
        this.userName = userName;
        this.password = password;
        this.database = database;
    }

    public void Initialize()
    {
        using (var conn = new NpgsqlConnection($"Host={host};Port={port};Username={userName};Password={password};Database={database}"))
        {
            try
            {
                conn.Open();

                // Check if the table exists
                if (!TableExists(conn, "paymentdata"))
                {
                    // If the table doesn't exist, create it
                    CreateTable(conn, typeof(PaymentData));
                }
                if (!TableExists(conn, "playerdata"))
                {
                    // If the table doesn't exist, create it
                    CreateTable(conn, typeof(PlayerData));
                }
                if (!TableExists(conn, "rewardsdata"))
                {
                    // If the table doesn't exist, create it
                    CreateTable(conn, typeof(RewardsData));
                }
                // Execute other queries or operations as needed
            }
            catch (Exception e)
            {
                throw new ApplicationException($"Error initializing the database. {e.Message}", e);
            }
        }
    }

    public List<T> GetDataFromTable<T>()
    {
        List<T> data = new List<T>();

        Type type = typeof(T);
        var tableName = type.Name;

        using (var conn = new NpgsqlConnection($"Host={host};Port={port};Username={userName};Password={password};Database={database}"))
        {
            try
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand($"SELECT * FROM {tableName}", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        T rowData = CreateInstance<T>(reader);
                        data.Add(rowData);
                    }
                }
            }
            catch (Exception e)
            {
                throw new ApplicationException($"Error retrieving data from {tableName}.", e);
            }
        }

        return data;
    }

    private T CreateInstance<T>(NpgsqlDataReader reader)
    {
        Type type = typeof(T);
        T instance = Activator.CreateInstance<T>();

        foreach (var property in type.GetProperties())
        {
            if (reader[property.Name] != DBNull.Value)
            {
                property.SetValue(instance, reader[property.Name]);
            }
        }

        return instance;
    }

    private bool TableExists(NpgsqlConnection conn, string tableName)
    {
        using (var cmd = new NpgsqlCommand($"SELECT EXISTS (SELECT FROM information_schema.tables WHERE table_name = '{tableName}')", conn))
        {
            return (bool)cmd.ExecuteScalar();
        }
    }

    private void CreateTable(NpgsqlConnection conn, Type tableType)
    {
        if (!tableType.IsClass)
        {
            throw new ArgumentException("tableType must be a class.");
        }

        var tableName = tableType.Name;

        using (var cmd = new NpgsqlCommand($"CREATE TABLE IF NOT EXISTS {tableName} (", conn))
        {
            foreach (var property in tableType.GetProperties())
            {
                var propertyName = property.Name;
                var propertyType = GetPostgresType(property.PropertyType);

                cmd.CommandText += $"{propertyName} {propertyType}, ";
            }

            // Remove the trailing comma and add the primary key
            cmd.CommandText = cmd.CommandText.TrimEnd(',', ' ') + $", PRIMARY KEY (id));";
//            MessageBox.Show($"table create string: {cmd.CommandText}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmd.ExecuteNonQuery();
        }
    }

    private string GetPostgresType(Type propertyType)
    {
        // Map C# data types to PostgreSQL data types
        if (propertyType == typeof(int))
            return "integer";
        else if (propertyType == typeof(string))
            return "text";
        else if (propertyType == typeof(UInt64))
            return "numeric";
        else if (propertyType == typeof(Guid))
            return "uuid";
        else if (propertyType == typeof(DateTime))
            return "timestamp";
        else if (propertyType == typeof(bool))
            return "bool";
        // Add more type mappings as needed

        throw new ArgumentException($"Unsupported property type: {propertyType.Name}");
    }
}

// each class HAS to have an 'id' field to use as a primary key for the table
public class PaymentData
{
    public Guid id { get; set; }
    public string name { get; set; }
    public UInt64 ownerId { get; set; }
    public DateTime triggerDate { get; set; }
    public DateTime expireDate { get; set; }
    public bool claimed { get; set; }
    public DateTime claimDate { get; set; }

    // Add more properties as needed
}

public class PlayerData
{
    public UInt64 id { get; set; } // Steam ID
    public UInt64 discordID { get; set; }
    // Add more properties as needed
}

public class RewardsData
{
    public Guid id { get; set; }
    public string name { get; set; }
    public string discordLevel { get; set; }
    public string command { get; set; }
    public DateTime expireDate { get; set; }
    public DateTime triggerDate { get; set; }
}

