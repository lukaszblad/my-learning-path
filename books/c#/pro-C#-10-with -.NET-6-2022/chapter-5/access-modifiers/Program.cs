﻿using EmployeeApp;
Console.WriteLine("***** Fun with Encapsulation *****\n");
Employee emp = new Employee("Marvin", 456, 30_000);
emp.GiveBonus(1000);
emp.DisplayStats();
// Use the get/set methods to interact with the object's name. 
emp.SetName("Marv");
Console.WriteLine("Employee is named: {0}", emp.GetName());
