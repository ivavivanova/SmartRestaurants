$(document).on('click', '.color-green', function () {
    var $btn = $(this),
        url = $('.restaurant').data('url');

    $.ajax({
        url: url,
        type: 'Post',
        data: { tableNum: $btn[0].id },
        success: function () {
            window.location.reload();
        }
    });
});

