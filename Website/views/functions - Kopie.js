$(document).ready(function(){
    var searchTerm;
    $("form").submit(function(event){
        searchTerm=$("#searchTerm").val();
        $("form").text(searchTerm).show();
        event.preventDefault();
    });

    $('#create').click(function() {
        console.log("createbuttontestworks");
        var myTableDiv = document.getElementById("myDynamicTable");
        var table = document.createElement('TABLE');
        table.border='1';
        var tableBody = document.createElement('TBODY');
        table.appendChild(tableBody);
        for (var i=0; i<3; i++){
            var tr = document.createElement('TR');
            ///////////////////test
            ////////////
            tableBody.appendChild(tr);
            for (var j=0; j<4; j++){
                var td = document.createElement('TD');
                td.width='75';
                td.appendChild(document.createTextNode("Cell " + i + ", " + articleList.id +" " + j));
                tr.appendChild(td);
            }
        }
        myTableDiv.appendChild(table);
    });

    $('#add').click(function() {
        var myName = document.getElementById("name");
        var myName = document.getElementById("name");
        var age = document.getElementById("age");
        var table = document.getElementById("myTableData");

        var rowCount = table.rows.length;
        var row = table.insertRow(rowCount);

        row.insertCell(0).innerHTML = '<input type="button" value = "Delete" class="delete">';
        row.insertCell(1).innerHTML = myName.value;
        row.insertCell(2).innerHTML = age.value;
    });

    $(document).on('click','.delete', function() {
        console.log("deletebutton pressed");
        var index = $(this).closest('tr').index();
        var table = document.getElementById("myTableData");
        table.deleteRow(index);
    });

    console.log("Page load finished");
});

