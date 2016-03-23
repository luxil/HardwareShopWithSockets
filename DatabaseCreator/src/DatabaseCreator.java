
import java.io.File;
import java.io.IOException;
import java.sql.*;
import java.util.logging.Level;
import java.util.logging.Logger;

public class DatabaseCreator {

    private static Connection c;
    private static Statement stmt;

    /**
     * Erstellt ein neues Database Creator Objekt. Dieses Objekt ist für
     * das Erstellen der .db Datei zuständig.
     * 
     * @throws ClassNotFoundException
     * @throws SQLException
     * @throws IOException 
     */
    public DatabaseCreator() throws ClassNotFoundException, SQLException, IOException {
        String path = "../DB.sql";
        File file = new File(path);
        path = file.getCanonicalPath();

        if (path.contains("DatabaseCreator")) {
            path = "../../DB.sql";
            file = new File(path);
        }
        file.delete();

        Class.forName("org.sqlite.JDBC");
        c = DriverManager.getConnection("jdbc:sqlite:" + path);
        c.setAutoCommit(false);
    }

    /**
     * Diese Methode füllt die Datenbank mit den Tables.
     * 
     * @throws Exception 
     */
    private void builtData() throws Exception {
        stmt = c.createStatement();
        String sql = "CREATE TABLE user "
                + "(id              INT     PRIMARY KEY     NOT NULL,"
                + " user_name       TEXT                    NOT NULL,"
                + " password        TEXT                    NOT NULL,"
                + " role            INT                     NOT NULL)";
        stmt.executeUpdate(sql);

        stmt = c.createStatement();
        sql = "CREATE TABLE article "
                + "(id             INT      PRIMARY KEY     NOT NULL,"
                + " category       INT                      ,"
                + " subcategory    INT                      ,"
                + " manufacturer   INT                      ,"
                + " user           INT                      NOT NULL,"
                + " status         INT                      NOT NULL,"
                + " title          TEXT                     ,"
                + " url            TEXT                     ,"
                + " name           TEXT                     ,"
                + " date           TEXT                     ,"
                + " edit           TEXT                     NOT NULL,"
                + " views          INT                      NOT NULL)";
        stmt.executeUpdate(sql);
        
        stmt = c.createStatement();
        sql = "CREATE TABLE content_input "
                + "(id             INT      PRIMARY KEY     NOT NULL,"
                + " article_id     TEXT                     NOT NULL,"
                + " value1         INT                      NOT NULL,"
                + " value2         TEXT                     NOT NULL)";
        stmt.executeUpdate(sql);
        
        stmt = c.createStatement();
        sql = "CREATE TABLE input "
                + "(id             INT      PRIMARY KEY     NOT NULL,"
                + " category_id    INT                      NOT NULL,"
                + " value1         TEXT                     NOT NULL)";
        stmt.executeUpdate(sql);

        stmt = c.createStatement();
        sql = "CREATE TABLE category "
                + "(id                INT      PRIMARY KEY     NOT NULL,"
                + " category_name     TEXT                     NOT NULL)";
        stmt.executeUpdate(sql);

        stmt = c.createStatement();
        sql = "CREATE TABLE subcategory "
                + "(id                INT      PRIMARY KEY     NOT NULL,"
                + " subcategory_name  TEXT                     NOT NULL)";
        stmt.executeUpdate(sql);

        stmt = c.createStatement();
        sql = "CREATE TABLE manufacturer "
                + "(id                  INT      PRIMARY KEY     NOT NULL,"
                + " manufacturer_name   TEXT                     NOT NULL)";
        stmt.executeUpdate(sql);
        
        stmt = c.createStatement();
        sql = "CREATE TABLE status "
                + "(id                  INT      PRIMARY KEY     NOT NULL,"
                + " status_name         TEXT                     NOT NULL)";
        stmt.executeUpdate(sql);

        stmt = c.createStatement();
        sql = "CREATE TABLE search "
                + "(id              INT      PRIMARY KEY     NOT NULL,"
                + " article_id      INT                      NOT NULL,"
                + " tag_id          INT                      NOT NULL,"
                + " tag_category    INT                      NOT NULL,"
                + " views           INT                      NOT NULL)";
        stmt.executeUpdate(sql);

        stmt = c.createStatement();
        sql = "CREATE TABLE tag "
                + "(id             INT      PRIMARY KEY     NOT NULL,"
                + " tag_name       TEXT                     NOT NULL)";
        stmt.executeUpdate(sql);

        stmt = c.createStatement();
        sql = "CREATE TABLE wishlist "
                + "(id              INT      PRIMARY KEY     NOT NULL,"
                + " user_id         INT                      NOT NULL,"
                + " article_id      INT                      NOT NULL)";
        stmt.executeUpdate(sql);
        
        stmt = c.createStatement();
        sql = "CREATE TABLE content_access "
                + "(id             INT      PRIMARY KEY     NOT NULL,"
                + " article_id     INT                      NOT NULL,"
                + " user_id        INT                      NOT NULL,"
                + " date           TEXT                     NOT NULL)";
        stmt.executeUpdate(sql);
    }

    /**
     * Diese Methode ist für den default Inhalt der Datenbank zuständig und ordnet
     * das den jeweiligen Tables zu.
     * 
     * @throws Exception 
     */
    private void initStartContent() throws Exception {
        stmt = c.createStatement();
        String sql = "INSERT INTO user (id,user_name,password,role) "
                + "VALUES (0, 'n/a', '12345', 0);";
        stmt.executeUpdate(sql);
        
        stmt = c.createStatement();
        sql = "INSERT INTO user (id,user_name,password,role) "
                + "VALUES (1, 'Admin', 'root', 3);";
        stmt.executeUpdate(sql);
        
        stmt = c.createStatement();
        sql = "INSERT INTO article (id,category,subcategory,manufacturer,user,status,title,url,name,date,edit,views) "
                + "VALUES (0, 1, 1, 1, 1, 0, 'Test1', 'test1', 'Test Entry 1', '15-11-04', '15-11-04-00-11-57', 0);";
        stmt.executeUpdate(sql);
        
        stmt = c.createStatement();
        sql = "INSERT INTO article (id,category,subcategory,manufacturer,user,status,title,url,name,date,edit,views) "
                + "VALUES (1, 2, 1, 2, 1, 1, 'Test2', 'test2', 'Test Entry 2', '15-11-04', '15-11-04-00-11-43', 0);";
        stmt.executeUpdate(sql);
        
        stmt = c.createStatement();
        sql = "INSERT INTO input (id,category_id,value1) "
                + "VALUES (0, 1, 'Test1');";
        stmt.executeUpdate(sql);
        
        stmt = c.createStatement();
        sql = "INSERT INTO category (id,category_name) "
                + "VALUES (0, '');";
        stmt.executeUpdate(sql);
        
        stmt = c.createStatement();
        sql = "INSERT INTO category (id,category_name) "
                + "VALUES (1, 'Category0');";
        stmt.executeUpdate(sql);
        
        stmt = c.createStatement();
        sql = "INSERT INTO category (id,category_name) "
                + "VALUES (2, 'Category1');";
        stmt.executeUpdate(sql);
        
        stmt = c.createStatement();
        sql = "INSERT INTO subcategory (id,subcategory_name) "
                + "VALUES (0, '');";
        stmt.executeUpdate(sql);
        
        stmt = c.createStatement();
        sql = "INSERT INTO subcategory (id,subcategory_name) "
                + "VALUES (1, 'SubCategory0');";
        stmt.executeUpdate(sql);
        
        stmt = c.createStatement();
        sql = "INSERT INTO manufacturer (id,manufacturer_name) "
                + "VALUES (0, '');";
        stmt.executeUpdate(sql);
        
        stmt = c.createStatement();
        sql = "INSERT INTO manufacturer (id,manufacturer_name) "
                + "VALUES (1, 'Intel');";
        stmt.executeUpdate(sql);
        
        stmt = c.createStatement();
        sql = "INSERT INTO manufacturer (id,manufacturer_name) "
                + "VALUES (2, 'AMD');";
        stmt.executeUpdate(sql);
        
        stmt = c.createStatement();
        sql = "INSERT INTO status (id,status_name) "
                + "VALUES (0, 'Work in progress');";
        stmt.executeUpdate(sql);
        
        stmt = c.createStatement();
        sql = "INSERT INTO status (id,status_name) "
                + "VALUES (1, 'Released');";
        stmt.executeUpdate(sql);
        
        stmt = c.createStatement();
        sql = "INSERT INTO status (id,status_name) "
                + "VALUES (2, 'Archived');";
        stmt.executeUpdate(sql);
        
        stmt = c.createStatement();
        sql = "INSERT INTO tag (id,tag_name) "
                + "VALUES (0, 'CPU');";
        stmt.executeUpdate(sql);
        
        stmt = c.createStatement();
        sql = "INSERT INTO tag (id,tag_name) "
                + "VALUES (1, 'GPU');";
        stmt.executeUpdate(sql);
        
        stmt = c.createStatement();
        sql = "INSERT INTO search (id,article_id,tag_id,tag_category,views) "
                + "VALUES (0, 0, 0, 0, 5);";
        stmt.executeUpdate(sql);
        
        stmt = c.createStatement();
        sql = "INSERT INTO search (id,article_id,tag_id,tag_category,views) "
                + "VALUES (1, 0, 1, 1, 15);";
        stmt.executeUpdate(sql);
    }

    /**
     * Main-Methode des Database Creator, der die Verbindung aufbaut und
     * später wieder schließt.
     * 
     * @param args 
     */
    public static void main(String args[]) {
        try {
            DatabaseCreator creator = new DatabaseCreator();
            creator.builtData();
            creator.initStartContent();
            stmt.close();
            c.commit();
            c.close();
            System.out.println("Database successfully created.");
        } catch (Exception e) {
            Logger.getLogger(DatabaseCreator.class.getName()).log(Level.SEVERE, e.getMessage());
        }
    }
}
