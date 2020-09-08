var WatchOrderDetail = WatchOrderDetail || {};

WatchOrderDetail.delete = function (OrderId,ProductId) {
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
                    url: `/OrderDetail/Delete/${OrderId}/${ProductId}`,
                    method: "GET",
                    contentType: 'json',
                    success: function (data) {
                        if (data.result > 0) {
                            window.location.href = "/OrderDetail/WatchOrderDetail/" + OrderId;
                        }
                    }
                });
            }
        }
    });
}

$(document).ready(function () {
    $("#ProductIndex").dataTable(
        {
            "columnDefs": [
                {
                    "targets": 6,
                    "orderable": false,
                    "searchable": false
                },
                {
                    "targets": 3,
                    "orderable": false,
                    "searchable": false
                }
            ]
        }
    );
});