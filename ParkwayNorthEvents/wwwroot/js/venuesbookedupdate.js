let pNoVenue = document.getElementById("pNoVenue");
let hiddenVenueForm = document.getElementById("AddNewVenueForm");
let addVenuePlus = document.getElementById("AddVenuePlus");

let editVenueForm = document.getElementById("EditVenueForm");
let editVenueName = document.getElementById("EditVenueName");
let editVenuePhoneNumber = document.getElementById("EditVenuePhoneNumber");
let venueHidden = null;


function AddVenue(id) {
    if (pNoVenue !== null) {
        pNoVenue.style = "display: none;";
    }
    addVenuePlus.style = "display: none;";
    // add form
    hiddenVenueForm.style = "display: block;";
}

function SaveAddVenue(bookingId, venueBookedId) {
    // validate
    // create url
    // make api call 
    var valid = true;
    var venueName = document.getElementById("AddVenueName").value;
    var venuePhoneNumber = document.getElementById("AddVenuePhoneNumber").value;
    if (venueName == "") {
        valid = false;
        var venueNameElement = document.getElementById("AddVenueName");
        venueNameElement.classList.add("bg-danger");
    }
    if (venuePhoneNumber == "" || venuePhoneNumber.length != 10) {
        valid = false;
        var venuePhoneNumberElement = document.getElementById("AddVenuePhoneNumber");
        venuePhoneNumberElement.classList.add("bg-danger");
    }

    if (valid == true) {
        //string venueBookedId, string venueId, string bookingId, string status, string venuePhonenumber, string venueName
        var url = String("/api/venuesBooked/details?venueBookedId=" + encodeURIComponent(venueBookedId) + "&&bookingId=" + encodeURIComponent(bookingId)
            + "&&status=New" + "&&venuePhoneNumber=" + encodeURIComponent(venuePhoneNumber) + "&&venueName=" + encodeURIComponent(venueName));
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

function CancelAddVenue() {
    if (pNoVenue !== null) {
        pNoVenue.style = "display: block;";
    }
    addVenuePlus.style = "display: block;";
    hiddenVenueForm.style = "display: none;";
}

function EditVenue(venueBookedId, bookingId) {
    if (venueHidden != null) {
        venueHidden.style = "display: block;";
    }
    venueHidden = document.getElementById(venueBookedId);
    venueHidden.style = "display: none;";
    editVenueForm.style = "display: block";
    var venueSaveButton = document.getElementById("saveVenueLink");
    venueSaveButton.setAttribute("onclick", "SaveVenueEdit('" + venueBookedId + "', '" + bookingId + "')");
    editVenuePhoneNumber.value = document.getElementById("VenuePhone" + venueBookedId).innerHTML;
    editVenueName.value = document.getElementById("VenueName" + venueBookedId).innerHTML;
}

function SaveVenueEdit(venueBookedId, bookingId) {
    // validate
    // create url
    // make api call 
    var valid = true;
    var venueName = editVenueName.value;
    var venuePhoneNumber = editVenuePhoneNumber.value;
    if (venueName == "") {
        valid = false;
        editVenueName.classList.add("bg-danger");
    }
    if (venuePhoneNumber == "" || venuePhoneNumber.length != 10) {
        valid = false;
        editVenuePhoneNumber.classList.add("bg-danger");
    }

    if (valid == true) {
        //string venueBookedId, string venueId, string bookingId, string status, string venuePhonenumber, string venueName
        var url = String("/api/venuesBooked/details?venueBookedId=" + encodeURIComponent(venueBookedId) + "&&bookingId=" + encodeURIComponent(bookingId)
            + "&&status=New" + "&&venuePhoneNumber=" + encodeURIComponent(venuePhoneNumber) + "&&venueName=" + encodeURIComponent(venueName));
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

function CancelEditVenue() {
    if (venueHidden != null) {
        venueHidden.style = "display: block;";
    }
    editVenueForm.style = "display: none;";
}



const phoneNumValidate = event => {
    event.target.value = event.target.value.replace(/[^0-9+]/g, '');
}

