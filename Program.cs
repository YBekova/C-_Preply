using Task = C__Preply.Task;

var task1 = new Task("FirstTask");
var task2 = new Task("SecondTask");

task1.Start();
task1.Complete();
task1.ShowInfo();

task2.Start();
task2.Canceled();
task2.ShowInfo();