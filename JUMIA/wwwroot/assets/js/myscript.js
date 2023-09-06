
function show() {$.ajax({
    url: "https://localhost:44391/api/API/getproduct",
    type: "get",
    contentType: "application/json",
    success: function (result, status, xhr) {

        console.log(result);
        $("tbody").html("");
        $.each(result, function (index, value) {
            $("tbody").append($("<tr>"));
            appendElement = $("tbody tr").last();
            appendElement.append($("<td>").html(value["id"]));
            appendElement.append($("<td>").html(value["name"]));
            appendElement.append($("<td>").html(value["price"]));
            appendElement.append($("<td>").html(value["quantity"]));
            appendElement.append($("<td>").html(value["categName"]));
            appendElement.append($("<td>").html("<a class='btn btn-primary id="+ value["id"]+" ' \" > Delete</a >")); 
            
        });
        
    },
    error: function (xhr, status, error) {
        console.log(xhr)
    }
});
}

$("table").on("click", ".btn-primary", function () {
    console.log($(this).parents("tr").find("td:nth-child(1)")) ;
    var reservationId = $(this).parents("tr").find("td:nth-child(1)").text();

    $.ajax({
        url: "https://localhost:44391/api/API/deleteproduct/" + reservationId,
        type: "delete",
        contentType: "application/json",
        success: function (result, status, xhr) {
            show();
        },
        error: function (xhr, status, error) {
            console.log(xhr)
        }
    });
});










show();


$("#Create").click(function (e) {
    $.ajax({
        url: "https://localhost:44391/api/API/createproduct",
        
        type: "post",
        contentType: "application/json",
        data: JSON.stringify({
            
            Name: $("#name").val(),
            Price: $("#price").val(),
            Quantity: $("#quantity").val(),
            CategName: $("#categName").val()
        }),
        success: function (result, status, xhr) {
            alert("ok done")
            show();
        },
        error: function (xhr, status, error) {
            
            console.log(xhr)
        }
    });
});

