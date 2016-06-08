$(function () {
    //$(".movieLink2").popover({
    //    trigger: 'hover',
    //    'placement': 'top'
    //});
    $(".movieLink").on("click", function () {
        $.ajax({
            url: '/Movies/NewDetailsAsync/?id=' + $(this).data('movieid'),
            method: 'get',
            success: function (data) {
                $('#divMovieDetails').html(data);
            }
        })
    })
});
