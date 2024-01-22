using LSP_Principle_1;

Employee emplo1 = new Manager("Carl", "Role");
var salary1 = emplo1.CalculateSalary(5000);
Console.WriteLine(emplo1.GetType());
Console.WriteLine(salary1);

Employee emplo2 = new Seller("Paul", "Role");
var salary2 = emplo1.CalculateSalary(3000);
Console.WriteLine(emplo2.GetType());
Console.WriteLine(salary2);