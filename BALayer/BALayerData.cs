using BOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALayer
{
    public class BALayerData
    {
        DALayer.EmployeeData data = new DALayer.EmployeeData();
        public List<Employee> GetEmployees()
        {
            return data.GetData();
        }
        public Employee GetEmployeeById(int? id)
        {
            Employee employee = null;
            if (id != null)
            {
                employee = data.GetDataById(id);
            }
            return employee;
        }
        public string InsertEmployee(Employee employee)
        {
            if (employee != null)
            {
                data.InsertData(employee);
            }
            return "Data is inserted";
        }
        public string DeleteEmployee(int? id)
        {
            if (id != null)
            {
                data.DeleteData(id);
            }
            return "Data is deleted";
        }
    }
}
