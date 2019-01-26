(function ($) {
    $.extend($.fn.datepicker.defaults, {
        todayHighlight: true,
        language: 'bg',
        format: "dd.mm.yyyy",
        autoclose: true
    });

    $.fn.datepicker.dates['bg'] = {
        days: ["неделя", "понеделник", "вторник", "сряда", "четвъртък", "петък", "събота"],
        daysShort: ["Нед", "Пон", "Вто", "Сре", "Чет", "Пет", "Съб"],
        daysMin: ["нд", "пн", "вт", "ср", "чт", "пт", "сб"],
        months: ["Януари", "Февруари", "Март", "Април", "Май", "Юни", "Юли", "Август", "Септември", "Октомври", "Ноември", "Декември"],
        monthsShort: ["Ян", "Февр", "Март", "Април", "Май", "Юни", "Юли", "Авг", "Септ", "Окт", "Ноем", "Дек"],
        today: "Днес",
        clear: "Разчисти",
        titleFormat: "MM yyyy", /* Leverages same syntax as 'format' */
        weekStart: 1
    };
})(jQuery);

$('.js-datepicker').datepicker({
    minDate: 0,
    startDate: '-0m'});

$('.timepicker').timepicker({
    interval: 30,
    minTime: '8:00am',
    maxTime: '11:00pm'
});

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
