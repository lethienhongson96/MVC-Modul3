var Role = Role || {};

Role.delete = function (id) {
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
                    url: `/Role/Delete/${id}`,
                    method: "GET",
                    contentType: 'json',
                    success: function (data) {
                        if (data.deleteResult) {
                            window.location.href = "/Role/Index/";
                        } else {
                            bootbox.dialog("Invalid Role Id");
                        }
                    }
                });
            }
        }
    });
}

$(document).ready(function () {
    $("#IndexRole").dataTable(
        {
            "columnDefs": [
                {
                    "targets": 0,
                    "orderable": false,
                    "searchable": false
                }
            ]
        }
    );
});