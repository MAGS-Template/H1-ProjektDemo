using Domain_Models;
using Npgsql;
using System.Buffers;
using System;
using BlazorApp.Components.Pages;

namespace BlazorApp.Services
{
    public class DatabaseService
    {
        public string connectionString;

        public List<Vehicle> allVehicles { get; private set; }

        public DatabaseService(string connectionString) { this.connectionString = connectionString; this.allVehicles = GetAllVehicles(); }
        private List<Vehicle> GetAllVehicles()
        {
            List<Vehicle> allCars = new List<Vehicle>();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT id, Brand, Model, Year, Color, HorsePower, NumberOfDoors, array_to_string(ListOfAdditionalEquipment, ',') as ListOfAdditionalEquipment, BatteryCapacity, Range, NumberOfCylinders, array_to_string(Images, ',') as Images, ImageFolderPath, Type FROM vehicles";

                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string type = reader?["type"].ToString();
                            if (type == "EVCar")
                            {
                                allCars.Add(new EVCar(
                                        reader["Brand"].ToString(),
                                        reader["Model"].ToString(),
                                        Convert.ToInt32(reader["Year"]),
                                        reader["Color"].ToString(),
                                        Convert.ToInt32(reader["HorsePower"])
                                    )
                                {
                                    Id = Convert.ToInt32(reader["id"]),
                                    url = $"car/{Convert.ToInt32(reader["id"])}",
                                    numberOfDoors = Convert.ToInt32(reader["NumberOfDoors"]),
                                    listOfAdditionalEquipment = reader["ListOfAdditionalEquipment"].ToString().Split(',').ToList(),
                                    batteryCapacity = Convert.ToInt32(reader["BatteryCapacity"]),
                                    range = Convert.ToInt32(reader["Range"]),
                                    images = reader["images"].ToString().Split(',').ToList(), // Split the string after removing curly braces
                                    imageFolderPath = reader["imagefolderpath"].ToString()

                                });
                            }
                            else if (type == "PetrolCar")
                            {
                                allCars.Add(new PetrolCar(
                                        reader["Brand"].ToString(),
                                        reader["Model"].ToString(),
                                        Convert.ToInt32(reader["Year"]),
                                        reader["Color"].ToString(),
                                        Convert.ToInt32(reader["HorsePower"])
                                    )
                                {
                                    Id = Convert.ToInt32(reader["id"]),
                                    url = $"car/{Convert.ToInt32(reader["id"])}",
                                    numberOfDoors = Convert.ToInt32(reader["NumberOfDoors"]),
                                    listOfAdditionalEquipment = reader["ListOfAdditionalEquipment"].ToString().Split(',').ToList(),
                                    numberOfCylinders = Convert.ToInt32(reader["numberOfCylinders"]),
                                    images = reader["images"].ToString().Split(',').ToList(), // Split the string after removing curly braces
                                    imageFolderPath = reader["imagefolderpath"].ToString()

                                });
                            }
                        }
                        return allCars;
                    }
                }
            }
        }

        public void CreateNewEVCar(EVCar evCar)
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = connection;

                string insertCommand = $@"
                            INSERT INTO Vehicles(Brand, Model, Year, Color, Type, NumberOfDoors, ListOfAdditionalEquipment, HorsePower, BatteryCapacity, Range)
                            VALUES('{evCar.brand}', '{evCar.model}', {evCar.year}, '{evCar.color}', 'EVCar', {evCar.numberOfDoors}, ARRAY['{string.Join("','", evCar.listOfAdditionalEquipment)}'], {evCar.hoursePower}, {evCar.batteryCapacity}, {evCar.range});";

                cmd.CommandText = insertCommand;
                cmd.ExecuteNonQuery();
                this.allVehicles = GetAllVehicles();
            }
        }

        public void UpdateImagesAndPath(EVCar evCar)
        {
            try
            {
                var connection = new NpgsqlConnection(connectionString);
                connection.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;

                    string sql = "UPDATE vehicles SET Images = @images, ImageFolderPath = @imageFolderPath WHERE id = @id;";
                    cmd.Parameters.AddWithValue("@images", evCar.images);
                    cmd.Parameters.AddWithValue("@imageFolderPath", evCar.imageFolderPath);
                    cmd.Parameters.AddWithValue("@id", evCar.Id);

                    cmd.CommandText = sql;
                    int rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine($"Rows affected: {rowsAffected}");
                    this.allVehicles = GetAllVehicles();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating database: {ex.Message}");
            }
        }
    }
}
