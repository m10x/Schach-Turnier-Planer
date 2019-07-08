using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Schach_Turnier_Planer
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Team Teams;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TeamAddButton_Click(object sender, RoutedEventArgs e)
        {
            Teams = new Team(textTeamName.Text, textTeamPartner.Text, System.Convert.ToInt32(textTeamNummer.Text));
            lbTeams.Items.Add(Teams);
        }

        private void TeamRemoveButton_Click(object sender, RoutedEventArgs e)
        {
            lbTeams.Items.Remove(lbTeams.SelectedItem);
        }

        private void TeamChangeButton_Click(object sender, RoutedEventArgs e)
        {
            Teams = lbTeams.SelectedItem as Team;
            textTeamName.Text = Teams.Name;
            textTeamPartner.Text = Teams.Partner;
            textTeamNummer.Text = Teams.Nummer.ToString();
        }
    }
}
