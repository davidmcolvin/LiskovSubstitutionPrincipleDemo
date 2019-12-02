using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
  public class Employee
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public decimal Salary { get; set; }

    public Employee Manager { get; set; }

    public virtual void CalculatePerHourRate(int rank)
    {
      decimal baseAmount = 12.50M;

      Salary = baseAmount + (rank * 2);
    }

    public virtual void AssignManager(Employee manager)
    {
      // Simulate doing other tasks here - otherwise, this should be
      // a property set statement, not a method
      Manager = manager;
    }

  }
}
