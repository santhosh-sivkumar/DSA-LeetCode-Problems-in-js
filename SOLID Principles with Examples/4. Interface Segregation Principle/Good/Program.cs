using Interface_Segregation_Principle_Good;

// ====================== GOOD (Follows ISP) ======================
// IWorker is split into IWorkable and IEatable.
// HumanWorker implements both — humans work AND eat.
// RobotWorker implements only IWorkable — robots only work. Eat() is never forced on them.

var human = new HumanWorker();
human.Work();
human.Eat();   // fine — HumanWorker implements IEatable

Console.WriteLine();

var robot = new RobotWorker();
robot.Work();  // fine — RobotWorker implements IWorkable
// robot.Eat(); <-- This line won't even compile. Eat() simply doesn't exist on RobotWorker.
//                 No crash, no NotImplementedException, no workaround needed.
