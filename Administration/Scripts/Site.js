$.extend($.fn.dataTable.defaults, {
    "pageLength": 10,
    "lengthChange": false,
    "language": {
        "emptyTable": "Няма резервации",
        "info": "От _START_ до _END_ от общо _TOTAL_ резервации",
        "infoEmpty": "Показване на 0 от 0 резервации",
        "infoFiltered": "(Филтрирани от _MAX_ общо резервации)",
        "loadingRecords": "Зареждане...",
        "processing": "Обработка...",
        "search": "Търсене:",
        "zeroRecords": "Няма намерени резервации",
        "paginate": {
            "previous": "<  ",
            "next": "  >",
            "first": "|<<  ",
            "last": "  >>|"
        }
    }
});

$(document).ready(function () {
    $('.dataTable').DataTable();
});