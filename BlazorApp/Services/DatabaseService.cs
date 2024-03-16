using Domain_Models;
using Npgsql;
using System.Buffers;
using System;

namespace BlazorApp.Services
{
    public class DatabaseService
    {
        public string connectionString;

        public DatabaseService(string connectionString) { this.connectionString = connectionString; }
        public List<Vehicle> GetAllVehicles()
        {
            List<Vehicle> allCars = new List<Vehicle>();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT Brand, Model, Year, Color, HorsePower, NumberOfDoors, array_to_string(ListOfAdditionalEquipment, ',') as ListOfAdditionalEquipment, BatteryCapacity, Range, NumberOfCylinders, array_to_string(Images, ',') as Images, ImageFolderPath, Type FROM vehicles";

                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var type = reader["type"].ToString();
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
                                    numberOfDoors = Convert.ToInt32(reader["NumberOfDoors"]),
                                    listOfAdditionalEquipment = reader["ListOfAdditionalEquipment"].ToString().Split(',').ToList(),
                                    batteryCapacity = Convert.ToInt32(reader["BatteryCapacity"]),
                                    range = Convert.ToInt32(reader["Range"])
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
    }
}
