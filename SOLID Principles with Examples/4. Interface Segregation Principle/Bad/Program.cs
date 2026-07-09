using Interface_Segregation_Principle_Bad;

// ====================== BAD (Violates ISP) ======================
// IWorker has both Work() and Eat().
// RobotWorker is forced to implement Eat() even though robots don't eat.
// The only option is to throw NotImplementedException — a clear sign the interface is too fat.

var human = new HumanWorker();
human.Work();
human.Eat();   // fine — humans can eat

Console.WriteLine();

var robot = new RobotWorker();
robot.Work();  // fine — robots can work
robot.Eat();   // CRASHES: throws NotImplementedException — robots don't eat!
               // But the interface forced us to write this method anyway.
