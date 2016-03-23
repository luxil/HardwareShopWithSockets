$(document).ready(function(){
    var searchTerm;
    $("form").submit(function(event){
        searchTerm=$("#searchTerm").val();
        $("form").text(searchTerm).show();
        event.preventDefault();
    });

    $('#create').click(function() {
        console.log("createbuttontestworks");

    });

    $('#add').click(function() {
        var myName = document.getElementById("name");
        var age = document.getElementById("age");
        var table = document.getElementById("myTableData");

        var rowCount = table.rows.length;
        var row = table.insertRow(rowCount);

        row.insertCell(0).innerHTML = '<input type="button" value = "Delete" class="delete">';
        row.insertCell(1).innerHTML = myName.value;
        row.insertCell(2).innerHTML = age.value;
    });

    $('.addtw').click(function() {
        var index = $(this).closest('tr').index();
        var table = document.getElementById("myTableData");
        //document.getElementById('addtw_' + (index-1)).value = "Added";
        //alert(createWishlist.test());
        alert(index + " Added to Wishlist");
    });



    $(document).on('click','.delete', function() {
        console.log("deletebutton pressed");
        var index = $(this).closest('tr').index();
        var table = document.getElementById("myTableData");
        table.deleteRow(index);
    });

    console.log("Page load finished");

    $('.deletetw').click(function() {
        var index = $(this).closest('tr').index();
        var table = document.getElementById("wishlistTable");
        table.deleteRow(index);

        alert("index:" + index);
    });
});

