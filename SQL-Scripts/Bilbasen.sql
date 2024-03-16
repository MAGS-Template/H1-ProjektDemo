-- @block Create TABLE
CREATE TABLE Vehicles (
                    Id SERIAL PRIMARY KEY,
                    Url VARCHAR(255),
                    Brand VARCHAR(255),
                    Model VARCHAR(255),
                    Year INT,
                    Color VARCHAR(255),
                    HorsePower INT,
                    Images TEXT[],
                    ImageFolderPath VARCHAR(255),
                    NumberOfDoors INT,
                    ListOfAdditionalEquipment TEXT[],
                    BatteryCapacity INT,
                    Range INT,
                    NumberOfCylinders INT
                );