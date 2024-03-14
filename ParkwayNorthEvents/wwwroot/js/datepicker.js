let disabledDates = [];
$(window).on('load', async function () {
    await loadAjax();
    $("#datepicker").datepicker({
        beforeShowDay: function (date) {
            var string = jQuery.datepicker.formatDate('yy-mm-dd', date);
            let tasdf = [disabledDates.indexOf(string) == -1];
            return [disabledDates.indexOf(string) == -1]
        },
        minDate: 0
        
    });
});

async function loadAjax() {
    await $.ajax({
        url: '/api/consultationdates/',
        method: 'GET',
        dataType: 'json',
        success: function (data) {
            for (let i = 0; i < data.length; ++i) {
                disabledDates.push(String(data[i].date));
            }
        }
    });
    return;
}

function ValidateInput() {
    // validate email
    // validate phone number
    // validate date 
    let todaysDate = String(new Date().toISOString().split('T')[0]);
    if (new Date(document.getElementById("datepicker").value).toISOString().split('T')[0] < todaysDate) {
        swal('Error', 'Please select a valid date', 'error');
        return false; 
    }
    return true; 
}