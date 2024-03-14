let pDescription = document.getElementById("bookingDescription");
let bookingCard = document.getElementById("eventInfo");
let eventTitle = document.getElementById("eventTitle");
let editBookingForm = document.getElementById("editBookingForm");

function Delete(url) {
    swal({
        title: "Are you sure you want to delete?",
        text: "This action cannot be undone!",
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
                        location.reload();
                    }
                    else {
                        toastr.error(data.message);
                    }
                }
            });
        }
    });
}

function EditBooking() {
    // hide booking displays
    eventTitle.style = "display: none;"
    pDescription.style = "display: none;";
    editBookingForm.style = "display: block;";
}

function CancelBookingChanges() {
    // hide booking displays
    eventTitle.style = "display: block;"
    pDescription.style = "display: block;";
    editBookingForm.style = "display: none;";
}

function SaveBookingChanges(id) {
    // validate all fields
    // if invalid display toast or something
    // make controller api call to update booking

    var title = document.getElementById("eventTitleUpdate").value;
    var description = document.getElementById("descriptionUpdate").value;
    var valid = true;
    if (title == "") {
        valid = false;
        var titleElement = document.getElementById("eventTitleUpdate");
        titleElement.classList.add("bg-danger");
    }
    if (description == "") {
        valid = false;
        var descriptionElement = document.getElementById("descriptionUpdate");
        descriptionElement.classList.add("bg-danger");
    }
    if (valid == true) {
        //string id, string title, int type, string date, string description
        var url = String("/api/userBooking/details?id=" + encodeURIComponent(id) + "&&title=" + encodeURIComponent(title) + "&&description=" + encodeURIComponent(description));
        url.replaceAll(' ', '%20');
        $.ajax({
            type: 'POST',
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
        });
    }

}