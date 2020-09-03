var Category = Category || {};

Category.delete = function (id) {
    bootbox.confirm({
        title: "Warning",
        message: "are you sure?",
        buttons: {
            cancel: {
                label: '<i class="fa fa-times"></i> No'
            },
            confirm: {
                label: '<i class="fa fa-check"></i> Yes'
            }
        },
        callback: function (result) {
            if (result) {
                $.ajax({
                    url: `/Category/Delete/${id}`,
                    method: "GET",
                    contentType: 'json',
                    success: function (data) {
                        if (data.result > 0) {
                            window.location.href = "/Category/Index/";
                        }
                    }
                });
            }
        }
    });
}

$(document).ready(function () {
    $("#CategoryIndex").dataTable(
        {
            "columnDefs": [
                {
                    "targets": 3,
                    "orderable": false,
                    "searchable": false
                }
            ]
        }
    );
});