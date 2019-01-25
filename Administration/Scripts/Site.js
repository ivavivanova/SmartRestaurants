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

$.ajaxSetup({
    cache: false,
    beforeSend: function (xhr) {
        xhr.setRequestHeader('RequestVerificationToken', $('input:hidden[name="__RequestVerificationToken"]').val());
    }
});

$(document).ready(function () {
    $('.dataTable').DataTable();
});

(function ($) {
    $.confirmationDialog = function (message, title, callback) {
        BootstrapDialog.show({
            title: title,
            message: message,
            buttons: [
                {
                    label: 'Да',
                    cssClass: 'btn-primary',
                    action: function (dialog) {
                        dialog.close();
                        if (callback) {
                            callback();
                        }
                    }
                },
                {
                    label: 'Не',
                    cssClass: 'btn-default',
                    action: function (dialog) {
                        dialog.close();
                    }
                }]
        });
    };
})(jQuery);

$(document).on('click', '.js-free-table', function (e) {
    e.preventDefault();

    var $btn = $(this),
        url = $btn.data('url'),
        tableId = $btn.data('table-id'),
        $tableNumber = $($btn.closest('tr')).find('.table-num');

    $.confirmationDialog('Маса номер <b>' + $tableNumber.text() + '</b> ще бъде отбелязана в системата като "свободна", сигурни ли сте, че искате да продължите?', 'Освобождаване на маса', function () {
        $.ajax({
            url: url,
            type: 'Post',
            data: { tableId: tableId },
            success: function () {
                window.location.reload();
            }
        });
    });
});