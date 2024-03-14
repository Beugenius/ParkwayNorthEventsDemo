// forms
let AddSupplierForm = document.getElementById("AddSupplierForm");
let EditSupplierForm = document.getElementById("EditSupplierForm");
// add elements in form 
let AddSupplierName = document.getElementById("AddSupplierName");
let AddSupplierPhoneNumber = document.getElementById("AddSupplierPhoneNumber");
// edit elements in form 
let EditSupplerName = document.getElementById("EditSupplierName");
let EditSupplerPhoneNumber = document.getElementById("EditSupplierPhoneNumber");
// paragraph
let pNoSupplier = document.getElementById("pNoSupplier");
// main add button 
let AddSuppliersPlus = document.getElementById("AddSuppliersPlus");


let supplierHidden = null;

function AddSupplier(id) {
    if (pNoSupplier !== null) {
        pNoSupplier.style = "display: none;";
    }
    AddSuppliersPlus.style = "display: none;";
    // add form
    AddSupplierForm.style = "display: block;";
}

function SaveAddSupplier(bookingId, supplierBookedId) {
    // validate
    // create url
    // make api call 
    var valid = true;
    var supplierName = AddSupplierName.value;
    var supplierPhoneNumber = AddSupplierPhoneNumber.value;
    if (supplierName == "") {
        valid = false;
        AddSupplierName.classList.add("bg-danger");
    }
    if (supplierPhoneNumber == "" || supplierPhoneNumber.length != 10) {
        valid = false;
        AddSupplierPhoneNumber.classList.add("bg-danger");
    }

    if (valid == true) {
        //string supplierBookedId, string bookingId, string status, string supplierPhoneNumber, string supplierName
        var url = String("/api/servicesBooked/details?supplierBookedId=" + encodeURIComponent(supplierBookedId) + "&&bookingId=" + encodeURIComponent(bookingId)
            + "&&status=New" + "&&supplierPhoneNumber=" + encodeURIComponent(supplierPhoneNumber) + "&&supplierName=" + encodeURIComponent(supplierName));
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

function CancelAddSupplier() {
    if (pNoSupplier !== null) {
        pNoSupplier.style = "display: block;";
    }
    AddSuppliersPlus.style = "display: block;";
    AddSupplierForm.style = "display: none;";
}

function EditSupplier(supplierBookedId, bookingId) {
    if (supplierHidden != null) {
        supplierHidden.style = "display: block;";
    }
    supplierHidden = document.getElementById(supplierBookedId);
    supplierHidden.style = "display: none;";
    EditSupplierForm.style = "display: block";
    var SaveSupplierLink = document.getElementById("saveSupplierLink");
    SaveSupplierLink.setAttribute("onclick", "SaveSupplierEdit('" + supplierBookedId + "', '" + bookingId + "')");
    EditSupplerPhoneNumber.value = document.getElementById("SupplierPhone" + supplierBookedId).innerHTML;
    EditSupplerName.value = document.getElementById("SupplierName" + supplierBookedId).innerHTML;
}

function SaveSupplierEdit(supplierBookedId, bookingId) {
    // validate
    // create url
    // make api call 
    var valid = true;
    var supplierName = EditSupplierName.value;
    var supplierPhoneNumber = EditSupplierPhoneNumber.value;
    if (supplierName == "") {
        valid = false;
        EditSupplierName.classList.add("bg-danger");
    }
    if (supplierPhoneNumber == "" || supplierPhoneNumber.length != 10) {
        valid = false;
        EditSupplierPhoneNumber.classList.add("bg-danger");
    }

    if (valid == true) {
        //string supplierBookedId, string bookingId, string status, string supplierPhoneNumber, string supplierName
        var url = String("/api/servicesBooked/details?supplierBookedId=" + encodeURIComponent(supplierBookedId) + "&&bookingId=" + encodeURIComponent(bookingId)
            + "&&status=New" + "&&supplierPhoneNumber=" + encodeURIComponent(supplierPhoneNumber) + "&&supplierName=" + encodeURIComponent(supplierName));
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

function CancelEditSupplier() {
    if (supplierHidden != null) {
        supplierHidden.style = "display: block;";
    }
    EditSupplierForm.style = "display: none;";
}

