using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes
{
      class Customer
     {
        public Customer(int id, string name, string lastName, int age, string description)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Age = age;
            Description = description;
        }

        public int Id { get; set; } 
        public string Name { get; set; }    
        public string Description { get; set; } 
        public string LastName { get; set; }    
        public int Age { get; set; }    


       public void WriteScreen()
        {
            MessageBox.Show("Write Screen Fonksiyonu Customer Class'ı içerisinden çalıştırılmıştır.");
        }
        public void ReadScreen()
        {
            MessageBox.Show("Read Screen Fonksiyonu Customer Class'ı içerisinden çalıştırılmıştır.");
        }

        // Yeni bir müşteri eklemek için yardımcı bir fonksiyon
        

    }
}
