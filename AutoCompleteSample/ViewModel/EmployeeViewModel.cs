using AutoCompleteSample.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCompleteSample.ViewModel
{
    public class EmployeeViewModel
    {
        public ObservableCollection<Employee> Employees { get; set; }

        public EmployeeViewModel()
        {
            this.Employees = new ObservableCollection<Employee>()
            {
                new Employee{ Name = "Anne Dodsworth", Image = "anne_dodsworth.png"},
                new Employee{ Name = "Andrew Fuller", Image = "andrew_fuller.png"},
                new Employee{ Name = "Emilio Alvaro", Image = "emilio_alvaro.png" },
                new Employee{ Name = "Janet Leverling", Image = "janet_leverling.png" },
                new Employee{ Name = "Jennifer", Image = "jennifer.png"},
                new Employee{ Name = "Jackson", Image = "jackson.png"},
                new Employee{ Name = "Jacob",Image = "jacob.png"}
            };
            
        }
    }
}
