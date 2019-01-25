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

$('.js-datepicker').datepicker({});

$('.timepicker').timepicker({
    interval: 30,
    minTime: '8:00am',
    maxTime: '11:00pm'
});