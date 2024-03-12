
namespace Domain_Models
{
    public class CreateVehicles
    {
        public List<Vehicle> CreateListOfCars()
        {
            List<Vehicle> AllCars = new List<Vehicle>();

            AllCars.Add(new EVCar("Nissan", "Leaf", 2023, "Silver", 0)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "LED Headlights", "Automatic Emergency Braking" },
                batteryCapacity = 40,
                range = 250
            });

            AllCars.Add(new EVCar("Chevrolet", "Bolt", 2022, "White", 0)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Lane Keep Assist", "Wireless Charging" },
                batteryCapacity = 60,
                range = 270
            });

            AllCars.Add(new PetrolCar("Honda", "Accord", 2023, "Black", 200)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Apple CarPlay", "Android Auto" },
                numberOfCylinders = 4
            });

            AllCars.Add(new PetrolCar("Ford", "Fusion", 2024, "Gray", 180)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Blind Spot Monitoring", "Rear Cross Traffic Alert" },
                numberOfCylinders = 4
            });

            AllCars.Add(new EVCar("Volkswagen", "ID.4", 2023, "Green", 0)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Adaptive Cruise Control", "Panoramic Sunroof" },
                batteryCapacity = 55,
                range = 260
            });

            AllCars.Add(new EVCar("Audi", "e-tron", 2024, "Orange", 0)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Virtual Cockpit", "Matrix LED Headlights" },
                batteryCapacity = 80,
                range = 320
            });

            AllCars.Add(new PetrolCar("BMW", "3 Series", 2024, "Silver", 250)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Wireless Charging", "Gesture Control" },
                numberOfCylinders = 6
            });

            AllCars.Add(new PetrolCar("Mercedes-Benz", "C-Class", 2023, "Red", 220)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "MBUX Infotainment", "Active Parking Assist" },
                numberOfCylinders = 4
            });

            AllCars.Add(new EVCar("Porsche", "Taycan", 2023, "Black", 0)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Porsche Communication Management", "Sport Chrono Package" },
                batteryCapacity = 93,
                range = 280
            });

            AllCars.Add(new EVCar("Rivian", "R1T", 2023, "Blue", 0)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Gear Tunnel", "Camp Kitchen" },
                batteryCapacity = 135,
                range = 300
            });

            AllCars.Add(new PetrolCar("Lexus", "ES", 2024, "White", 215)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Mark Levinson Audio", "Heated Steering Wheel" },
                numberOfCylinders = 4
            });

            AllCars.Add(new PetrolCar("Acura", "TLX", 2023, "Gray", 272)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "AcuraWatch Safety Suite", "ELS Studio 3D Premium Audio" },
                numberOfCylinders = 6
            });

            AllCars.Add(new EVCar("Hyundai", "Kona Electric", 2023, "White", 0)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Bluelink Connected Car Services", "Wireless Device Charging" },
                batteryCapacity = 64,
                range = 258
            });

            AllCars.Add(new EVCar("Kia", "Niro EV", 2024, "Black", 0)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "UVO Link Infotainment System", "Smart Cruise Control with Stop & Go" },
                batteryCapacity = 64,
                range = 239
            });

            AllCars.Add(new PetrolCar("Subaru", "Legacy", 2023, "Blue", 182)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Subaru EyeSight Driver Assist Technology", "Harman Kardon Audio System" },
                numberOfCylinders = 4
            });

            AllCars.Add(new PetrolCar("Mazda", "Mazda6", 2024, "Red", 187)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Mazda Connect Infotainment System", "Advanced Smart City Brake Support" },
                numberOfCylinders = 4
            });

            AllCars.Add(new EVCar("Tesla", "Model Y", 2023, "Silver", 0)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Autopilot", "Full Self-Driving Capability" },
                batteryCapacity = 75,
                range = 326
            });

            AllCars.Add(new EVCar("Ford", "Mustang Mach-E", 2024, "Yellow", 0)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Ford Co-Pilot360", "B&O Sound System by Bang & Olufsen" },
                batteryCapacity = 98,
                range = 305
            });

            AllCars.Add(new PetrolCar("Chevrolet", "Malibu", 2023, "Gray", 160)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Chevrolet Infotainment 3 System", "Wireless Apple CarPlay/Android Auto" },
                numberOfCylinders = 4
            });

            AllCars.Add(new PetrolCar("Nissan", "Altima", 2024, "Brown", 188)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Nissan Safety Shield 360", "NissanConnect Services" },
                numberOfCylinders = 4
            });

            AllCars.Add(new PetrolCar("Chevorlet", "Camaro", 2024, "Red", 455)
            {
                numberOfDoors = 2,
                listOfAdditionalEquipment = new List<string> { "Chevrolet Infotainment 3", "Wireless Charging" },
                numberOfCylinders = 8
            });

            AllCars.Add(new EVCar("BMW", "iX", 2023, "Blue", 500)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "BMW Operating System 8", "BMW Intelligent Personal Assistant" },
                batteryCapacity = 105,
                range = 300
            });

            AllCars.Add(new EVCar("Rimac", "C_Two", 2024, "Purple", 1500)
            {
                numberOfDoors = 2,
                listOfAdditionalEquipment = new List<string> { "Rimac Driver Coach", "Rimac Performance Data Logger" },
                batteryCapacity = 120,
                range = 340
            });

            AllCars.Add(new PetrolCar("Volvo", "S60", 2023, "White", 250)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Volvo Sensus Infotainment System", "Volvo Pilot Assist" },
                numberOfCylinders = 4
            });

            AllCars.Add(new PetrolCar("Infiniti", "Q50", 2024, "Silver", 300)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "INFINITI InTouch Dual HD Display System", "INFINITI InTouch Services" },
                numberOfCylinders = 6
            });

            AllCars.Add(new EVCar("Audi", "Q4 e-tron", 2024, "Gray", 400)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Audi Virtual Cockpit", "Audi Pre Sense Front" },
                batteryCapacity = 82,
                range = 280
            });

            AllCars.Add(new EVCar("Mercedes-Benz", "EQB", 2023, "Red", 350)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Mercedes-Benz User Experience (MBUX)", "Mercedes me connect" },
                batteryCapacity = 66,
                range = 260
            });

            AllCars.Add(new PetrolCar("Toyota", "Corolla", 2024, "Black", 169)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Toyota Safety Sense 2.0", "Apple CarPlay and Android Auto" },
                numberOfCylinders = 4
            });

            AllCars.Add(new PetrolCar("Hyundai", "Elantra", 2023, "Silver", 147)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Hyundai SmartSense", "Wireless Device Charging" },
                numberOfCylinders = 4
            });

            AllCars.Add(new EVCar("Polestar", "2", 2023, "Gray", 408)
            {
                numberOfDoors = 5,
                listOfAdditionalEquipment = new List<string> { "Polestar Digital Key", "Polestar Connect" },
                batteryCapacity = 78,
                range = 270
            });

            AllCars.Add(new EVCar("Lucid", "Air", 2024, "White", 1000)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Lucid DreamDrive", "Space Concept Interior" },
                batteryCapacity = 113,
                range = 517
            });

            AllCars.Add(new PetrolCar("Kia", "Optima", 2023, "Blue", 178)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Kia UVO Link", "Wireless Phone Charger" },
                numberOfCylinders = 4
            });

            AllCars.Add(new PetrolCar("Genesis", "G70", 2024, "Silver", 252)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Genesis Smart Sense", "Lexicon Premium Audio System" },
                numberOfCylinders = 6
            });

            AllCars.Add(new EVCar("Volkswagen", "ID.3", 2023, "Blue", 201)
            {
                numberOfDoors = 5,
                listOfAdditionalEquipment = new List<string> { "Volkswagen Car-Net", "Augmented Reality Head-Up Display" },
                batteryCapacity = 58,
                range = 263
            });

            AllCars.Add(new EVCar("Ford", "F-150 Lightning", 2024, "Silver", 563)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Ford BlueCruise", "Pro Power Onboard" },
                batteryCapacity = 110,
                range = 300
            });


            AllCars.Add(new PetrolCar("Audi", "A4", 2023, "Black", 201)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Audi MMI Navigation Plus", "Audi Virtual Cockpit" },
                numberOfCylinders = 4
            });

            AllCars.Add(new EVCar("Tesla", "Model Y", 2024, "Black", 500)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Tesla Autopilot", "Tesla Full Self-Driving Capability" },
                batteryCapacity = 75,
                range = 330
            });

            AllCars.Add(new EVCar("Nissan", "Leaf", 2023, "Green", 147)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Nissan ProPILOT Assist", "NissanConnect EV" },
                batteryCapacity = 40,
                range = 150
            });

            AllCars.Add(new PetrolCar("Honda", "Civic", 2024, "Red", 174)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Honda Sensing", "Apple CarPlay and Android Auto" },
                numberOfCylinders = 4
            });

            AllCars.Add(new PetrolCar("Chevrolet", "Camaro", 2023, "Yellow", 455)
            {
                numberOfDoors = 2,
                listOfAdditionalEquipment = new List<string> { "Chevrolet Infotainment 3", "Wireless Charging" },
                numberOfCylinders = 8
            });

            AllCars.Add(new EVCar("Porsche", "Taycan", 2024, "White", 750)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Porsche Communication Management", "Porsche Active Aerodynamics" },
                batteryCapacity = 93,
                range = 300
            });

            AllCars.Add(new EVCar("Chevrolet", "Bolt EV", 2023, "Silver", 200)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Chevrolet Infotainment System", "DC Fast Charging Capability" },
                batteryCapacity = 65,
                range = 259
            });

            AllCars.Add(new PetrolCar("Ford", "Mustang GT", 2024, "Blue", 460)
            {
                numberOfDoors = 2,
                listOfAdditionalEquipment = new List<string> { "Ford SYNC 3", "FordPass Connect" },
                numberOfCylinders = 8
            });

            AllCars.Add(new PetrolCar("BMW", "M3", 2023, "Black", 473)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "BMW Live Cockpit Professional", "M Driving Dynamics Control" },
                numberOfCylinders = 6
            });

            AllCars.Add(new EVCar("Jaguar", "I-PACE", 2024, "Gray", 394)
            {
                numberOfDoors = 5,
                listOfAdditionalEquipment = new List<string> { "Jaguar InControl Touch Pro", "Adaptive Surface Response" },
                batteryCapacity = 90,
                range = 292
            });

            AllCars.Add(new EVCar("Tesla", "Model S Plaid", 2023, "Red", 1100)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Tesla Theatre", "Bioweapon Defense Mode" },
                batteryCapacity = 100,
                range = 520
            });

            AllCars.Add(new EVCar("Rivian", "R1T", 2024, "Green", 750)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Rivian Adventure Gear", "Rivian Driver+" },
                batteryCapacity = 180,
                range = 400
            });
            // Adding more EV cars
            AllCars.Add(new EVCar("Jaguar", "I-PACE", 2024, "Gray", 394)
            {
                numberOfDoors = 5,
                listOfAdditionalEquipment = new List<string> { "Jaguar InControl Touch Pro", "Adaptive Surface Response" },
                batteryCapacity = 90,
                range = 292
            });

            AllCars.Add(new EVCar("Tesla", "Model S Plaid", 2023, "Red", 1100)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Tesla Theatre", "Bioweapon Defense Mode" },
                batteryCapacity = 100,
                range = 520
            });

            AllCars.Add(new EVCar("Rivian", "R1T", 2024, "Green", 750)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Rivian Adventure Gear", "Rivian Driver+" },
                batteryCapacity = 180,
                range = 400
            });

            AllCars.Add(new EVCar("NIO", "ES8", 2023, "Blue", 536)
            {
                numberOfDoors = 5,
                listOfAdditionalEquipment = new List<string> { "NIO Pilot", "NOMI Mate" },
                batteryCapacity = 100,
                range = 360
            });

            AllCars.Add(new PetrolCar("Lamborghini", "Huracan", 2024, "Yellow", 631)
            {
                numberOfDoors = 2,
                listOfAdditionalEquipment = new List<string> { "Lamborghini Infotainment System III", "Lamborghini Dynamic Steering" },
                numberOfCylinders = 10
            });

            AllCars.Add(new PetrolCar("Ferrari", "F8 Tributo", 2023, "Red", 710)
            {
                numberOfDoors = 2,
                listOfAdditionalEquipment = new List<string> { "Ferrari Infotainment System", "Ferrari Dynamic Enhancer" },
                numberOfCylinders = 8
            });

            AllCars.Add(new PetrolCar("McLaren", "720S", 2024, "Orange", 710)
            {
                numberOfDoors = 2,
                listOfAdditionalEquipment = new List<string> { "McLaren Track Telemetry", "McLaren Vehicle Lift" },
                numberOfCylinders = 8
            });

            AllCars.Add(new PetrolCar("Bugatti", "Chiron", 2023, "Black", 1479)
            {
                numberOfDoors = 2,
                listOfAdditionalEquipment = new List<string> { "Bugatti Advanced Cockpit", "Bugatti Sky View" },
                numberOfCylinders = 16
            });

            AllCars.Add(new EVCar("NIO", "ES8", 2023, "Blue", 536)
            {
                numberOfDoors = 5,
                listOfAdditionalEquipment = new List<string> { "NIO Pilot", "NOMI Mate" },
                batteryCapacity = 100,
                range = 360
            });

            AllCars.Add(new PetrolCar("Lamborghini", "Huracan", 2024, "Yellow", 631)
            {
                numberOfDoors = 2,
                listOfAdditionalEquipment = new List<string> { "Lamborghini Infotainment System III", "Lamborghini Dynamic Steering" },
                numberOfCylinders = 10
            });

            AllCars.Add(new PetrolCar("Ferrari", "F8 Tributo", 2023, "Red", 710)
            {
                numberOfDoors = 2,
                listOfAdditionalEquipment = new List<string> { "Ferrari Infotainment System", "Ferrari Dynamic Enhancer" },
                numberOfCylinders = 8
            });

            AllCars.Add(new PetrolCar("McLaren", "720S", 2024, "Orange", 710)
            {
                numberOfDoors = 2,
                listOfAdditionalEquipment = new List<string> { "McLaren Track Telemetry", "McLaren Vehicle Lift" },
                numberOfCylinders = 8
            });

            AllCars.Add(new PetrolCar("Bugatti", "Chiron", 2023, "Black", 1479)
            {
                numberOfDoors = 2,
                listOfAdditionalEquipment = new List<string> { "Bugatti Advanced Cockpit", "Bugatti Sky View" },
                numberOfCylinders = 16
            });

            AllCars.Add(new EVCar("Nissan", "Leaf", 2023, "Silver", 0)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "LED Headlights", "Automatic Emergency Braking" },
                batteryCapacity = 40,
                range = 250
            });

            AllCars.Add(new EVCar("Chevrolet", "Bolt", 2022, "White", 0)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Lane Keep Assist", "Wireless Charging" },
                batteryCapacity = 60,
                range = 270
            });

            AllCars.Add(new PetrolCar("Honda", "Accord", 2023, "Black", 200)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Apple CarPlay", "Android Auto" },
                numberOfCylinders = 4
            });

            AllCars.Add(new PetrolCar("Ford", "Fusion", 2024, "Gray", 180)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Blind Spot Monitoring", "Rear Cross Traffic Alert" },
                numberOfCylinders = 4
            });

            AllCars.Add(new EVCar("Volkswagen", "ID.4", 2023, "Green", 0)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Adaptive Cruise Control", "Panoramic Sunroof" },
                batteryCapacity = 55,
                range = 260
            });

            AllCars.Add(new EVCar("Audi", "e-tron", 2024, "Orange", 0)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Virtual Cockpit", "Matrix LED Headlights" },
                batteryCapacity = 80,
                range = 320
            });

            AllCars.Add(new PetrolCar("BMW", "3 Series", 2024, "Silver", 250)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Wireless Charging", "Gesture Control" },
                numberOfCylinders = 6
            });

            AllCars.Add(new PetrolCar("Mercedes-Benz", "C-Class", 2023, "Red", 220)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "MBUX Infotainment", "Active Parking Assist" },
                numberOfCylinders = 4
            });

            AllCars.Add(new EVCar("Porsche", "Taycan", 2023, "Black", 0)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Porsche Communication Management", "Sport Chrono Package" },
                batteryCapacity = 93,
                range = 280
            });

            AllCars.Add(new EVCar("Rivian", "R1T", 2023, "Blue", 0)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Gear Tunnel", "Camp Kitchen" },
                batteryCapacity = 135,
                range = 300
            });

            AllCars.Add(new PetrolCar("Lexus", "ES", 2024, "White", 215)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Mark Levinson Audio", "Heated Steering Wheel" },
                numberOfCylinders = 4
            });

            AllCars.Add(new PetrolCar("Acura", "TLX", 2023, "Gray", 272)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "AcuraWatch Safety Suite", "ELS Studio 3D Premium Audio" },
                numberOfCylinders = 6
            });

            AllCars.Add(new EVCar("Hyundai", "Kona Electric", 2023, "White", 0)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Bluelink Connected Car Services", "Wireless Device Charging" },
                batteryCapacity = 64,
                range = 258
            });

            AllCars.Add(new EVCar("Kia", "Niro EV", 2024, "Black", 0)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "UVO Link Infotainment System", "Smart Cruise Control with Stop & Go" },
                batteryCapacity = 64,
                range = 239
            });

            AllCars.Add(new PetrolCar("Subaru", "Legacy", 2023, "Blue", 182)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Subaru EyeSight Driver Assist Technology", "Harman Kardon Audio System" },
                numberOfCylinders = 4
            });

            AllCars.Add(new PetrolCar("Mazda", "Mazda6", 2024, "Red", 187)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Mazda Connect Infotainment System", "Advanced Smart City Brake Support" },
                numberOfCylinders = 4
            });

            AllCars.Add(new EVCar("Tesla", "Model Y", 2023, "Silver", 0)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Autopilot", "Full Self-Driving Capability" },
                batteryCapacity = 75,
                range = 326
            });

            AllCars.Add(new EVCar("Ford", "Mustang Mach-E", 2024, "Yellow", 0)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Ford Co-Pilot360", "B&O Sound System by Bang & Olufsen" },
                batteryCapacity = 98,
                range = 305
            });

            AllCars.Add(new PetrolCar("Chevrolet", "Malibu", 2023, "Gray", 160)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Chevrolet Infotainment 3 System", "Wireless Apple CarPlay/Android Auto" },
                numberOfCylinders = 4
            });

            AllCars.Add(new PetrolCar("Nissan", "Altima", 2024, "Brown", 188)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Nissan Safety Shield 360", "NissanConnect Services" },
                numberOfCylinders = 4
            });

            AllCars.Add(new PetrolCar("Chevorlet", "Camaro", 2024, "Red", 455)
            {
                numberOfDoors = 2,
                listOfAdditionalEquipment = new List<string> { "Chevrolet Infotainment 3", "Wireless Charging" },
                numberOfCylinders = 8
            });

            AllCars.Add(new EVCar("BMW", "iX", 2023, "Blue", 500)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "BMW Operating System 8", "BMW Intelligent Personal Assistant" },
                batteryCapacity = 105,
                range = 300
            });

            AllCars.Add(new EVCar("Rimac", "C_Two", 2024, "Purple", 1500)
            {
                numberOfDoors = 2,
                listOfAdditionalEquipment = new List<string> { "Rimac Driver Coach", "Rimac Performance Data Logger" },
                batteryCapacity = 120,
                range = 340
            });

            AllCars.Add(new PetrolCar("Volvo", "S60", 2023, "White", 250)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Volvo Sensus Infotainment System", "Volvo Pilot Assist" },
                numberOfCylinders = 4
            });

            AllCars.Add(new PetrolCar("Infiniti", "Q50", 2024, "Silver", 300)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "INFINITI InTouch Dual HD Display System", "INFINITI InTouch Services" },
                numberOfCylinders = 6
            });

            AllCars.Add(new EVCar("Audi", "Q4 e-tron", 2024, "Gray", 400)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Audi Virtual Cockpit", "Audi Pre Sense Front" },
                batteryCapacity = 82,
                range = 280
            });

            AllCars.Add(new EVCar("Mercedes-Benz", "EQB", 2023, "Red", 350)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Mercedes-Benz User Experience (MBUX)", "Mercedes me connect" },
                batteryCapacity = 66,
                range = 260
            });

            AllCars.Add(new PetrolCar("Toyota", "Corolla", 2024, "Black", 169)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Toyota Safety Sense 2.0", "Apple CarPlay and Android Auto" },
                numberOfCylinders = 4
            });

            AllCars.Add(new PetrolCar("Hyundai", "Elantra", 2023, "Silver", 147)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Hyundai SmartSense", "Wireless Device Charging" },
                numberOfCylinders = 4
            });

            AllCars.Add(new EVCar("Polestar", "2", 2023, "Gray", 408)
            {
                numberOfDoors = 5,
                listOfAdditionalEquipment = new List<string> { "Polestar Digital Key", "Polestar Connect" },
                batteryCapacity = 78,
                range = 270
            });

            AllCars.Add(new EVCar("Lucid", "Air", 2024, "White", 1000)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Lucid DreamDrive", "Space Concept Interior" },
                batteryCapacity = 113,
                range = 517
            });

            AllCars.Add(new PetrolCar("Kia", "Optima", 2023, "Blue", 178)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Kia UVO Link", "Wireless Phone Charger" },
                numberOfCylinders = 4
            });

            AllCars.Add(new PetrolCar("Genesis", "G70", 2024, "Silver", 252)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Genesis Smart Sense", "Lexicon Premium Audio System" },
                numberOfCylinders = 6
            });

            AllCars.Add(new EVCar("Volkswagen", "ID.3", 2023, "Blue", 201)
            {
                numberOfDoors = 5,
                listOfAdditionalEquipment = new List<string> { "Volkswagen Car-Net", "Augmented Reality Head-Up Display" },
                batteryCapacity = 58,
                range = 263
            });

            AllCars.Add(new EVCar("Ford", "F-150 Lightning", 2024, "Silver", 563)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Ford BlueCruise", "Pro Power Onboard" },
                batteryCapacity = 110,
                range = 300
            });

            AllCars.Add(new PetrolCar("Audi", "A4", 2023, "Black", 201)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Audi MMI Navigation Plus", "Audi Virtual Cockpit" },
                numberOfCylinders = 4
            });

            AllCars.Add(new EVCar("Tesla", "Model Y", 2024, "Black", 500)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Tesla Autopilot", "Tesla Full Self-Driving Capability" },
                batteryCapacity = 75,
                range = 330
            });

            AllCars.Add(new EVCar("Nissan", "Leaf", 2023, "Green", 147)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Nissan ProPILOT Assist", "NissanConnect EV" },
                batteryCapacity = 40,
                range = 150
            });

            AllCars.Add(new PetrolCar("Honda", "Civic", 2024, "Red", 174)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Honda Sensing", "Apple CarPlay and Android Auto" },
                numberOfCylinders = 4
            });

            AllCars.Add(new PetrolCar("Chevrolet", "Camaro", 2023, "Yellow", 455)
            {
                numberOfDoors = 2,
                listOfAdditionalEquipment = new List<string> { "Chevrolet Infotainment 3", "Wireless Charging" },
                numberOfCylinders = 8
            });

            AllCars.Add(new EVCar("Porsche", "Taycan", 2024, "White", 750)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Porsche Communication Management", "Porsche Active Aerodynamics" },
                batteryCapacity = 93,
                range = 300
            });

            AllCars.Add(new EVCar("Chevrolet", "Bolt EV", 2023, "Silver", 200)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Chevrolet Infotainment System", "DC Fast Charging Capability" },
                batteryCapacity = 65,
                range = 259
            });

            AllCars.Add(new PetrolCar("Ford", "Mustang GT", 2024, "Blue", 460)
            {
                numberOfDoors = 2,
                listOfAdditionalEquipment = new List<string> { "Ford SYNC 3", "FordPass Connect" },
                numberOfCylinders = 8
            });

            AllCars.Add(new PetrolCar("BMW", "M3", 2023, "Black", 473)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "BMW Live Cockpit Professional", "M Driving Dynamics Control" },
                numberOfCylinders = 6
            });

            AllCars.Add(new EVCar("Jaguar", "I-PACE", 2024, "Gray", 394)
            {
                numberOfDoors = 5,
                listOfAdditionalEquipment = new List<string> { "Jaguar InControl Touch Pro", "Adaptive Surface Response" },
                batteryCapacity = 90,
                range = 292
            });

            AllCars.Add(new EVCar("Tesla", "Model S Plaid", 2023, "Red", 1100)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Tesla Theatre", "Bioweapon Defense Mode" },
                batteryCapacity = 100,
                range = 520
            });

            AllCars.Add(new EVCar("Rivian", "R1T", 2024, "Green", 750)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Rivian Adventure Gear", "Rivian Driver+" },
                batteryCapacity = 180,
                range = 400
            });
            // Adding more EV cars
            AllCars.Add(new EVCar("Jaguar", "I-PACE", 2024, "Gray", 394)
            {
                numberOfDoors = 5,
                listOfAdditionalEquipment = new List<string> { "Jaguar InControl Touch Pro", "Adaptive Surface Response" },
                batteryCapacity = 90,
                range = 292
            });

            AllCars.Add(new EVCar("Tesla", "Model S Plaid", 2023, "Red", 1100)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Tesla Theatre", "Bioweapon Defense Mode" },
                batteryCapacity = 100,
                range = 520
            });

            AllCars.Add(new EVCar("Rivian", "R1T", 2024, "Green", 750)
            {
                numberOfDoors = 4,
                listOfAdditionalEquipment = new List<string> { "Rivian Adventure Gear", "Rivian Driver+" },
                batteryCapacity = 180,
                range = 400
            });

            AllCars.Add(new EVCar("NIO", "ES8", 2023, "Blue", 536)
            {
                numberOfDoors = 5,
                listOfAdditionalEquipment = new List<string> { "NIO Pilot", "NOMI Mate" },
                batteryCapacity = 100,
                range = 360
            });

            // Adding more Petrol cars
            AllCars.Add(new PetrolCar("Lamborghini", "Huracan", 2024, "Yellow", 631)
            {
                numberOfDoors = 2,
                listOfAdditionalEquipment = new List<string> { "Lamborghini Infotainment System III", "Lamborghini Dynamic Steering" },
                numberOfCylinders = 10
            });

            AllCars.Add(new PetrolCar("Ferrari", "F8 Tributo", 2023, "Red", 710)
            {
                numberOfDoors = 2,
                listOfAdditionalEquipment = new List<string> { "Ferrari Infotainment System", "Ferrari Dynamic Enhancer" },
                numberOfCylinders = 8
            });

            AllCars.Add(new PetrolCar("McLaren", "720S", 2024, "Orange", 710)
            {
                numberOfDoors = 2,
                listOfAdditionalEquipment = new List<string> { "McLaren Track Telemetry", "McLaren Vehicle Lift" },
                numberOfCylinders = 8
            });

            AllCars.Add(new PetrolCar("Bugatti", "Chiron", 2023, "Black", 1479)
            {
                numberOfDoors = 2,
                listOfAdditionalEquipment = new List<string> { "Bugatti Advanced Cockpit", "Bugatti Sky View" },
                numberOfCylinders = 16
            });

            AllCars.Add(new EVCar("NIO", "ES8", 2023, "Blue", 536)
            {
                numberOfDoors = 5,
                listOfAdditionalEquipment = new List<string> { "NIO Pilot", "NOMI Mate" },
                batteryCapacity = 100,
                range = 360
            });

            AllCars.Add(new PetrolCar("Lamborghini", "Huracan", 2024, "Yellow", 631)
            {
                numberOfDoors = 2,
                listOfAdditionalEquipment = new List<string> { "Lamborghini Infotainment System III", "Lamborghini Dynamic Steering" },
                numberOfCylinders = 10
            });

            AllCars.Add(new PetrolCar("Ferrari", "F8 Tributo", 2023, "Red", 710)
            {
                numberOfDoors = 2,
                listOfAdditionalEquipment = new List<string> { "Ferrari Infotainment System", "Ferrari Dynamic Enhancer" },
                numberOfCylinders = 8
            });

            AllCars.Add(new PetrolCar("McLaren", "720S", 2024, "Orange", 710)
            {
                numberOfDoors = 2,
                listOfAdditionalEquipment = new List<string> { "McLaren Track Telemetry", "McLaren Vehicle Lift" },
                numberOfCylinders = 8
            });

            AllCars.Add(new PetrolCar("Bugatti", "Chiron", 2023, "Black", 1479)
            {
                numberOfDoors = 2,
                listOfAdditionalEquipment = new List<string> { "Bugatti Advanced Cockpit", "Bugatti Sky View" },
                numberOfCylinders = 16
            });

            return AllCars;
        }

    }
}
