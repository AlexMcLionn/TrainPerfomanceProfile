using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TPProfil
{
    /// <summary>
    /// Логика взаимодействия для WindowNewProfil.xaml
    /// </summary>
    public partial class WindowNewProfil : Window
    {
        public WindowNewProfil()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = PNameTextBox.Text;
            double ps = Convert.ToDouble(PStartPqTextBox.Text);
            double pe = Convert.ToDouble(PEndPqTextBox.Text);

            //Profil profil = new Profil(name, ps, pe);
        }

        /*public Profil getProfil
        {
            get { return Profil; }
        }*/
    }
}
