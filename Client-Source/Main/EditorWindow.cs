using Hardware_Shop_Client.Main;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Hardware_Shop_Client
{
    /// <summary>
    /// Dies ist die GUI Klasse zum Editor Fenster. Das Editor Fenster dient für die Erstellung/Änderung von Artikeln.
    /// </summary>
    public partial class EditorWindow : Form
    {
        /// <summary>
        /// Referenz ID für das aktuell ausgewählte artikel. Diese wird benötigt um später dieses wieder abzuspeichern
        /// um eventuell den Tag Manager zu öffnen.
        /// </summary>
        private int currentItemId = -1;

        /// <summary>
        /// Interne Initialisierung der GUI Elemente des Fensters.
        /// </summary>
        public EditorWindow()
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
            deleteContentAccessBlock();
            base.OnClosed(e);
            ClientMain.exit();
        }

        /// <summary>
        /// Setzt alle relevanten GUI Elemente zurück um sicher zu stellen, dass keine Werte von ggf. 
        /// alten Aufrufen vorhanden sind.
        /// </summary>
        public void resetEditor()
        {
            resetGUIObject("category", comboBox_category);
            resetGUIObject("subcategory", comboBox_subcategory);
            resetGUIObject("manufacturer", comboBox_manufacturer);
            resetGUIObject("user", comboBox_user);
            resetGUIObject("status", comboBox_status);

            date_creationDate.Value = DateTime.Today;
            label_id.Text = "ID:";
            label_edit.Text = "Last Edit:";
            textBox_name.Text = "";
            textBox_title.Text = "";
            textBox_url.Text = "";
            comboBox_user.Text = ClientMain.user;

            dataGridView_normalTags.Rows.Clear();
            dataGridView_masterTags.Rows.Clear();
            dataGridView_content.Rows.Clear();
        }

        /// <summary>
        /// Diese Funktion sorgt dafür dass ein bestehender Artikel aus der Datenbank geöffnet wird und die
        /// relevanten GUI Elemente mit den jeweiligen Informationen aus diesem Artikel gefüttert werden.
        /// </summary>
        /// <param name="id">ID des bestehenden Artikels</param>
        public void openExistingItem(int id)
        {
            string sql = "SELECT article.id,category_name, status_name,"
                        + "subcategory_name,user_name, title, url, name, date, edit, manufacturer_name FROM article "
                        + "INNER JOIN category ON article.category = category.id "
                        + "INNER JOIN subcategory ON article.subcategory = subcategory.id "
                        + "INNER JOIN manufacturer ON article.manufacturer = manufacturer.id "
                        + "INNER JOIN user ON article.user = user.id "
                        + "INNER JOIN status ON article.status = status.id "
                        + "WHERE article.id = " + id + ";";
            SQLiteCommand command = new SQLiteCommand(sql, ClientMain.databaseController.getConnection());

            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox_category.SelectedIndex = comboBox_category.FindStringExact((string)reader["category_name"]);
                comboBox_subcategory.SelectedIndex = comboBox_subcategory.FindStringExact((string)reader["subcategory_name"]);
                comboBox_manufacturer.SelectedIndex = comboBox_manufacturer.FindStringExact((string)reader["manufacturer_name"]);
                comboBox_user.SelectedIndex = comboBox_user.FindStringExact((string)reader["user_name"]);
                comboBox_status.SelectedIndex = comboBox_status.FindStringExact((string)reader["status_name"]);

                string date = (string)reader["date"];
                string[] dateSplite = date.Split(new Char[] { '-' });
                date_creationDate.Value = new DateTime(int.Parse("20" + dateSplite[0]), int.Parse(dateSplite[1]), int.Parse(dateSplite[2]));

                currentItemId = (int)reader["id"];
                label_id.Text = "ID: " + reader["id"];

                string edit = (string)reader["edit"];
                string[] editSplite = edit.Split(new Char[] { '-' });

                label_edit.Text = "Last Edit: " + "20" + editSplite[0] + "/" + editSplite[1] + "/" + editSplite[2] 
                    + " - " + editSplite[3] + ":" + editSplite[4] + ":" + editSplite[5];

                textBox_name.Text = reader["name"] + "";
                textBox_title.Text = reader["title"] + "";
                textBox_url.Text = reader["url"] + "";
            }
            reader.Close();

            resetTagInfos();
            initContentTable();
        }

        /// <summary>
        /// Initialisiert und befüllt die Inhaltstabelle vom Artikel. Die Inhaltstabelle befindet sich am unteren rechten Rand
        /// im Editor Fenster. Diese Tabelle holt sich auf Basis der Kategorie die value1 und value2 Werte. Die value1 Werte entsprechen
        /// Bezeichnern, wie "Anzahl der Kerne", "Speichergröße" oder "Lesegeschwindigkeit" und der value2 Wert der Tabelle entspricht
        /// den jeweiigen Werten von dem Artikel zu diesem Bezeichner. Beispiel: Artikel ist eine CPU, dann könnte bei dem value1-
        /// Bezeichner so etwas stehen wie "3 Kerne".
        /// </summary>
        public void initContentTable()
        {
            dataGridView_content.Rows.Clear();

            if (comboBox_category.Text != "")
            {
                Dictionary<int, string> content = new Dictionary<int, string>();

                string sql = "SELECT value1, value2 FROM content_input "
                + "WHERE article_id = " + currentItemId + ";";
                SQLiteCommand command = new SQLiteCommand(sql, ClientMain.databaseController.getConnection());

                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                    content.Add((int)reader["value1"], (string)reader["value2"]);
                reader.Close();

                string sql2 = "SELECT id, value1 FROM input "
                + "WHERE category_id = " + getItemID("category", comboBox_category) + ";";
                SQLiteCommand command2 = new SQLiteCommand(sql2, ClientMain.databaseController.getConnection());

                SQLiteDataReader reader2 = command2.ExecuteReader();
                while (reader2.Read())
                {
                    if (content.ContainsKey((int)reader2["id"]))
                        dataGridView_content.Rows.Add(reader2["value1"], content[(int)reader2["id"]]);
                    else
                        dataGridView_content.Rows.Add(reader2["value1"], "");
                }
                reader2.Close();
            }
        }

        /// <summary>
        /// Diese Funktion ist ein Observer für die Dropbox von der Kategorie. Wenn der Benutzer die Kategorie ändert, bekommt
        /// der Benutzer eine kurze Warnung, dass alle value1/value2 Werte dieses Artikels aus der Datenbank gelöscht werden, sollte
        /// er die Kategorie wechseln. An dieser Stelle kann der Benutzer seine Eingabe außerdem rückgangig machen.
        /// </summary>
        /// <param name="sender">Beobachtes GUI Element des Observers</param>
        /// <param name="e">Event Parameter der GUI</param>
        private void comboBox_category_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to change the category? All value1 entries will be deleted from this item!", 
                "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "DELETE FROM content_input WHERE article_id = " + currentItemId + ";";
                SQLiteCommand command = new SQLiteCommand(sql, ClientMain.databaseController.getConnection());
                command.ExecuteNonQuery();

                initContentTable();
            }
            else
            {
                string sql = "SELECT category_name FROM article "
                   + "INNER JOIN category ON article.category = category.id "
                   + "WHERE article.id = " + currentItemId + ";";
                SQLiteCommand command = new SQLiteCommand(sql, ClientMain.databaseController.getConnection());

                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                    comboBox_category.Text = (string)reader["category_name"];
                reader.Close();
            }
        }

        /// <summary>
        /// Wenn der Benutzer auf den "Close" Button klickt, wird das Editor Fenster versteckt und das Suchfenster wird
        /// wieder angezeigt. Außerdem werden die Suchergebnisse wieder zurückgesetzt.
        /// </summary>
        /// <param name="sender">Beobachtes GUI Element des Observers</param>
        /// <param name="e">Event Parameter der GUI</param>
        private void button_close_Click(object sender, EventArgs e)
        {
            deleteContentAccessBlock();
            Hide();
            ClientMain.searchWindow.Show();
            ClientMain.searchWindow.executeSearch(); //resets the search results
            currentItemId = -1;
        }

        /// <summary>
        /// Wenn der Benuzer auf den "New" Button klickt wird der Editor vollständig zurückgesetzt damit der Benutzer
        /// die Arbeit an einem neuen Artikel starten kann.
        /// </summary>
        /// <param name="sender">Beobachtes GUI Element des Observers</param>
        /// <param name="e">Event Parameter der GUI</param>
        private void button_new_Click(object sender, EventArgs e)
        {
            resetEditor();
        }

        /// <summary>
        /// Wenn der Benutzer auf den "Save" Button geklickt hat, dann wird der aktuelle Artikel mit den Inhalten der GUI Elemente
        /// des Editors gespeichert. Dabei wird unterschieden zwischen einem neuen Artikel und einem bestehenden Artikel.
        /// </summary>
        /// <param name="sender">Beobachtes GUI Element des Observers</param>
        /// <param name="e">Event Parameter der GUI</param>
        private void button_save_Click(object sender, EventArgs e)
        {
            if (currentItemId != -1)
                saveCurrentItem();
            else
                saveNewItem();
        }

        /// <summary>
        /// Wenn der Benutzer auf "Edit Tags" klickt, wird das Tag Fenster geöffnet und das Editor Fenster deaktiviert, damit der
        /// Eingabefokus des Benutzer immer nur auf ein Fenster gerichtet ist. Das Tag Fenster kann nur geöffnet werden, wenn der
        /// Artikel schon in der Datenbank besteht.
        /// </summary>
        /// <param name="sender">Beobachtes GUI Element des Observers</param>
        /// <param name="e">Event Parameter der GUI</param>
        private void button_editTags_Click(object sender, EventArgs e)
        {
            if (currentItemId != -1)
            {
                Enabled = false;
                ClientMain.tagWindow = new TagWindow();
                ClientMain.tagWindow.Show();
                ClientMain.tagWindow.openWindow(currentItemId);
            }
            else
                MessageBox.Show("Item needs to be saved to access the tag manager.", "Error Message");
        }

        /// <summary>
        /// Wenn der Benutzer auf den "Delete" Button klickt wird der derzeitige, bestehende(!) Artikel aus der Datenbank
        /// gelöscht.
        /// </summary>
        /// <param name="sender">Beobachtes GUI Element des Observers</param>
        /// <param name="e">Event Parameter der GUI</param>
        private void button_delete_Click(object sender, EventArgs e)
        {
            if (currentItemId != -1)
                deleteItem(currentItemId);
        }

        /// <summary>
        /// Wenn der Benutzer auf den Button "URL" klick, wird ein kleines Fenster geöffnet in dem der Benutzer die URL Endung
        /// des Artikels eingeben kann. Dies ist in gewissen Rahmen relevant für Google, wodurch ggf. bessere Suchergebnisse zustande
        /// kommnen. Außerdem dient dieses Fenster dazu die URL richtig zu formatieren, sodass die später keine etwaligen Probleme macht.
        /// </summary>
        /// <param name="sender">Beobachtes GUI Element des Observers</param>
        /// <param name="e">Event Parameter der GUI</param>
        private void button_url_Click(object sender, EventArgs e)
        {
            URLWindow urlWindow = new URLWindow();
            urlWindow.Show();
            Enabled = false;
        }

        /// <summary>
        /// Diese Funktion speichert einen neuen Artikel. Dies wird über die "INSERT" Operation von SQL durchgeführt.
        /// </summary>
        private void saveNewItem()
        {
            int lastID = 0, category = -1, subcategory = -1, manufacturer = -1, user = -1, status = -1;

            string sql = "SELECT id from article;";
            SQLiteCommand command = new SQLiteCommand(sql, ClientMain.databaseController.getConnection());

            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
                lastID = (int)reader["id"];
            reader.Close();

            category = getItemID("category", comboBox_category);
            subcategory = getItemID("subcategory", comboBox_subcategory);
            manufacturer = getItemID("manufacturer", comboBox_manufacturer);
            user = getItemID("user", comboBox_user);
            status = getItemID("status", comboBox_status);

            if (category != -1 && subcategory != -1 && manufacturer != -1 && user != -1 && status != -1)
            {
                sql = "INSERT INTO article (id,category,subcategory,manufacturer,user,status,title,url,name,date,edit,views) "
                + "VALUES (" +
                (lastID + 1) + "," +
                category + "," +
                subcategory + "," +
                manufacturer + "," +
                user + "," +
                status + "," +
                "'" + textBox_title.Text + "' ," +
                "'" + textBox_url.Text + "' ," +
                "'" + textBox_name.Text + "' ," +
                "'" + date_creationDate.Value.ToString("yy-MM-dd") + "' ," +
                "'" + DateTime.Now.ToString("yy-MM-dd-HH-mm-ss") + "'," +
                0 + ");";
                command = new SQLiteCommand(sql, ClientMain.databaseController.getConnection());
                command.ExecuteNonQuery();

                saveContentFields();

                MessageBox.Show("Item has been created.", "Info");
                openExistingItem(lastID + 1);
            }
            else
                MessageBox.Show("Something went wrong.", "Error Message");
        }

        /// <summary>
        /// Diese Funktion aktualisiert einen bestehenden Artikel mit Hilfe der "UPDATE" SQL Operation.
        /// </summary>
        private void saveCurrentItem()
        {
            int category = -1, subcategory = -1, manufacturer = -1, user = -1, status = -1;

            category = getItemID("category", comboBox_category);
            subcategory = getItemID("subcategory", comboBox_subcategory);
            manufacturer = getItemID("manufacturer", comboBox_manufacturer);
            user = getItemID("user", comboBox_user);
            status = getItemID("status", comboBox_status);

            if (category != -1 && subcategory != -1 && manufacturer != -1 && user != -1 && status != -1)
            {
                string sql = "UPDATE article " +
                "SET category = " + category + "," +
                "subcategory = " + subcategory + "," +
                "manufacturer = " + manufacturer + "," +
                "status = " + status + "," +
                "title = '" + textBox_title.Text + "'," +
                "name = '" + textBox_name.Text + "'," +
                "url = '" + textBox_url.Text + "'," +
                "date = '" + date_creationDate.Value.ToString("yy-MM-dd") + "'," +
                "edit = '" + DateTime.Now.ToString("yy-MM-dd-HH-mm-ss") + "'," +
                "user = " + user +
                " WHERE id = " + currentItemId + ";";

                SQLiteCommand command = new SQLiteCommand(sql, ClientMain.databaseController.getConnection());
                command.ExecuteNonQuery();

                saveContentFields();

                MessageBox.Show("Item has been saved.", "Info");
            }
            else
                MessageBox.Show("Something went wrong.", "Error Message");
        }

        /// <summary>
        /// Diese Funktion speichert die Inhaltstabelle (value1/value2) Angaben in die Datenbank in Referenz zu der Artikel ID.
        /// </summary>
        private void saveContentFields()
        {
            for (int i = 0; i < dataGridView_content.Rows.Count; i++)
            {
                string value1 = (string)dataGridView_content.Rows[i].Cells[0].Value;
                string value2 = (string)dataGridView_content.Rows[i].Cells[1].Value;
                int contentID = -1;

                string sql = "SELECT id FROM input "
                + "WHERE value1 = '" + value1 + "';";
                SQLiteCommand command = new SQLiteCommand(sql, ClientMain.databaseController.getConnection());

                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                    contentID = (int)reader["id"];
                reader.Close();

                if (contentID != -1)
                {
                    int valueID = -1;
                    sql = "SELECT id,value2 FROM content_input "
                    + "WHERE article_id = " + currentItemId + " AND value1 = " + contentID + ";";
                    command = new SQLiteCommand(sql, ClientMain.databaseController.getConnection());

                    reader = command.ExecuteReader();
                    while (reader.Read())
                        valueID = (int)reader["id"];
                    reader.Close();

                    if (valueID != -1)
                        if(value2 != "")
                            updateContent(valueID, value2);
                        else
                            deleteContent(valueID);
                    else
                        insertNewContent(contentID, value2);
                }
            }
        }

        /// <summary>
        /// Diese Funktion fügt ein neues value1/value2 Paar in die Tabelle.
        /// </summary>
        /// <param name="value1">Bezeichner (Referenz)</param>
        /// <param name="value2">Artikelwert</param>
        private void insertNewContent(int value1, string value2)
        {
            int lastID = 0;

            string sql = "SELECT id FROM content_input;";
            SQLiteCommand command = new SQLiteCommand(sql, ClientMain.databaseController.getConnection());

            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
                lastID = (int)reader["id"];
            reader.Close();

            sql = "INSERT INTO content_input (id,article_id,value1,value2) "
                + "VALUES (" + (lastID + 1) + "," + currentItemId + "," + value1 + ", '" + value2 + "');";
            command = new SQLiteCommand(sql, ClientMain.databaseController.getConnection());
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Diese Funktion aktualisiert ein value1/value2 Paar in der Tabelle.
        /// </summary>
        /// <param name="value1">Bezeichner (Referenz)</param>
        /// <param name="value2">Artikelwert</param>
        private void updateContent(int value1, string value2)
        {
            string sql = "UPDATE content_input " +
                "SET value2 = '" + value2 + "'" +
                " WHERE id = " + value1 + ";";
            SQLiteCommand command = new SQLiteCommand(sql, ClientMain.databaseController.getConnection());
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Löscht ein value1/value2 Wert von diesem Artikel.
        /// </summary>
        /// <param name="valueID">Bezeichner (Referenz)</param>
        private void deleteContent(int valueID)
        {
            string sql = "DELETE FROM content_input WHERE id = " + valueID + ";";
            SQLiteCommand command = new SQLiteCommand(sql, ClientMain.databaseController.getConnection());
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Löscht ein Artikel mit einer bestimmten ID.
        /// </summary>
        /// <param name="id">ID des Artikels welches gelöscht werden soll</param>
        private void deleteItem(int id)
        {
            string sql = "DELETE FROM article WHERE id = " + id + ";";
            SQLiteCommand command = new SQLiteCommand(sql, ClientMain.databaseController.getConnection());
            command.ExecuteNonQuery();

            MessageBox.Show("Item has been deleted.", "Info");
            resetEditor();
        }

        /// <summary>
        /// Holt sich die Feld ID eines bestimmten Eingabewertes einer ComboBox in der GUI. Diese wird
        /// benötigt um den Wert beim abspeichern zu verwenden.
        /// </summary>
        /// <param name="table">Tabelle worauf sich das GUI Objekt bezieht</param>
        /// <param name="reference">GUI Objekt wovon sich der Eingabewert vom Benutzer geholt werden soll</param>
        /// <returns></returns>
        private int getItemID(String table, ComboBox reference)
        {
            int id = -1;
            string sql = "SELECT id FROM " + table + " WHERE " + table + "_name = '" + reference.Text + "';";
            SQLiteCommand command = new SQLiteCommand(sql, ClientMain.databaseController.getConnection());

            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
                id = (int)reader["id"];
            reader.Close();

            return id;
        }

        /// <summary>
        /// Diese Funktion kümmert sich um den Tag Editor. Dieser wird zurückgesetzt durch diese Funktion
        /// und mithilfe der Artikel ID ggf. wieder mit Informationen gefüttert.
        /// </summary>
        public void resetTagInfos()
        {
            dataGridView_normalTags.Rows.Clear();
            dataGridView_masterTags.Rows.Clear();

            string sql = "SELECT tag_id, tag_category, tag_name, views FROM search "
                        + "INNER JOIN tag ON search.tag_id = tag.id "
                        + "WHERE article_id = " + currentItemId + " ORDER BY tag_id;";
            SQLiteCommand command = new SQLiteCommand(sql, ClientMain.databaseController.getConnection());

            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if ((int)reader["tag_category"] == 0)
                    dataGridView_normalTags.Rows.Add(reader["tag_id"], reader["tag_name"], reader["Views"]);
                else
                    dataGridView_masterTags.Rows.Add(reader["tag_id"], reader["tag_name"], reader["Views"]);
            }
            reader.Close();
        }

        /// <summary>
        /// Diese Funktion setzt den Wert eines GUI Objektes zurück, damit keine Altdaten angezeigt werden.
        /// </summary>
        /// <param name="table">Tabelle worauf sich das GUI Objekt bezieht</param>
        /// <param name="reference">GUI Objekt wovon sich der Eingabewert vom Benutzer geholt werden soll</param>
        private void resetGUIObject(String table, ComboBox reference)
        {
            string sql = "SELECT " + table + "_name FROM " + table + ";";
            SQLiteCommand command = new SQLiteCommand(sql, ClientMain.databaseController.getConnection());

            reference.Items.Clear();
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
                reference.Items.Add((string)reader[table + "_name"]);
            reader.Close();
        }

        /// <summary>
        /// Diese Funktion kümmert sich um das Entblocken der sogenannten Inhaltssperre. Wenn ein Benutzer einen Artikel 
        /// geöffnet hat, dann wird nämlich dieser Artikel für alle anderen Benutzer gesperrt bis dieser den Artikel wieder 
        /// geschlossen hat. Das soll verhindern dass es eventuell zu Speicherproblemen kommt oder falsche Angaben gespeichert werden.
        /// </summary>
        private void deleteContentAccessBlock()
        {
            if (currentItemId != -1)
            {
                string sql = "DELETE FROM content_access WHERE article_id = " + currentItemId + ";";
                SQLiteCommand command = new SQLiteCommand(sql, ClientMain.databaseController.getConnection());
                command.ExecuteNonQuery();
            }
        }
    }
}
