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

$(document).on('click', '.search-by-email', function (e) {
    e.preventDefault();

    var $btn = $(this),
        url = $btn.data('url'),
        form = $btn.closest('form'),
        serializedForm = form.serialize();


    if (serializedForm !== "userEmail=") {
        $.ajax({
            url: url,
            type: 'Post',
            data: serializedForm,
            success: function (data) {
                if (data.tableNum) {
                    $('#' + data.tableNum).removeClass("color-green").addClass("color-yellow");
                    $('.baseLine').removeClass('hidden');
                    $('path.' + data.tableNum).removeClass('hidden');

                    setTimeout(function () {
                        window.location.reload();
                    }, 5000);
                }
                else {
                    alert("Не е открита резервация за този имейл.");
                }
            },
            error: function () {
                alert("Възникна грешка.");
            }
        });
    }
    else {
        alert("Не сте въвели имейл.");
    }
});
