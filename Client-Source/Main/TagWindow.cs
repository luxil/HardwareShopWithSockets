using System;
using System.Collections;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Hardware_Shop_Client
{
    /// <summary>
    /// Dies ist die GUI Klasse zum Tag Fenster welches an das Editor Fenster hängt. 
    /// Das Tag Fenster dient für das Hinzufügen von Tags zu einem Artikel und das eventuelle Erstellen von neuen Tags.
    /// </summary>
    public partial class TagWindow : Form
    {
        /// <summary>
        /// Hält die interne Datenstruktur der Tags und deren Kategorisierung untereinander. Dadurch wird abgeleitet
        /// in welche Kategorie (normal, master) die Tags gehören und welche Tags seit der letzten Bearbeitung neu hinzugekommen
        /// sind und welche ihre Kategorie geändert haben.
        /// </summary>
        private ArrayList newTags, normalTags, masterTags, removedTags, updatedTags;
        /// <summary>
        /// Item ID des Artikel wovon die Tags angepasst werden.
        /// </summary>
        private int itemID;

        /// <summary>
        /// Interne Initialisierung der GUI Elemente des Fensters.
        /// </summary>
        public TagWindow()
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
            ClientMain.editorWindow.Enabled = true;
            ClientMain.editorWindow.resetTagInfos();
        }

        /// <summary>
        /// Diese Funktion setzt alle Angaben im Tag Fenster zurück und füllt die Angaben auf Basis der Artikel ID neu. 
        /// </summary>
        /// <param name="itemID">ID des aktuell ausgewählten Artikels</param>
        public void openWindow(int itemID)
        {
            this.itemID = itemID;
            newTags = new ArrayList();
            normalTags = new ArrayList();
            masterTags = new ArrayList();
            removedTags = new ArrayList();
            updatedTags = new ArrayList();

            dataGridView_tags.Rows.Clear();
            dataGridView_normalTags.Rows.Clear();
            dataGridView_masterTags.Rows.Clear();

            string sql = "SELECT tag_id, tag_category, tag_name, views FROM search "
                        + "INNER JOIN tag ON search.tag_id = tag.id "
                        + "WHERE article_id = " + itemID + " ORDER BY tag_id ASC;";
            SQLiteCommand command = new SQLiteCommand(sql, ClientMain.databaseController.getConnection());

            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int tagID = (int)reader["tag_id"];

                if ((int)reader["tag_category"] == 0)
                {
                    dataGridView_normalTags.Rows.Add(tagID, reader["tag_name"], reader["Views"]);
                    normalTags.Add(tagID);
                }
                else
                {
                    dataGridView_masterTags.Rows.Add(tagID, reader["tag_name"], reader["Views"]);
                    masterTags.Add(tagID);
                }
            }
            reader.Close();
        }

        /// <summary>
        /// Wenn der Benutzer auf ein Tag Eintrag in der linken Tabelle Doppelklick anwendet, wird in die "normal" Tabelle 
        /// das ausgewählte Tag hinzugefügt.
        /// </summary>
        /// <param name="sender">Beobachtes GUI Element des Observers</param>
        /// <param name="e">Event Parameter der GUI</param>
        private void dataGridView_tags_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            addNewTag((int)dataGridView_tags.Rows[e.RowIndex].Cells[0].Value,
                    (string)dataGridView_tags.Rows[e.RowIndex].Cells[1].Value);
        }

        /// <summary>
        /// Wenn der Benutzer auf den "AddTag" Button klickt, wird in die "normal" Tabelle 
        /// das ausgewählte Tag hinzugefügt.
        /// </summary>
        /// <param name="sender">Beobachtes GUI Element des Observers</param>
        /// <param name="e">Event Parameter der GUI</param>
        private void button_addTag_Click(object sender, EventArgs e)
        {
            if (dataGridView_tags.SelectedRows.Count > 0)
                addNewTag((int)dataGridView_tags.SelectedRows[0].Cells[0].Value,
                    (string)dataGridView_tags.SelectedRows[0].Cells[1].Value);
        }

        /// <summary>
        /// Wenn der Benutzer auf den "AddMasterTag" Button klickt, wird in die "master" Tabelle 
        /// das ausgewählte Tag von der "normal" Tabelle hinzugefügt und gleichzeitig aus der "normal" 
        /// Tabelle rausgelöscht.
        /// </summary>
        /// <param name="sender">Beobachtes GUI Element des Observers</param>
        /// <param name="e">Event Parameter der GUI</param>
        private void button_addMasterTag_Click(object sender, EventArgs e)
        {
            if (dataGridView_normalTags.SelectedRows.Count > 0)
            {
                int tagID = (int)dataGridView_normalTags.SelectedRows[0].Cells[0].Value;
                masterTags.Add(tagID);
                normalTags.Remove(tagID);
                updatedTags.Add(tagID);
                dataGridView_masterTags.Rows.Add(tagID, dataGridView_normalTags.SelectedRows[0].Cells[1].Value,
                    dataGridView_normalTags.SelectedRows[0].Cells[2].Value);
                dataGridView_normalTags.Rows.Remove(dataGridView_normalTags.SelectedRows[0]);
            }
        }

        /// <summary>
        /// Wenn der Benutzer auf den "Save" Button klickt, werden alle Tags in diesen Artikel gepeichert (unter Berücksichtigung
        /// ob diese neu oder nur aktualisiert werden und in welche Kategorie diese gehören). Am Ende wird das Tag Fenster geschlossen.
        /// </summary>
        /// <param name="sender">Beobachtes GUI Element des Observers</param>
        /// <param name="e">Event Parameter der GUI</param>
        private void button_save_Click(object sender, EventArgs e)
        {
            int lastID = 0;

            string sql = "SELECT id from search;";
            SQLiteCommand command = new SQLiteCommand(sql, ClientMain.databaseController.getConnection());

            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
                lastID = (int)reader["id"];
            reader.Close();

            foreach (int tagID in newTags)
            {
                int tagCategory;

                if (normalTags.Contains(tagID))
                    tagCategory = 0;
                else
                    tagCategory = 1;

                sql = "INSERT INTO search (id,article_id,tag_id,tag_category,views) "
                            + "VALUES ("
                            + (lastID + 1) + ","
                            + itemID + ","
                            + tagID + ","
                            + tagCategory + ","
                            + " 0);";
                command = new SQLiteCommand(sql, ClientMain.databaseController.getConnection());
                command.ExecuteNonQuery();

                lastID++;
            }

            foreach (int tagID in removedTags)
            {
                sql = "DELETE FROM search WHERE tag_id = " + tagID + " AND article_id = " + itemID + ";";
                command = new SQLiteCommand(sql, ClientMain.databaseController.getConnection());
                command.ExecuteNonQuery();
            }

            foreach (int tagID in updatedTags)
            {
                int tagCategory;

                if (normalTags.Contains(tagID))
                    tagCategory = 0;
                else
                    tagCategory = 1;

                sql = "UPDATE search " +
                "SET tag_category = " + tagCategory +
                " WHERE tag_id = " + tagID + " AND article_id = " + itemID + ";";
                command = new SQLiteCommand(sql, ClientMain.databaseController.getConnection());
                command.ExecuteNonQuery();
            }

            Close();
        }

        /// <summary>
        /// Wenn der Benutzer auf den "Close" Button klickt, wird das Fenster geschlossen.
        /// </summary>
        /// <param name="sender">Beobachtes GUI Element des Observers</param>
        /// <param name="e">Event Parameter der GUI</param>
        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Wenn der Benutzer auf den "Search" Button klickt, wird die Tag Suche ausgeführt.
        /// </summary>
        /// <param name="sender">Beobachtes GUI Element des Observers</param>
        /// <param name="e">Event Parameter der GUI</param>
        private void button_search_Click(object sender, EventArgs e)
        {
            executeSearch();
        }

        /// <summary>
        /// Wenn der Benutzer auf den "Create Tag" Button klickt, wird ein neues Tag auf Basis der Eingabe 
        /// in die Datenbank geschrieben. Dieses Tag kann dann auch von anderen Artikeln theoretisch verwendet werden.
        /// </summary>
        /// <param name="sender">Beobachtes GUI Element des Observers</param>
        /// <param name="e">Event Parameter der GUI</param>
        private void button_createTag_Click(object sender, EventArgs e)
        {
            int lastID = 0;

            string sql = "SELECT id FROM tag;";
            SQLiteCommand command = new SQLiteCommand(sql, ClientMain.databaseController.getConnection());

            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
                lastID = (int)reader["id"];
            reader.Close();

            sql = "INSERT INTO tag (id,tag_name) "
                + "VALUES (" + (lastID + 1) + ", '" + textBox_newTag.Text + "');";
            command = new SQLiteCommand(sql, ClientMain.databaseController.getConnection());
            command.ExecuteNonQuery();

            MessageBox.Show("Tag has been created.", "Info");

            textBox_search.Text = textBox_newTag.Text;
            textBox_newTag.Text = "";
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
        /// Wenn der Benutzer auf den "Remove Tag" Button klickt, wird ein Tag aus der "normal" Tabelle gelöscht.
        /// </summary>
        /// <param name="sender">Beobachtes GUI Element des Observers</param>
        /// <param name="e">Event Parameter der GUI</param>
        private void button_removeTag_Click(object sender, EventArgs e)
        {
            if (dataGridView_normalTags.SelectedRows.Count > 0)
            {
                int tagID = (int)dataGridView_normalTags.SelectedRows[0].Cells[0].Value;
                normalTags.Remove(tagID);
                deleteTag(tagID);
                dataGridView_normalTags.Rows.Remove(dataGridView_normalTags.SelectedRows[0]);
            }
        }

        /// <summary>
        /// Wenn der Benutzer auf den "Remove MasterTag" Button klickt, wird ein Tag aus der "master" Tabelle gelöscht.
        /// </summary>
        /// <param name="sender">Beobachtes GUI Element des Observers</param>
        /// <param name="e">Event Parameter der GUI</param>
        private void button_removeMasterTag_Click(object sender, EventArgs e)
        {
            if (dataGridView_masterTags.SelectedRows.Count > 0)
            {
                int tagID = (int)dataGridView_masterTags.SelectedRows[0].Cells[0].Value;
                masterTags.Remove(tagID);
                normalTags.Add(tagID);

                if(!newTags.Contains(tagID))
                    updatedTags.Add(tagID);

                dataGridView_normalTags.Rows.Add(tagID, dataGridView_masterTags.SelectedRows[0].Cells[1].Value,
                    dataGridView_masterTags.SelectedRows[0].Cells[2].Value);
                dataGridView_masterTags.Rows.Remove(dataGridView_masterTags.SelectedRows[0]);
            }
        }

        /// <summary>
        /// Wenn der Benutzer in der "normal" Tabelle die Taste "DELETE" zusammen mit einem ausgewählten Tag drückt, 
        /// wird die button_removeTag_Click aufgerufen (entfernt den Tag).
        /// </summary>
        /// <param name="sender">Beobachtes GUI Element des Observers</param>
        /// <param name="e">Event Parameter der GUI</param>
        private void dataGridView_normalTags_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                button_removeTag_Click(sender, e);
        }

        /// <summary>
        /// Wenn der Benutzer in der "master" Tabelle die Taste "DELETE" zusammen mit einem ausgewählten Tag drückt, 
        /// wird das jeweilige Tag gelöscht.
        /// </summary>
        /// <param name="sender">Beobachtes GUI Element des Observers</param>
        /// <param name="e">Event Parameter der GUI</param>
        private void dataGridView_masterTags_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dataGridView_masterTags.SelectedRows.Count > 0)
                {
                    int tagID = (int)dataGridView_masterTags.SelectedRows[0].Cells[0].Value;
                    masterTags.Remove(tagID);
                    deleteTag(tagID);
                    dataGridView_masterTags.Rows.Remove(dataGridView_masterTags.SelectedRows[0]);
                }
            }
        }

        /// <summary>
        /// Diese Funktion dient dazu um den speziellen Fall abzufangen dass der entfernte Tag gleichzeitig ein neuer Tag für den 
        /// Artikel ist wodurch dieser ebenfalls auch der anderen Liste gelöscht werden muss. Dies dient dazu, dass das Tag später nicht
        /// doch gespeichert wird.
        /// </summary>
        /// <param name="tagID">ID vom Tag der gelöscht werden soll</param>
        private void deleteTag(int tagID)
        {
            if (newTags.Contains(tagID))
                newTags.Remove(tagID);
            else
                removedTags.Add(tagID);
        }

        /// <summary>
        /// Diese Funktion dient dazu um ein neues Tag in die "normal" Tabelle hinzufügen. Dabei wird überprüft 
        /// ob dieses Tag nicht schon irgendwo existiert.
        /// </summary>
        /// <param name="tagID"></param>
        /// <param name="name"></param>
        private void addNewTag(int tagID, string name)
        {
            if (!checkSelectedTags(tagID))
            {
                dataGridView_normalTags.Rows.Add(tagID, name, getTagViews(tagID));
                newTags.Add(tagID);
                normalTags.Add(tagID);

                if (removedTags.Contains(tagID))
                    removedTags.Remove(tagID); //wenn es schon in removed existiert, wird es dort wieder rausgelöscht
            }
        }

        /// <summary>
        /// Diese Funktion dient dazu festzustellen ob eine bestimmte Tag ID schon in einer bestimmten Liste besteht
        /// </summary>
        /// <param name="tagID">ID des Tag der eventuell hinzugefügt werden soll</param>
        /// <returns>ob der Tag schon irgendwo existiert</returns>
        private bool checkSelectedTags(int tagID)
        {
            return normalTags.Contains(tagID) || masterTags.Contains(tagID) || newTags.Contains(tagID);
        }

        /// <summary>
        /// Führt die Suche nach einem Tag aus. Für die Suche wird nur der Tag Name genommen, welche einmal eine 
        /// exakte Suche nach dem Suchwort macht und einmal eine ähnliche Suche via "LIKE".
        /// </summary>
        private void executeSearch()
        {
            string searchText = textBox_search.Text;
            string sql = "SELECT id,tag_name FROM tag "
                        + "WHERE tag_name = '" + searchText + "' OR tag_name LIKE '%" + searchText + "%';";
            SQLiteCommand command = new SQLiteCommand(sql, ClientMain.databaseController.getConnection());

            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
                dataGridView_tags.Rows.Add(reader["id"], reader["tag_name"]);
            reader.Close();
        }

        /// <summary>
        /// Diese Funktion berechnet die Views (Aufrufe von Besuchern des Hardware Shops), die diesen Tag verwendet haben
        /// um einen Artikel zu verwenden. Damit kann man später erkennen worüber bestimmte Inhalte gesucht werden wodurch man
        /// eventuelle Optimierungen an den Tags vornehmen könnte.
        /// </summary>
        /// <param name="tagID">ID des Tag wovon man die Anzahl der Views haben möchte</param>
        /// <returns>Anzahl der Views</returns>
        private int getTagViews(int tagID)
        {
            string sql = "SELECT views FROM search "
                        + "WHERE tag_id = " + tagID + " AND article_id = " + itemID + ";";
            SQLiteCommand command = new SQLiteCommand(sql, ClientMain.databaseController.getConnection());

            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
                return (int)reader["views"];
            reader.Close();

            return 0;
        }
    }
}
