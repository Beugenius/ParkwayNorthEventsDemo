var dataTable;

/* Do not run until page has loaded*/
$(document).ready(function () {
    loadList();
});
// convert tables into DataTables 
function loadList() {
    dataTable = $('#DT_clients').DataTable({
        "ajax": {
            "url": "/api/clients",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { data: "firstName", width: "20%" },
            { data: "lastName", width: "20%" },
            { data: "phoneNumber", width: "20%" },
            { data: "email", width: "20%" },
            {
                data: "id", width: "20%",
                "render": function (data) {
                    return `<div class="text-center">
                            <a href="/Admin/Clients/ClientUpsert?id=${data}"
                            class ="btn btn-primary parkwayButton" style="cursor:pointer; min-width: 100px; max-width: 100px;"> <i class="far fa-edit"></i>Edit</a>
                            <a onClick=Delete('/api/clients/'+${data})
                            class ="btn btn-primary parkwayDeleteButton text-white" style="cursor:pointer; min-width: 100px;  max-width: 100px;"> <i class="far fa-trash-alt"></i>Delete</a>
                    </div>`;
                }
            }
        ],
        "language": {
            "emptyTable": "no data found."
        },
        "width": "100%"
    });
};

function Delete(url) {
    swal({
        title: "Are you sure you want to delete?",
        text: "All associated bookings will be deleted and unrecoverable!",
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
                        dataTable.ajax.reload();
                    }
                    else {
                        toastr.error(data.message);
                    }
                }
            })
        }
    })
}