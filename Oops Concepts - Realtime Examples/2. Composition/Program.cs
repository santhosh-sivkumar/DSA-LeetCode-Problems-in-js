using Composition.cs;

// ====================== BAD (No Composition) ======================
// Without composition, all logic is crammed into one giant Car class.
// Engine, Wheel, Chassis, and Seat logic all live inside Car.
// Changing one part risks breaking everything else.

// class Car {
//     void StartEngine() { ... }    // engine logic inside Car
//     void RotateWheels() { ... }   // wheel logic inside Car
//     void SupportChassis() { ... } // chassis logic inside Car
//     void SitOnSeats() { ... }     // seat logic inside Car
// }

Console.WriteLine();

// ====================== GOOD (With Composition) ======================
// Car is composed of separate objects: Engine, Wheels, Chassis, Seats.
// Each class handles only its own responsibility.
// You can swap out or change Engine without touching Wheels or Seats.

var car = new Car();
car.StartCar();
// ^ Car delegates to Engine.StartEngine(), Wheels.Rotate(), Chassis.Support(), Seats.Sit()
//   Each component does its own job. Car just coordinates them.