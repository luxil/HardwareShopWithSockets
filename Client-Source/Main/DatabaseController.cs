using System.Data.SQLite;
using System.IO;

namespace Hardware_Shop_Client
{
    /// <summary>
    /// Datenbank Controller des Clients der sich um den Verbindungsaufbau zur Datenbank kümmert.
    /// </summary>
    class DatabaseController
    {
        /// <summary>
        /// Stellt das Datenbank Verbindungsobjekt dar, worüber Anfragen/Commits durchgeführt werden können.
        /// </summary>
        private SQLiteConnection m_dbConnection;

        /// <summary>
        /// Erstellt eine neue Datenbank Schnittstelle. Die Schnittstelle bezieht sich auf eine locale .db Datei.
        /// </summary>
        public DatabaseController()
        {
            string path = "../../../../DB.sql";

            if (!File.Exists(path))
                path = "DB.sql";

            m_dbConnection = new SQLiteConnection("Data Source=" + path + ";Version=3;");
            m_dbConnection.Open();
        }

        /// <summary>
        /// Getter für die Datenbank Schnittstelle, um an anderen Stelle auf diese zuzugreifen um commits an die Datenbank zu leiten.
        /// </summary>
        /// <returns>Datenbank Schnittstelle</returns>
        public SQLiteConnection getConnection()
        {
            return m_dbConnection;
        }
    }
}
