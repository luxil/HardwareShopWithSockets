/*testFile - ignore it*/
var sqlite3 = require('sqlite3').verbose();
var dbFile = "./DB.sql";

//Exist Test
///////////


var db = new sqlite3.Database(dbFile);

db.serialize(function() {
    db.each("SELECT id, category FROM article", function(err, row) {
        console.log(row.id + ": " + row.id + " " + row.category);
    });
});

db.close();