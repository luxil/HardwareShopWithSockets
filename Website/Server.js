/*
Server.js
Erstellt von Linh Do
verwendete Quelle: https://www.codementor.io/nodejs/tutorial/build-website-from-scratch-using-expressjs-and-bootstrap
 */

//loading the dependencies

var express = require("express");
var app = express();
var http = require('http').createServer(app);
var io = require('socket.io')(http);
var router = express.Router();
var $ = require('jquery');

//in the folder 'views' are the html-files
//var path = __dirname + '/views/';
var path = require ('path');
app.use(express.static(path.join(__dirname + '.../views')));
app.set('view engine', 'ejs');

var sqlite3 = require('sqlite3').verbose();
var dbFile = "./DB.sql";
var db = new sqlite3.Database(dbFile);

var articleList = [];
var wishLists = [];
var wishListNumber = 0;


//diese Operationen funktionieren bisher serverseitig aber nicht clientseitig
var operations = {
    deleteWishlistArt : function(wishlist_id){
    var statement = db.prepare('DELETE FROM `wishlist` WHERE `id`==(?)');
    statement.run(wishlist_id);
    statement.finalize();
    },

    createWLF : function (id) {
        wishListNumber = 1;
        console.log("WishlistNR " + wishListNumber);
        db.serialize(function() {
            db.each("SELECT id FROM wishlist ", function(err, row) {
                wishListNumber++;
                console.log("WishlistNR " + wishListNumber);
                console.log("WishlistID " + row.id);
            });
            db.serialize(function() {
                var statement = db.prepare('INSERT INTO `wishlist` (`id`, `user_id`, `article_id`) ' +
                    'VALUES (?, ?, ?)');
                console.log("WishlistNR " + wishListNumber);
                statement.run(id, 1, 0);
                statement.finalize();
            })
        });

        console.log("CREATEWLF");
    }
}
//zum Test der Funktionen diese auskommentieren und die passenden Zahlen einsetzen
//operations.deleteWishlistArt(1);
//operations.createWLF(3);

//deleteWishlistArt(0);
exports.operations = operations;


db.serialize(function() {
    //all articles as an array
    db.each("SELECT article.id, article.views, category.category_name, status.status_name, " +
        "subcategory.subcategory_name, manufacturer.manufacturer_name, user.user_name," +
        "article.title, article.date, article.edit "
        + " FROM article "
        + "INNER JOIN status ON article.status = status.id "
        + "INNER JOIN subcategory ON article.subcategory = subcategory.id "
        + "INNER JOIN manufacturer ON article.manufacturer = manufacturer.id "
        + "INNER JOIN user ON article.user = user.id "
        + "INNER JOIN category ON article.category = category.id", function(err, row) {
        console.log("Article ID " + row.id + ", " + "catName: " + " " + row.category_name +
            ", staName: " + row.status_name+ ", title: "+ row.title);
        articleList.push({id: row.id, views: row.views, userName: row.user_name,
            catName: row.category_name, subcatName: row.subcategory_name,
            manuName: row.manufacturer_name, title: row.title, date: row.date, edit: row.edit,
            staName: row.status_name})
    })

    //all wishlists as an array

    db.each("SELECT id, user_id, article_id "
        + " FROM wishlist ", function(err, row) {
        //console.log("Wishlist ID " + row.id);
        wishLists.push({id: row.id, user_id: row.user_id, article_id: row.article_id})
        wishListNumber++;
        //console.log("WishlistNR " + wishListNumber);
    })
});
//db.close();
exports.articleList =  articleList;
exports.wishLists = wishLists;

//defined the Router middle layer, which will be executed before any other routes.
//This route will be used to print the type of HTTP request the particular Route
//is referring to.
router.use(function (req,res,next) {
    console.log("/" + req.method);
    //Once the middle layer is defined, you must pass "next()"
    //so that next router will get executed.
    next();
});

//sendFile()" function is for sending files to a web browser
router.get("/",function(req,res){
    //res.sendFile(path + "index.html");
    res.render('index', {
        title: 'The index page!',
        articleList: articleList
    });
});


router.get("/wishlist",function(req,res){
    //res.sendFile(path + "wishlist.html");
    res.render('wishlist', {
        wishLists: wishLists,
        articleList: articleList,
        operations: operations
        //deleteWishlistArt: deleteWishlistArt
    });
});

router.get("/contact",function(req,res){
    res.render('contact', {});
});

//use the Routes we have defined above
app.use("/",router);
app.use(express.static('views'));

//we can assign the routes in order, so the last one will
//get executed when the incoming request is not matching any route.
//in this case its the 404.html
app.use("*",function(req,res){
    res.render('404');
});

io.on('connection', function(socket){
    /*
    socket.on('addPlayer',function(data){
        var user = {socket:socket,id:socket.id,score:0,name:data || "noUser"};
        users.push(user);
        console.log(user.name + ' connected with socketID: ' + user.id);
    });
    */

    socket.emit('news', { hello: 'world' });
    socket.on('my other event', function (data) {
        console.log("Hallo");
    });
});


/*
app.listen(3000,function(){
    console.log("Live at Port 3000");
});
*/

var createWishlist = require('./views/createWishlist'),
    sys = require('sys');

sys.puts(createWishlist.test());

http.listen(3000, function(){
    console.log('listening on *:3000');
});