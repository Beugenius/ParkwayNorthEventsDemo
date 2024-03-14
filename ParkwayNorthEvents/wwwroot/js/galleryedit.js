function DeleteImage(url) {
    swal({
        title: "Are you sure you want to delete?",
        text: "You will not be able to restore this data!",
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

function Edit(id) {
    // get the card to edit
    var cardToEdit = document.getElementById(id);
    // get the title to replace 
    var titleToReplace = cardToEdit.getElementsByTagName("h3")[0];
    // create the title input 
    var titleInputEdit = document.createElement("input");
    titleInputEdit.type = "text";
    titleInputEdit.classList.add("card-title");
    titleInputEdit.classList.add("hidden-button");
    titleInputEdit.value = titleToReplace.getElementsByTagName("span")[0].innerHTML;
    // create save button 
    var saveButtonLink = document.createElement("a");
    saveButtonLink.classList.add("mx-2");
    saveButtonLink.setAttribute("onclick", "Save('" + id + "')");
    var saveButtonIcon = document.createElement("icon");
    saveButtonIcon.classList.add("fa-regular");
    saveButtonIcon.classList.add("fa-floppy-disk");
    saveButtonIcon.classList.add("fa-xl");
    // create the cancel button 
    var cancelButtonLink = document.createElement("a");
    cancelButtonLink.classList.add("mx-2");
    cancelButtonLink.setAttribute("onclick", "Cancel('" + id + "')");
    var cancelButtonIcon = document.createElement("icon");
    cancelButtonIcon.classList.add("fa-solid");
    cancelButtonIcon.classList.add("fa-x");
    cancelButtonIcon.classList.add("fa-xl");
    // add icon to cancel link 
    cancelButtonLink.appendChild(cancelButtonIcon);
    // add icon to the save link
    saveButtonLink.appendChild(saveButtonIcon);
    // add the new input to the card
    cardToEdit.insertBefore(titleInputEdit, titleToReplace);
    // add the save button to the card 
    cardToEdit.insertBefore(saveButtonLink, titleToReplace);
    // add cancel button to the card 
    cardToEdit.insertBefore(cancelButtonLink, titleToReplace);
    // hide the original title
    titleToReplace.style="display: none;";

}

function Save(id) {
    var tester = document.getElementById(id).getElementsByTagName("input");
    var newTitle = document.getElementById(id).getElementsByTagName("input")[0].value;
    if (newTitle !== "") {
        var url = String("/api/gallery/details?id=" + encodeURIComponent(id) + "&&title=" + encodeURIComponent(newTitle));

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
        })
    }
}

function Cancel(id) {
    // get the card to edit
    var cardToEdit = document.getElementById(id);
    // get the title to redisplay 
    var titleToRedisplay = cardToEdit.getElementsByTagName("h3")[0];
    // redisplay title
    titleToRedisplay.style="display: block;"
    // delete edit / cancel buttons 
    var linkList = cardToEdit.getElementsByTagName("a");
    var saveButton = linkList[0];
    var cancelButton = linkList[1];
    saveButton.remove();
    cancelButton.remove();
    cardToEdit.getElementsByTagName("input")[0].remove();
}