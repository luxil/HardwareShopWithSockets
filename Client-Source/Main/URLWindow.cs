using System;
using System.Windows.Forms;

namespace Hardware_Shop_Client.Main
{
    /// <summary>
    /// Dies ist die GUI Klasse zum URL Fenster im Editor Fenster. Das URL Fenster formatiert die URL vom Artikel um eventuelle 
    /// Fehler zu verhindern.
    /// </summary>
    public partial class URLWindow : Form
    {
        /// <summary>
        /// Interne Initialisierung der GUI Elemente des Fensters.
        /// </summary>
        public URLWindow()
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
        }

        /// <summary>
        /// Diese Funktion wird ausgeführt wenn das Fenster geöffnet wird.
        /// </summary>
        /// <param name="e">Internes Argument welches weitere Infos zu diesem "Öffnen" Event hält</param>
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            textBox_urlName.Text = ClientMain.editorWindow.textBox_url.Text;
        }

        /// <summary>
        /// Wenn der Benutzer auf den "Save" Button klickt, wird die Eingabe (URL) formatiert und die 
        /// interne GUI Close() Funktion aufgerufen.
        /// </summary>
        /// <param name="sender">Beobachtes GUI Element des Observers</param>
        /// <param name="e">Event Parameter der GUI</param>
        private void button_save_Click(object sender, EventArgs e)
        {
            string[] url = textBox_urlName.Text.Split(new Char[] { ' ' });
            string newURL = "";

            foreach (string part in url)
            {
                if (newURL == "")
                    newURL = part;
                else
                    newURL = newURL + "_" + part;
            }

            ClientMain.editorWindow.textBox_url.Text = newURL;
            Close();
        }

        /// <summary>
        /// Wenn der Benutzer auf den "Close" Button klickt, wird die interne GUI Close() Funktion aufgerufen.
        /// </summary>
        /// <param name="sender">Beobachtes GUI Element des Observers</param>
        /// <param name="e">Event Parameter der GUI</param>
        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Wenn der Benutzer im Eingabe TextFeld die Taste "Enter" drückt, wird ein Event gefeuert, welches die Funktion
        /// button_save_Click() aufruft.
        /// </summary>
        /// <param name="sender">Beobachtes GUI Element des Observers</param>
        /// <param name="e">Event Parameter der GUI</param>
        private void textBox_urlName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button_save_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}
