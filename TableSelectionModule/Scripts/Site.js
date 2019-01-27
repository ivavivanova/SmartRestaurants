$(document).on('click', '.color-green', function () {
    var $btn = $(this),
        url = $('.restaurant').data('url'),
        tableNumber = $btn[0].id;

    $btn.removeClass("color-green").addClass("color-yellow");
    $('.baseLine').removeClass('hidden');
    $('path.' + tableNumber).removeClass('hidden');

    setTimeout(function () {
        $.ajax({
            url: url,
            type: 'Post',
            data: { tableNum: tableNumber },
            success: function () {
                window.location.reload();
            }
        });
    }, 5000);
});

