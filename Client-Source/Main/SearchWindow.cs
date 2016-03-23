using Hardware_Shop_Client.Tools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Hardware_Shop_Client
{
    /// <summary>
    /// Dies stellt die GUI Klasse das Suchfensters. Dieses struktuiert die Suchanfragen des Benutzers und ermöglicht so
    /// eine Übersicht über die relevanten Artikel in der Datenbank. Gleichzeitig ist das Fenster das Hauptfenster des Clients
    /// und ermöglicht zugriff auf etliche Tools, welche dazu dienen um bestimmte Inhalte der Datenbank zu bearbeiten (Kategorien,
    /// Tags, Benutzer).
    /// </summary>
    public partial class SearchWindow : Form
    {
        /// <summary>
        /// Interne Initialisierung der GUI Elemente des Fensters.
        /// </summary>
        public SearchWindow()
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
            ClientMain.exit();
        }

        /// <summary>
        /// Setzt alle relevanten GUI Elemente zurück um sicher zu stellen, dass keine Werte von ggf. 
        /// alten Aufrufen vorhanden sind bzw. wenn der Benutzer alle Eingaben zurückgesetzt haben möchte via "x" neben
        /// dem Suchfeld.
        /// </summary>
        public void resetSearchWindow()
        {
            resetGUIObject("category", comboBox_category);
            resetGUIObject("subcategory", comboBox_subcategory);
            resetGUIObject("manufacturer", comboBox_manufacturer);
            resetGUIObject("user", comboBox_user);
            resetGUIObject("status", comboBox_status);

            comboBox_date.SelectedIndex = 0;
            comboBox_edit.SelectedIndex = 0;

            comboBox_sortBy.SelectedIndex = 0;
            checkBox_sortDescending.CheckState = CheckState.Unchecked;

            comboBox_maxResults.Text = "30";
            textBox_search.Text = "";

            string sql = "SELECT article.id,category_name,subcategory_name,"
                        + "manufacturer_name,user_name,title,date,edit,status_name,views FROM article "
                        + "INNER JOIN category ON article.category = category.id "
                        + "INNER JOIN subcategory ON article.subcategory = subcategory.id "
                        + "INNER JOIN status ON article.status = status.id "
                        + "INNER JOIN manufacturer ON article.manufacturer = manufacturer.id "
                        + "INNER JOIN user ON article.user = user.id LIMIT " + comboBox_maxResults.Text + ";";
            SQLiteCommand command = new SQLiteCommand(sql, ClientMain.databaseController.getConnection());

            searchDataView.Rows.Clear();
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
                searchDataView.Rows.Add(
                    reader["id"],
                    reader["views"],
                    reader["user_name"],
                    reader["category_name"],
                    reader["subcategory_name"],
                    reader["manufacturer_name"],
                    reader["title"],
                    reader["date"],
                    reader["edit"],
                    reader["status_name"]);
            reader.Close();
        }

        /// <summary>
        /// Diese Funktion wird ausgeführt wenn der Benutzer auf den "Search" Button geklickt hat, welche die 
        /// Eingabe aus dem Suchtextfeld nimmt und darauf basierend entweder direkt einen Artikel öffnet (wenn 
        /// die Eingabe nur aus einer Zahl besteht und diese in der Datenbank hinterlegt ist) oder Artikel vorschlägt,
        /// die zu der Eingabe passen.
        /// </summary>
        /// <param name="sender">Beobachtes GUI Element des Observers</param>
        /// <param name="e">Event Parameter der GUI</param>
        private void button_search_Click(object sender, EventArgs e)
        {
            int itemID = -1;

            if (int.TryParse(textBox_search.Text, out itemID) && isAccessible(itemID))
            {
                addContentAccessBlock(itemID);
                Hide();
                ClientMain.editorWindow.resetEditor();
                ClientMain.editorWindow.openExistingItem(itemID);
                ClientMain.editorWindow.Show();
            }
            else
                executeSearch();
        }

        /// <summary>
        /// Diese Funktion kümmert sich darum wenn man im Suchtextfeld die Taste "Enter" drückt. Daraufhin wird die
        /// Suche, wie beim "Search" Button, ausgeführt.
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
        /// Diese Funktion wird ausgeführt wenn der Benutzer einen Doppelklick auf einen Tabelleneintrag in den
        /// Suchergebnissen ausführt. Auf Basis des geklickten Artikels in den Suchergebnissen wird dann der Editor geöffnet.
        /// Gleichzeitig wird überprüft ob nicht ein anderer Benutzer schon diesen Artikel geöffnet hat.
        /// </summary>
        /// <param name="sender">Beobachtes GUI Element des Observers</param>
        /// <param name="e">Event Parameter der GUI</param>
        private void searchDataView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int itemID = (int)searchDataView.Rows[e.RowIndex].Cells[0].Value;

            if (isAccessible(itemID))
            {
                addContentAccessBlock(itemID);
                Hide();
                ClientMain.editorWindow.resetEditor();
                ClientMain.editorWindow.openExistingItem(itemID);
                ClientMain.editorWindow.Show();
            }
        }

        /// <summary>
        /// Diese Funktion wird ausgeführt wenn der Benutzer auf den "Editor" Button klickt. Es wird dann das Editor
        /// Fenster aufgerufen.
        /// </summary>
        /// <param name="sender">Beobachtes GUI Element des Observers</param>
        /// <param name="e">Event Parameter der GUI</param>
        private void button_editor_Click(object sender, EventArgs e)
        {
            Hide();
            ClientMain.editorWindow.resetEditor();
            ClientMain.editorWindow.Show();
        }

        /// <summary>
        /// Diese Funktion wird ausgeführt wenn der Benutzer auf das "x" neben den Suchfeld klickt. Es wird dann
        /// das komplette Suchfenster bzgl. der ausgewählten Inhalte zurückgesetzt.
        /// </summary>
        /// <param name="sender">Beobachtes GUI Element des Observers</param>
        /// <param name="e">Event Parameter der GUI</param>
        private void button_reset_Click(object sender, EventArgs e)
        {
            resetSearchWindow();
        }

        /// <summary>
        /// Diese Funktion wird ausgeführt wenn der Benutzer auf den "Tags" Button klickt. Es wird dann das Tag Tool
        /// Fenster geöffnet. Dieses Fenster dient dazu die Tags für die Artikel anzupassen bzw. weitere hinzufügen.
        /// Dieses Fenster können nur Benutzer mit einer Benutzerrolle die mindestens "Manager" entspricht öffnen.
        /// </summary>
        /// <param name="sender">Beobachtes GUI Element des Observers</param>
        /// <param name="e">Event Parameter der GUI</param>
        private void button_tags_Click(object sender, EventArgs e)
        {
            if (ClientMain.user_role >= ClientMain.USER_ROLE_MANAGER)
            {
                Enabled = false;
                TagToolWindow tagToolWindow = new TagToolWindow();
                tagToolWindow.Show();
            }
        }

        /// <summary>
        /// Diese Funktion wird ausgeführt wenn der Benutzer auf den "Category" Button klickt. Diese öffnet das Category Tool in dem 
        /// der Benutzer die Kategorien der Artikel bearbeiten kann. Dieses Fenster können nur Benutzer mit einer Benutzerrolle die 
        /// mindestens "Manager" entspricht öffnen.
        /// </summary>
        /// <param name="sender">Beobachtes GUI Element des Observers</param>
        /// <param name="e">Event Parameter der GUI</param>
        private void button_category_Click(object sender, EventArgs e)
        {
            if (ClientMain.user_role >= ClientMain.USER_ROLE_MANAGER)
            {
                Enabled = false;
                CategoryToolWindow categoryToolWindow = new CategoryToolWindow();
                categoryToolWindow.Show();
            }
        }

        /// <summary>
        /// Diese Funktion wird ausgeführt wenn der Benutzer auf den "Subcategory" Button klickt. Diese öffnet das Subcategory Tool 
        /// in dem der Benutzer die Sub-Kategorien der Artikel bearbeiten kann. Dieses Fenster können nur Benutzer mit einer 
        /// Benutzerrolle die mindestens "Manager" entspricht öffnen.
        /// </summary>
        /// <param name="sender">Beobachtes GUI Element des Observers</param>
        /// <param name="e">Event Parameter der GUI</param>
        private void button_subcategory_Click(object sender, EventArgs e)
        {
            if (ClientMain.user_role >= ClientMain.USER_ROLE_MANAGER)
            {
                Enabled = false;
                SubCategoryToolWindow subcategoryToolWindow = new SubCategoryToolWindow();
                subcategoryToolWindow.Show();
            }
        }

        /// <summary>
        /// Diese Funktion wird ausgeführt wenn der Benutzer auf den "Manufacture" Button klickt. Diese öffnet das Manufacture Tool 
        /// in dem der Benutzer die Hersteller der Artikel bearbeiten kann. Dieses Fenster können nur Benutzer mit einer 
        /// Benutzerrolle die mindestens "Manager" entspricht öffnen.
        /// </summary>
        /// <param name="sender">Beobachtes GUI Element des Observers</param>
        /// <param name="e">Event Parameter der GUI</param>
        private void button_manufacture_Click(object sender, EventArgs e)
        {
            if (ClientMain.user_role >= ClientMain.USER_ROLE_MANAGER)
            {
                Enabled = false;
                ManufacturerToolWindow manufacturerToolWindow = new ManufacturerToolWindow();
                manufacturerToolWindow.Show();
            }
        }

        /// <summary>
        /// Diese Funktion wird ausgeführt wenn der Benutzer auf den "User" Button klickt. Diese öffnet das User Tool 
        /// in dem der Benutzer die anderen User des Clients bearbeiten. Dieses Fenster können nur Benutzer mit einer 
        /// Benutzerrolle "Admin" öffnen.
        /// </summary>
        /// <param name="sender">Beobachtes GUI Element des Observers</param>
        /// <param name="e">Event Parameter der GUI</param>
        private void button_user_Click(object sender, EventArgs e)
        {
            if (ClientMain.user_role == ClientMain.USER_ROLE_ADMIN)
            {
                Enabled = false;
                UserToolWindow userToolWindow = new UserToolWindow();
                userToolWindow.Show();
            }
        }

        /// <summary>
        /// Diese Funktion führt auf Basis des Suchtextfeldes eine Suche nach passenden Artikeln durch. Als Referenz wird der 
        /// Artikel Title genommen. Auf Basis der Auswahl der GUI Einstellungen im Suchfenster wird die Suche teilweise noch weiter
        /// eingeschränkt (Kategorie, Hersteller, Status usw.).
        /// </summary>
        public void executeSearch()
        {
            string text = textBox_search.Text;
            bool insertFilter = false, numberic = false;

            string sql = "SELECT article.id,category_name,subcategory_name,"
                        + "manufacturer_name,user_name,status_name,title,date,edit,views FROM article "
                        + "INNER JOIN category ON article.category = category.id "
                        + "INNER JOIN subcategory ON article.subcategory = subcategory.id "
                        + "INNER JOIN manufacturer ON article.manufacturer = manufacturer.id "
                        + "INNER JOIN status ON article.status = status.id "
                        + "INNER JOIN user ON article.user = user.id "
                        + "WHERE";

            int tempItemID;
            if (int.TryParse(textBox_search.Text, out tempItemID))
            {
                sql = sql + " article.id = " + text;
                insertFilter = true;
                numberic = true;
            }
            else if (textBox_search.Text != "")
            {
                sql = sql + " article.title LIKE '%" + text + "%'";
                insertFilter = true;
            }

            if (!numberic)
            {
                sql = sql + getFilterSQLData("category", comboBox_category, insertFilter, out insertFilter)
                      + getFilterSQLData("subcategory", comboBox_subcategory, insertFilter, out insertFilter)
                      + getFilterSQLData("user", comboBox_user, insertFilter, out insertFilter)
                      + getFilterSQLData("manufacturer", comboBox_manufacturer, insertFilter, out insertFilter)
                      + getFilterSQLData("status", comboBox_status, insertFilter, out insertFilter);

                if (comboBox_sortBy.Text != "")
                {
                    if (checkBox_sortDescending.Checked)
                        sql = sql + " ORDER BY article." + comboBox_sortBy.Text + " DESC";
                    else
                        sql = sql + " ORDER BY article." + comboBox_sortBy.Text + " ASC";
                }
            }
            else
            {
                string backupText = textBox_search.Text;
                resetSearchWindow();
                textBox_search.Text = backupText;
                textBox_search.Select(backupText.Length, 0);
            }

            sql = sql + " LIMIT " + comboBox_maxResults.Text + " ;";

            if (sql.Contains("WHERE ORDER BY") || sql.Contains("WHERE LIMIT"))
                sql = sql.Replace(" WHERE", "");

            SQLiteCommand command = new SQLiteCommand(sql, ClientMain.databaseController.getConnection());

            Console.WriteLine(sql);

            Dictionary<int, ArrayList> searchResults = new Dictionary<int, ArrayList>();
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ArrayList data = new ArrayList();
                data.Add(reader["id"]);
                data.Add(reader["views"]);
                data.Add(reader["user_name"]);
                data.Add(reader["category_name"]);
                data.Add(reader["subcategory_name"]);
                data.Add(reader["manufacturer_name"]);
                data.Add(reader["title"]);
                data.Add(reader["date"]);
                data.Add(reader["edit"]);
                data.Add(reader["status_name"]);

                searchResults.Add((int)data[0], data);
            }
            reader.Close();

            searchResults = adjustSearchResultsByDate(searchResults, comboBox_date.Text, "date");
            searchResults = adjustSearchResultsByDate(searchResults, comboBox_edit.Text, "edit");

            searchDataView.Rows.Clear();
            List<int> keyList = new List<int>(searchResults.Keys);
            for (int i = 0; i <= int.Parse(comboBox_maxResults.Text) && i < keyList.Count; i++)
            {
                ArrayList data = searchResults[keyList[i]];
                searchDataView.Rows.Add(data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7], data[8], data[9]);
            }
        }

        /// <summary>
        /// Diese Funktion dient dazu das Suchergebnis speziell anhand der Einstellung der "last_edit" Dropbox, welche
        /// Ergebnis nur in einem bestimmten Zeitraum anzeigen soll.
        /// </summary>
        /// <param name="searchResults">Dictionary which hold a arraylist structure: 
        /// id, views, user, category, subcategory, manufacture, title date, edit, status</param>
        /// <param name="dateFilter">Reference which date filter have been selected</param>
        /// <returns></returns>
        private Dictionary<int, ArrayList> adjustSearchResultsByDate(Dictionary<int, ArrayList> searchResults, string dateFilter, string reference)
        {
            if (dateFilter == "")
                return searchResults;

            int maxTimeDiff;
            switch (dateFilter)
            {
                case "1 month ago":
                    maxTimeDiff = 1;
                    break;
                case "3 months ago":
                    maxTimeDiff = 3;
                    break;
                case "6 months ago":
                    maxTimeDiff = 6;
                    break;
                default:
                    maxTimeDiff = int.MaxValue;
                    break;
            }

            List<int> removed = new List<int>();
            foreach (ArrayList data in searchResults.Values)
            {
                string date;

                if (reference == "date")
                    date = (string)data[7];
                else
                    date = (string)data[8];

                string[] dateSplite = date.Split(new Char[] { '-' });

                DateTime creation = new DateTime(int.Parse("20" + dateSplite[0]), int.Parse(dateSplite[1]), int.Parse(dateSplite[2]));
                TimeSpan diff = DateTime.Today - creation;
                int months = (int)((double)diff.Days / 30.436875); //30.436875 = durchschnittliche Monatslänge (in Tagen)

                if (months > maxTimeDiff)
                    removed.Add((int)data[0]);
            }

            for (int i = 0; i < removed.Count; i++)
                searchResults.Remove(removed[i]);

            return searchResults;
        }

        /// <summary>
        /// Diese Funktion holt sich weitere Bedinungen für die Suche, wenn das jeweilige GUI Objekt eine Auswahl drinnen hat.
        /// Dabei wird beachtet ob es schon Filter gibt (bzgl des "AND").
        /// </summary>
        /// <param name="type">Typ des Filters (Bedingung), wie Status, Hersteller</param>
        /// <param name="reference">Referenz GUI Objekt</param>
        /// <param name="filterBefore">Ob es davor schon einen Filter in der Bedinung der SQL Anfrage gibt. 
        /// Relevant für das AND in der Bedinung.</param>
        /// <param name="success">Gibt an ob ein Filter erstellt wurde oder nicht. Dient als "filterBefore" für den nächsten Filter.</param>
        /// <returns>Gibt die Bedingung zurück die direkt in die SQL Anfrage eingebaut werden kann</returns>
        private string getFilterSQLData(string type, ComboBox reference, bool filterBefore, out bool success)
        {
            if (reference.Text != "")
            {
                int id;
                success = getSQLContentID(reference.Text, type, out id);

                if (success)
                {
                    if (filterBefore)
                        return " AND article." + type + " = " + id;
                    else
                        return " article." + type + " = " + id;
                }
                else
                    return "";
            }
            else
            {
                if (filterBefore)
                    success = true;
                else
                    success = false;

                return "";
            }
        }

        /// <summary>
        /// Holt auf Basis eines Wortes und eines Typen (Table) die jeweilige ID dieses Eintrages, womit dann Anfragen gemacht
        /// werden können.
        /// </summary>
        /// <param name="reference">Wort wovon die ID geholt werden soll</param>
        /// <param name="type">Typ bzw. Table in der Datenbank wo genau in der Datenbank nach gesucht werden soll</param>
        /// <param name="id">ID des Wortes welches gesucht wurde</param>
        /// <returns>Gibt an ob eine ID gefunden wurde oder nicht</returns>
        private bool getSQLContentID(string reference, string type, out int id)
        {
            id = -1;
            string sql = "SELECT id FROM " + type
                        + " WHERE " + type + "_name = '" + reference + "' ;";
            SQLiteCommand command = new SQLiteCommand(sql, ClientMain.databaseController.getConnection());
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
                id = (int)reader["id"];
            reader.Close();

            return id != -1 ? true : false;
        }

        /// <summary>
        /// Setzt das jeweilige GUI Objekt zurück und holt sich aus der Datenbank die neuste Referenz der Auswahlmöglichkeiten der
        /// ComboBox, sollte sich in der Zwischenzeit etwas geändert haben.
        /// </summary>
        /// <param name="table">Relevante Table die überprüft werden soll ob neue Auswahlmöglichkeiten für 
        /// diese ComboBox vorhanden sind</param>
        /// <param name="reference">Referenz GUI ComboBox</param>
        private void resetGUIObject(String table, ComboBox reference)
        {
            string sql = "SELECT " + table + "_name FROM " + table + ";";
            SQLiteCommand command = new SQLiteCommand(sql, ClientMain.databaseController.getConnection());

            reference.Items.Clear();

            if (table == "status" || table == "user")
                reference.Items.Add("");

            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
                reference.Items.Add((string)reader[table + "_name"]);
            reader.Close();
        }

        /// <summary>
        /// Checks if a certain item can be access regarding the rule that only ONE editor can access a specific item.
        /// </summary>
        /// <param name="itemID">Specific item id which needs to be checked</param>
        /// <returns>boolean which let the open request through or not</returns>
        private bool isAccessible(int itemID)
        {
            string user = "", date = "";

            string sql = "SELECT user_name, date FROM content_access "
                        + "INNER JOIN user ON content_access.user_id = user.id "
                        + "WHERE article_id = " + itemID + ";";
            SQLiteCommand command = new SQLiteCommand(sql, ClientMain.databaseController.getConnection());

            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                user = (string)reader["user_name"];
                date = (string)reader["date"];
            }
            reader.Close();

            if (user == "" && date == "")
            {
                return true;
            }
            else
            {
                if (user == ClientMain.user)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("This item is currently opened by " + user + " since " + date + ".", "Info");
                    return false;
                }
            }
        }

        /// <summary>
        /// Fügt eine Zugangssperre zu einem bestimmten Artikel hinzu wodurch andere Benutzer nicht mehr auf diesen Artikel zugreifen
        /// können damit es nicht zu Speicherkonflikten kommt oder ähnliches.
        /// </summary>
        /// <param name="itemID">ID des Artikels</param>
        private void addContentAccessBlock(int itemID)
        {
            int lastID = 0, userID = -1;

            string sql = "SELECT id FROM content_access;";
            SQLiteCommand command = new SQLiteCommand(sql, ClientMain.databaseController.getConnection());

            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
                lastID = (int)reader["id"];
            reader.Close();

            sql = "SELECT id FROM user WHERE user_name = '" + ClientMain.user + "';";
            command = new SQLiteCommand(sql, ClientMain.databaseController.getConnection());

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                userID = (int)reader["id"];
            }
            reader.Close();

            if (userID != -1)
            {
                sql = "INSERT INTO content_access (id,article_id,user_id,date) "
                + "VALUES (" + (lastID + 1) + ", " + itemID + ", " + userID + ", '" + DateTime.Now + "');";
                command = new SQLiteCommand(sql, ClientMain.databaseController.getConnection());
                command.ExecuteNonQuery();
            }
        }
    }
}