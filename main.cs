using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Employee Bonus using arrays");
    Console.WriteLine("Enter the number of employees");
    int nbrEmp = Convert.ToInt32(Console.ReadLine());


    //get number of employees
    //get employee salary as input
    //get bonus percent as input
    //calculate Bonus
    //object creation "new" int[] salary = new int[5];
    int[] salary = new int[nbrEmp];
    double[] percent = new double[nbrEmp];
    double[] bonus = new double[nbrEmp];

    //Method 1 for iterating through an array
    for(int pos=0; pos < salary.Length; pos++)
    {
      Console.WriteLine("Enter employees salary");
      salary[pos]=Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Enter employees bonus percent as a decimal 0.00 - 1.00");
      percent[pos]=Convert.ToDouble(Console.ReadLine());

      bonus[pos]=salary[pos] * percent[pos];
    }


     /*for(int pos=0; pos < salary.Length; pos++)
     {
       Array.Sort(salary);
       Array.Sort(bonus);
      Console.WriteLine("Employee # " + pos + " Salary = $" + salary[pos] + " Bonus = $" + bonus[pos]);
     }*/

      //Method 2 for iterating through an array
     foreach (int item in salary)
     {
       Console.WriteLine("Salary of employee is $" + item);
     }

      foreach (int itemB in bonus)
     {
       Console.WriteLine("Bonus of employee is $" + itemB);
     }


  }
}