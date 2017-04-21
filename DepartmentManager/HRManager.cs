using System;
using System.Collections.Generic;

namespace Project0
{
	public class HRManager
	{
		private List<Employee> employees;

		public HRManager()
		{
			// Constructor 
			// initialize collection here
		}

		public void Add(Employee e)
		{
			// Add new employee to a list
		}

		public void Remove(string firstName)
		{
			// Rmove employee
		}

		public Employee Find(string firstName)
		{
			// Find the object that matches the first name 
			// And return the object
			return null;
		}

		public int FindPosition(string firstName)
		{
			// Find the position of the employee object that matches 
			// the first name passed in 
			// Return its position as an int

			return 0;
		}

		public void Print(Employee e)
		{
			Console.WriteLine("First Name is {0}", e.FirstName);
			// Add more console.writeline
		}


		public void Print()
		{
			// Print out everything from the employee list
			// Can you iterate through the entire list and call PrintEmployee(Employee e) 
			// on each object?

		}

		public int GetCount()
		{
			// Implement this
			return 0;
		}
	}

}

