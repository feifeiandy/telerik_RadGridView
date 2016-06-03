using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication4
{
    public class MVVM
    {
        public ObservableCollection<Student> MyProperty { get; set; }

        public MVVM()
        {
            MyProperty = new ObservableCollection<Student>() 
            {
                new Student { ID = 1, Name = "text1", Date = DateTime.Now },
                new Student { ID = 1, Name = "text2", Date = DateTime.Now },

                new Student { ID = 2, Name = "text5", Date = DateTime.Now }, 
                new Student { ID = 2, Name = "text6", Date = DateTime.Now }, 
                new Student { ID = 2, Name = "text7", Date = DateTime.Now } 
            };
        }
    }
}
