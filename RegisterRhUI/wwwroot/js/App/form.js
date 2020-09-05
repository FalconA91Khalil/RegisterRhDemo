var dataTable;

$(document).ready(function () {
    loadDataTable();
})

function loadDataTable() {

    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/App/Forms/GetAll",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [           
            { "data": "formFieldID", "width": "15" },
            { "data": "form.formType", "width": "15%" },
            { "data": "fieldLabel", "width": "15%" },
            { "data": "fieldType.fieldTypeName", "width": "15%" },
            { "data": "createdDate", "width": "15%" },
            {
                "data": "formFieldID",
                "render": function (data) {
                    return `<div class="text-center">
                                <a href="/App/Forms/Upsert/${data}" class='btn btn-success text-white' style='cursor:pointer; width:100px;'>
                                    <i class='far fa-edit'></i> Edit
                                </a>
                                &nbsp;
                                <a onclick=Delete("/App/Forms/Delete/${data}") class='btn btn-danger text-white' style='cursor:pointer; width:100px;'>
                                    <i class='far fa-trash-alt'></i> Delete 
                                </a>
                            </div>
                            `;
                }, "width": "30%"
            }
        ],
        "language": {
            "emptyTable": "No records found."
        },
        "width": "100%"
    });
}
function Delete(url) {
    swal({
        title: "Are you sure?",
        text: "Once deleted, you will not be able to recover this imaginary file!",
        icon: "warning",
        buttons: true,
        dangerMode: true,
    })
        .then((willDelete) => {
            if (willDelete) {
                $.ajax({
                    type: 'DELETE',
                    url: url,
                    success: function (data) {
                        swal("Poof! Your imaginary file has been deleted!", {
                            icon: "success",
                        });
                        dataTable.ajax.reload();
                    },

                });
                
            } else {
                swal("Your imaginary file is safe!");
            }
        });
}

