var Account = Account || {};

Account.delete = function (Id) {
    bootbox.confirm({
        title: "Cảnh báo",
        message: "Sau khi xóa tất cả sản phẩm thuộc danh mục này sẻ di chuyển đến danh mục No Category",
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
                    url: `/Account/Delete/${Id}`,
                    method: "GET",
                    contentType: 'json',
                    success: function (data) {
                        if (data.deleteResult) {
                            window.location.href = "/Account/Index/";
                        }
                        else {
                            bootbox.alert("Invalid Id User");
                        }
                    }
                });
            }
        }
    });
};

$(function () {
    $("#Province").change(function () {
        var url = "/Account/GetDistrictById";
        var ddlsource = "#Province";
        $.getJSON(url, { id: $(ddlsource).val() }, function (data) {
            var items = '';
            $("#DistrictId").empty();
            $.each(data, function (i, row) {
                items += "<option value='" + row.value + "'>" + row.text + "</option>";
            });
            $("#District").html(items);

            var url = "/Account/GetWardById";
            var DistrictVal = "#District";
            $.getJSON(url, { id: $(DistrictVal).val() }, function (data) {
                var items = '';
                $("#WardId").empty();
                $.each(data, function (i, row) {
                    items += "<option value='" + row.value + "'>" + row.text + "</option>";
                });
                $("#Ward").html(items);
            });
        });
    });
}
);
$(function () {
    $("#District").change(function () {
        var url = "/Account/GetWardById";
        var ddlsource = "#District";
        $.getJSON(url, { id: $(ddlsource).val() }, function (data) {
            var items = '';
            $("#WardId").empty();
            $.each(data, function (i, row) {
                items += "<option value='" + row.value + "'>" + row.text + "</option>";
            });
            $("#Ward").html(items);
        });
    });
}
);
$(".custom-file-input").on("change", function () {
    var fileName = $(this).val().split("\\").pop();
    $(this).siblings(".custom-file-label").addClass("selected").html(fileName);
});

$(document).ready(function () {
    $("#IndexAccount").dataTable(
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

