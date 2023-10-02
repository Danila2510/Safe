using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Safe
{
    public class Model : IModel
    {
        public string Pass { get; set; }
        public void CheckPassword()
        {
            if (Pass == "5820")
            {
                MessageBox.Show("Открыт", "Сейф", MessageBoxButton.OK);
            }
            else
                MessageBox.Show("Не правельный пароль", "Сейф", MessageBoxButton.OK);
        }
    }
}
