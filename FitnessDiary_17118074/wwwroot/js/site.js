// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function recordUpdated() {
    alert("Record updated Successfully")
}

function recordDeleted() {
    alert("Record deleted Successfully")
}

function recordCreated() {
    alert("Record created Successfully")
}

$(document).ready(function () {
    var location = window.location.href;
    if (location === "https://localhost:44302/") {
        $('#main-container').addClass("home-container");
    }

    $('.nav-link').hover(function () {
        $(this).attr('style', 'color: white !important');
    });
    $('.nav-link').mouseout(function () {
        $(this).attr('style', 'color: #8d9da9 !important');
    });

    $('#foods-table').DataTable({
        dom: 'Bfrtip',
        buttons: [
            'copyHtml5',
            'excelHtml5',
            'csvHtml5',
            'pdfHtml5'
        ]
    });
    $('#weight-table').DataTable({
        dom: 'Bfrtip',
        buttons: [
            'copyHtml5',
            'excelHtml5',
            'csvHtml5',
            'pdfHtml5'
        ]
    });
});