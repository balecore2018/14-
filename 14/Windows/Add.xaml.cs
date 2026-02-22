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

namespace _14.Windows
{
    
    /// <summary>
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class Add : Window
    {
        Classes.Passport EditPassport;
        public Add(Classes.Passport EditPassport)
        {
            InitializeComponent();
            if (EditPassport != null) { 
                Name.Text = EditPassport.Name;
                Firstname.Text = EditPassport.Firstname;
                Lastname.Text = EditPassport.Lastname;
                Issued.Text = EditPassport.Issued;
                DateOfIssued.Text = EditPassport.DateOfIssued;
                DepatmentCode.Text = EditPassport.DepatmentCode;
                SerialAndNumber.Text = EditPassport.SerialAndNumber;
                DateOfBirth.Text = EditPassport.DateOfBirth;
                PlaceOfBirth.Text = EditPassport.PlaceOfBirth;
                BthAdd.Content = "Сохранить";
                this.EditPassport = EditPassport;
            }
        }

        private void AddPassport(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(Name.Text) || !Classes.Common.CheckRegex.Match("^[А-Яа-яЁё]*$", Name.Text)) {
                MessageBox.Show("Не правильно указано имя.");
                return;
            }

            if (String.IsNullOrEmpty(Firstname.Text) || !Classes.Common.CheckRegex.Match("^[А-Яа-яЁё]*$", Firstname.Text))
            {
                MessageBox.Show("Не правильно указана фамилия.");
                return;
            }

            if (String.IsNullOrEmpty(Lastname.Text) || !Classes.Common.CheckRegex.Match("^[А-Яа-яЁё]*$", Lastname.Text))
            {
                MessageBox.Show("Не правильно указано отчество.");
                return;
            }




            if (String.IsNullOrEmpty(Issued.Text) || !Classes.Common.CheckRegex.Match("^[А-Яа-яЁё]*$", Issued.Text))
            {
                MessageBox.Show("Не правильно указано кем выдан паспорт");
                return;
            }
            if (String.IsNullOrEmpty(DateOfIssued.Text) || !Classes.Common.CheckRegex.Match("^(0[1-9]|[12][0-9]|3[01])\\.(0[1-9]|1[012])\\.\\d{4}$", DateOfIssued.Text))
            {
                MessageBox.Show("Не правильно указана дата выдачи.");
                return;
            }
            if (String.IsNullOrEmpty(DepatmentCode.Text) || !Classes.Common.CheckRegex.Match("^\\d{3}-\\d{3}$", DepatmentCode.Text))
            {
                MessageBox.Show("Не правильно указан код.");
                return;
            }
            if (String.IsNullOrEmpty(SerialAndNumber.Text) || !Classes.Common.CheckRegex.Match("^\\d{4} \\d{6}$", SerialAndNumber.Text))
            {
                MessageBox.Show("Не правильно указана серия и номер.");
                return;
            }
            if (String.IsNullOrEmpty(DateOfBirth.Text) || !Classes.Common.CheckRegex.Match("^(0[1-9]|[12][0-9]|3[01])\\.(0[1-9]|1[012])\\.\\d{4}$$", DateOfBirth.Text))
            {
                MessageBox.Show("Не правильно указана дата рождения.");
                return;
            }
            if (String.IsNullOrEmpty(PlaceOfBirth.Text) || !Classes.Common.CheckRegex.Match("^[А-Яа-яЁё0-9\\-\\s\\.\\,]+$", PlaceOfBirth.Text))
            {
                MessageBox.Show("Не правильно указано место рождения.");
                return;
            }





            if (EditPassport == null) { 
                EditPassport = new Classes.Passport();
                MainWindow.init.Passports.Add(EditPassport);
            }
            EditPassport.Name = Name.Text;
            EditPassport.Firstname = Firstname.Text;
            EditPassport.Lastname = Lastname.Text;
            EditPassport.Issued = Issued.Text;
            EditPassport.DateOfIssued = DateOfIssued.Text;
            EditPassport.DepatmentCode = DepatmentCode.Text;
            EditPassport.SerialAndNumber = SerialAndNumber.Text;
            EditPassport.DateOfBirth = DateOfBirth.Text;
            EditPassport.PlaceOfBirth = PlaceOfBirth.Text;

            MainWindow.init.LoadPassport();
            this.Close();
        }
    }
}
