$(document).ready(function () {
    $('#js-booking').click(function (event) {
        /* Act on the event */
        $('#body-contents').css('display', 'block');
        $('.booking').css('display', 'none');
    });
    $('.steps1 #js-btn-next').click(function (event) {
        /* Act on the event */
        $('.steps2').show();
        $('.steps1').hide();
        $('#steps ul li').removeClass('active');
        $('#steps ul li').eq(2).addClass('active');

    });
    $('.steps1 #js-btn-prev').click(function (event) {
        /* Act on the event */
        $('.booking').show();
        $('#body-contents').hide();

    });
    $('.steps2 #js-btn-next').click(function (event) {
        $('.steps3').show();
        $('.steps2').hide();
        $('#steps ul li').removeClass('active');
        $('#steps ul li').eq(3).addClass('active');

    });
    $('.steps2 #js-btn-prev').click(function (event) {
        console.log('hello');
        /* Act on the event */
        $('.steps1').show();
        $('.steps2').hide();
        $('#steps ul li').removeClass('active');
        $('#steps ul li').eq(1).addClass('active');
    });
    $('.steps3 #js-btn-prev').click(function (event) {
        console.log('hello');
        /* Act on the event */
        $('.steps2').show();
        $('.steps3').hide();
        $('#steps ul li').removeClass('active');
        $('#steps ul li').eq(2).addClass('active');
    });
    
    /*******************************************add event*******************************************/


});