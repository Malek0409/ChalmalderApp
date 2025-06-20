﻿
var dataTable;

$(document).ready(function () {
    $.extend(true, $.fn.dataTable.defaults, {
        columnDefs: [
            { targets: '_all', type: 'string' } 
        ]
    });
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/admin/product/getall' },
        "columns": [
            { data: 'title', "width": "25%" },
            { data: 'isbn', "width": "15%" },
            { data: 'author', "width": "15%" },
            { data: 'price', "width": "10%" },
            { data: 'category.name', "width": "15%" },
            {
                data: 'id',
                "render": function (data) {
                    return `
                        <a href="/Admin/Product/Upsert?id=${data}" class="btn btn-primary btn-sm">
                            <i class="bi bi-pencil-square"></i>
                        </a>
                        <a onClick="Delete('/Admin/Product/Delete/${data}')" class="btn btn-danger btn-sm">
                            <i class="bi bi-trash"></i>
                        </a>
                    `;
                },
                "width": "6%"
            }
        ]
    });
}


function Delete(url) {
    Swal.fire({
        title: "Are you sure?",
        text: "You won't be able to revert this!",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Yes, delete it!"
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: "DELETE",
                success: function (data) {
                    dataTable.ajax.reload();
                    toastr.success(data.message);
                }
            })
        }
    });
}