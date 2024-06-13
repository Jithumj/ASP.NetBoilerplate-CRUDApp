function deleteQuote(id) {
    if (confirm("Are you sure you want to delete this quote?")) {
        $.ajax({
            type: "POST",
            url: "@Url.Action("ShowQuotes", "CrudView")",
            data: { id: id },
             success: function (data) {
                 alert("Quote deleted successfully!");
                 // Reload the table data
                 $.ajax({
                     type: "GET",
                     url: "~/iConnect.Web.Mvc/Views/CrudView/ShowQuotes",
                     success: function (data) {
                         $("#CrudTable").html(data);
                     }
                 });
             }
        });
    }
}