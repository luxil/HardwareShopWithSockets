using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Hardware_Shop_Client
{
    public partial class LoginWindow : Form
    {
        /// <summary>
        /// Interne Initialisierung der GUI Objekte vom Fenster.
        /// </summary>
        public LoginWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Diese Funktion wird ausgeführt wenn das Fenster via "X" geschlossen wird. Dies ist wichtig um alle 
        /// relevanten Threads vom Client zu beenden und gleichzeitig die Datenbank Schnittstelle zu schließen.
        /// </summary>
        /// <param name="e">Internes Argument welches weitere Infos zu diesem "Schließen" Event hält</param>
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            ClientMain.databaseController.getConnection().Close();
        }

        /// <summary>
        /// Diese Funktion wird ausgeführt wenn der Benutzer auf den "Login" Button klickt. Diese Funktion ruft dann eine 
        /// andere Funktion auf, welche versucht den Benutzer auf Basis seiner Angaben einzuloggen.
        /// </summary>
        /// <param name="sender">Beobachtes GUI Element des Observers</param>
        /// <param name="e">Event Parameter der GUI</param>
        private void button_login_Click(object sender, EventArgs e)
        {
            loginUser();
        }

        /// <summary>
        /// Diese Funktion kümmert sich um den eigentlichen Login. Es wird der Benutzername und das Passwort der
        /// Benutzereingabe genommen und mit den Datenbank Einträgen verglichen ob es einen Treffer gibt. Sollte es einen
        /// geben, dann wird der Benutzer eingeloggt. Sollte es keinen geben, bekommt dieser einen Hinweis dass vermutlich der
        /// Benutzername und/oder das Passwort falsch ist.
        /// </summary>
        private void loginUser()
        {
            string sql = "SELECT role, password FROM user WHERE user_name = '" + textBox_user.Text + "';";
            SQLiteCommand command = new SQLiteCommand(sql, ClientMain.databaseController.getConnection());
            SQLiteDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                if ((string)reader["password"] == textBox_password.Text && (int)reader["role"] > ClientMain.USER_ROLE_USER)
                {
                    Hide();
                    ClientMain.user = textBox_user.Text;
                    ClientMain.user_role = (int)reader["role"];
                    ClientMain.searchWindow.resetSearchWindow();
                    ClientMain.searchWindow.Show();
                }
                else
                    MessageBox.Show("Invalid input. Try again.", "Error Message");
            }
            else
                MessageBox.Show("Invalid input. Try again.", "Error Message");
            reader.Close();
        }
    }
}
