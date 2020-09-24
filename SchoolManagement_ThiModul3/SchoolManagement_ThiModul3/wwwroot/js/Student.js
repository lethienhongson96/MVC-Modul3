var Student = Student || {};

Student.delete = function (id) {
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
                    url: `/Student/Delete/${id}`,
                    method: "GET",
                    contentType: 'json',
                    success: function (data) {
                        if (data > 0) {
                            window.location.href = "/ClassRoom/Index/";
                        } else {
                            bootbox.dialog("Invalid Role Id");
                        }
                    }
                });
            }
        }
    });
}