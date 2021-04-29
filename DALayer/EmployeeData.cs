using BOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALayer
{
    public class EmployeeData
    {
        EmployeeContext db = new EmployeeContext();
        public List<Employee> GetData()
        {
            return db.Employees.ToList();
        }
        public Employee GetDataById(int? id)
        {
            Employee employee = null;
            if (id != null)
            {
                employee = db.Employees.Find(id);
            }
            return employee;
        }
        public void InsertData(Employee employee)
        {
            if (employee != null)
            {
                db.Employees.Add(employee);
            }
            db.SaveChanges();
        }

        public void DeleteData(int? id)
        {
            Employee employee = null;
            if (id != null)
            {
                employee = db.Employees.Find(id);
            }
            db.Employees.Remove(employee);
            db.SaveChanges();
        }
    }
}
