function DeleteImage(url) {
    swal({
        title: "Are you sure you want to delete?",
        text: "This action can't be undone!",
        icon: "warning",
        buttons: true,
        dangerMode: true
    }).then((willDelete) => {
        if (willDelete) {
            $.ajax({
                type: 'DELETE',
                url: url,
                success: function (data) {
                    if (data.success) {
                        toastr.success(data.message);
                        document.location.reload();
                    }
                    else {
                        toastr.error(data.message);
                    }
                }
            })
        }
    })
}

function CantDelete() {
    swal({
        title: "Can't delete main image for an event gallery",
        text: "Would you like to replace the image?",
        icon: "warning",
        buttons: true
    }).then((willReplace) => {
        if (willReplace) {
            var input = document.getElementById("hiddenInput");
            var formButton = document.getElementById("replace");
            input.onchange = e => {
                // TODO - size check
                formButton.click();
            }
            input.click();
        }
    })
}