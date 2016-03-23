/*could be ignored - test file - */
(function(exports){

    console.log("hi");


    exports.test = function(){
        return 'hello world'
    };

})(typeof exports === 'undefined'? this['createWishlist']={}: exports);