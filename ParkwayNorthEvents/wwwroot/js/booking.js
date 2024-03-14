let pType = document.getElementById("bookingType");
let pBalance = document.getElementById("bookingBalance");
let pStatus = document.getElementById("bookingStatus");
let pDate = document.getElementById("bookingDate");
let pTime = document.getElementById("bookingTime");
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

function DeleteBooking(url) {
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
                        document.getElementById("OnPostDelete").submit();
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
    pType.style = "display: none;";
    pBalance.style = "display: none;";
    pStatus.style = "display: none;";
    pDate.style = "display: none;";
    pTime.style = "display: none;";
    pDescription.style = "display: none;";
    editBookingForm.style = "display: block;";
}

function CancelBookingChanges() {
    // hide booking displays
    eventTitle.style = "display: block;"
    pType.style = "display: block;";
    pBalance.style = "display: block;";
    pStatus.style = "display: block;";
    pDate.style = "display: block;";
    pTime.style = "display: block;";
    pDescription.style = "display: block;";
    editBookingForm.style = "display: none;";
}

function SaveBookingChanges(id) {
    // validate all fields
    // if invalid display toast or something
    // make controller api call to update booking

    var title = document.getElementById("eventTitleUpdate").value;
    var date = document.getElementById("datepicker").value;
    var type = document.getElementById("typeUpdate").value;
    var description = document.getElementById("descriptionUpdate").value;
    var status = document.getElementById("statusUpdate").value;
    var balance = document.getElementById("balanceUpdate").value;
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
    if (date == "") {
        valid = false;
        var dateElement = document.getElementById("datepicker");
        dateElement.classList.add("bg-danger");
    }
    if (balance == "") {
        valid = false;
        var balanceElement = document.getElementById("balanceUpdate");
        balanceElement.classList.add("bg-danger");
    }
    if (status == "") {
        valid = false;
        var statusElement = document.getElementById("balanceUpdate");
        statusElement.classList.add("bg-danger");
    }
    if (valid == true) {
        //string id, string title, int type, string date, string description
        var url = String("/api/booking/details?id=" + encodeURIComponent(id) + "&&title=" + encodeURIComponent(title) + "&&type=" + encodeURIComponent(type) + "&&date=" + encodeURIComponent(date) + "&&description=" + encodeURIComponent(description) + "&&balance=" + encodeURIComponent(balance) + "&&status=" + encodeURIComponent(status));
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