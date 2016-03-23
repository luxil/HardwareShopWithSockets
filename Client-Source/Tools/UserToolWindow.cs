using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Hardware_Shop_Client.Tools
{
    /// <summary>
    /// Dies ist die GUI Klasse zum User Tool Fenster. Das Fenster dient zum Bearbeiten von Usern.
    /// </summary>
    public partial class UserToolWindow : Form
    {
        /// <summary>
        /// Interne Initialisierung der GUI Elemente des Fensters.
        /// </summary>
        public UserToolWindow()
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
            ClientMain.searchWindow.Enabled = true;
        }

        /// <summary>
        /// Wenn der Benutzer auf den "Create" Button klickt, wird ein neuer User in die Datenbank geschrieben.
        /// </summary>
        /// <param name="sender">Beobachtes GUI Element des Observers</param>
        /// <param name="e">Event Parameter der GUI</param>
        private void button_create_Click(object sender, EventArgs e)
        {
            int lastID = 0;

            string sql = "SELECT id FROM user;";
            SQLiteCommand command = new SQLiteCommand(sql, ClientMain.databaseController.getConnection());

            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
                lastID++;
            reader.Close();

            int role;
            if (int.TryParse(textBox_createRole.Text, out role) && role < 4 && role >= 0)
            {
                sql = "INSERT INTO user (id,user_name,password,role) "
                + "VALUES (" + (lastID + 1) + ", '" + textBox_createName.Text + "', '" + textBox_createPassword.Text + "', " + role + ");";
                command = new SQLiteCommand(sql, ClientMain.databaseController.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("User has been created.", "Info");

                textBox_search.Text = textBox_createName.Text;
                textBox_createRole.Text = "";
                textBox_createPassword.Text = "";
                textBox_createRole.Text = "";
                executeSearch();
            }
            else
                MessageBox.Show("The field role must be numberic under certain rules (0 = User; 1 = Editor; 2 = Manager; 3 = Admin).", "Error");
        }

        /// <summary>
        /// Wenn der Benutzer auf den "Edit" Button klickt, wird ein bestehender User in der Datenbank geändert auf
        /// Basis der Benutzereingabe. Der User, welcher bearbeitet wird, basiert auf der Auswahl von der Tabelle.
        /// </summary>
        /// <param name="sender">Beobachtes GUI Element des Observers</param>
        /// <param name="e">Event Parameter der GUI</param>
        private void button_edit_Click(object sender, EventArgs e)
        {
            int userID = (int)dataGridView_results.SelectedRows[0].Cells[0].Value;

            int role;
            if (int.TryParse(textBox_editRole.Text, out role) && role < 4 && role >= 0)
            {
                string sql = "UPDATE user " +
                "SET user_name = '" + textBox_editName.Text + "', " +
                "password = '" + textBox_editPassword.Text + "', " +
                "role = " + textBox_editRole.Text +
                " WHERE id = " + userID + ";";

                SQLiteCommand command = new SQLiteCommand(sql, ClientMain.databaseController.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("User has been edited.", "Info");

                textBox_search.Text = textBox_editName.Text;
                textBox_editPassword.Text = "";
                executeSearch();
            }
            else
                MessageBox.Show("The field role must be numberic under certain rules (0 = User; 1 = Editor; 2 = Manager; 3 = Admin).", "Error");
        }

        /// <summary>
        /// Wenn der Benutzer auf den "Delete" Button klickt, wird ein bestehender User in der Datenbank gelöscht.
        /// Der User, welcher gelöscht wird, basiert auf der Auswahl von der Tabelle.
        /// </summary>
        /// <param name="sender">Beobachtes GUI Element des Observers</param>
        /// <param name="e">Event Parameter der GUI</param>
        private void button_delete_Click(object sender, EventArgs e)
        {
            int userID = (int)dataGridView_results.SelectedRows[0].Cells[0].Value, amount = 0;

            string sql = "SELECT id FROM article WHERE user = " + userID + ";";
            SQLiteCommand command = new SQLiteCommand(sql, ClientMain.databaseController.getConnection());

            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
                amount++;
            reader.Close();

            if (amount == 0)
            {
                sql = "DELETE FROM user WHERE id = " + userID + ";";
                command = new SQLiteCommand(sql, ClientMain.databaseController.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("User has been deleted.", "Info");

                textBox_search.Text = "";
                executeSearch();
            }
            else
                MessageBox.Show("User cannot be deleted because of remaining items related to this user.", "Info");
        }

        /// <summary>
        /// Wenn der Benutzer auf den "Search" Button klickt, wird die Suche nach Usern ausgeführt.
        /// </summary>
        /// <param name="sender">Beobachtes GUI Element des Observers</param>
        /// <param name="e">Event Parameter der GUI</param>
        private void button_search_Click(object sender, EventArgs e)
        {
            executeSearch();
        }

        /// <summary>
        /// Wenn der Benutzer im Suchfeld die Taste "Enter" drückt, wird die Suche ausgeführt.
        /// </summary>
        /// <param name="sender">Beobachtes GUI Element des Observers</param>
        /// <param name="e">Event Parameter der GUI</param>
        private void textBox_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                executeSearch();
                e.Handled = true;
            }
        }

        /// <summary>
        /// Wenn der Benutzer in der Tabelle seine Auswahl der User (welche er angeklickt hat) ändert,
        /// wird die Textbox angepasst, die zum ggf. angepassen des Namens verwendet wird.
        /// </summary>
        /// <param name="sender">Beobachtes GUI Element des Observers</param>
        /// <param name="e">Event Parameter der GUI</param>
        private void dataGridView_results_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_results.SelectedRows.Count > 0)
            {
                textBox_editName.Text = (string)dataGridView_results.SelectedRows[0].Cells[1].Value;

                string sql = "SELECT role FROM user WHERE user_name = '" + textBox_editName.Text + "';";
                SQLiteCommand command = new SQLiteCommand(sql, ClientMain.databaseController.getConnection());
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    textBox_editRole.Text = (int)reader["role"] + "";
                }
                reader.Close();
            }

        }

        /// <summary>
        /// Diese Funktion kümmert sich um die Suche nach Usern. Es wird dabei nach exakten Treffern und nach ähnlichen
        /// Namen gesucht.
        /// </summary>
        private void executeSearch()
        {
            string sql;

            if (textBox_search.Text == "")
                sql = "SELECT id,user_name FROM user;";
            else
                sql = "SELECT id,user_name FROM user"
                      + " WHERE user_name = '" + textBox_search.Text + "' "
                      + "OR user_name LIKE '%" + textBox_search.Text + "%';";

            SQLiteCommand command = new SQLiteCommand(sql, ClientMain.databaseController.getConnection());
            SQLiteDataReader reader = command.ExecuteReader();

            dataGridView_results.Rows.Clear();
            while (reader.Read())
            {
                int amount = 0;

                string sql2 = "SELECT id FROM article WHERE user = " + reader["id"] + ";";
                SQLiteCommand command2 = new SQLiteCommand(sql2, ClientMain.databaseController.getConnection());

                SQLiteDataReader reader2 = command2.ExecuteReader();
                while (reader2.Read())
                    amount++;
                reader2.Close();

                string username = (string)reader["user_name"];

                if (username != "" && username != "n/a")
                {
                    dataGridView_results.Rows.Add((int)reader["id"], username, amount);
                }
            }
            reader.Close();
        }
    }
}
