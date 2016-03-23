using System;
using System.Windows.Forms;

namespace Hardware_Shop_Client
{
    /// <summary>
    /// Main Klasse des Clients
    /// </summary>
    static class ClientMain
    {
        /// <summary>
        /// Ist der Controller für die Datenbank. Allgemein kümmert sich diese Klasse um den Aufbau der Verbindung.
        /// </summary>
        public static DatabaseController databaseController;
        /// <summary>
        /// Ist das Suchfenster des Clients und kümmert sich um die Suchanfragen des Benutzers.
        /// </summary>
        public static SearchWindow searchWindow;
        /// <summary>
        /// Ist der Editor des Clients und ermöglicht es dem Benutzer Artikel zu erstellen/bearbeiten.
        /// </summary>
        public static EditorWindow editorWindow;
        /// <summary>
        /// Ist das Tag Fenster des Clients innerhalb des Editor Fensters. In diesem kann der Benutzer einem Artikel Tags zuordnen 
        /// oder weitere erstellen.
        /// </summary>
        public static TagWindow tagWindow;

        /// <summary>
        /// Steht für den Namen des eingeloggten Benutzers.
        /// </summary>
        public static string user;
        /// <summary>
        /// Steht für die Rolle des eingeloggten Benutzers.
        /// </summary>
        public static int user_role;

        /// <summary>
        /// Stehen für die möglichen Benutzerrollen. Die Werte entsprechen den Werten aus der Datenbank. Diese Rollen werden
        /// bensonders relevant für den Zugriff auf bestimmte Inalte des Clients.
        /// </summary>
        public readonly static int USER_ROLE_ADMIN = 3, USER_ROLE_MANAGER = 2, USER_ROLE_EDITOR = 1, USER_ROLE_USER = 0;

        [STAThread]
        ///<summary>
        ///Diese Funktion initialisiert die Datenbank (Schnittstelle) und das Login Fenster, 
        ///wo sich der Benutzer einloggen muss.
        ///</summary>
        static void Main()
        {
            databaseController = new DatabaseController();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            searchWindow = new SearchWindow();
            editorWindow = new EditorWindow();

            Application.Run(new LoginWindow());
        }

        /// <summary>
        /// Diese Funktion schließt die laufende Anwendung und trennt die Schnittstelle zur Datenbank.
        /// </summary>
        public static void exit()
        {
            ClientMain.databaseController.getConnection().Close();
            Application.Exit();
        }
    }
}
