$(document).ready(function () {
    $('#js-booking').click(function () {
        checkDate();
        //$('').each(function () {
        if (idOrigin() && idDest() && checkDate() && idOrigin()) {
            $('#body-contents').css('display', 'block');
            $('.booking').css('display', 'none');
        }
        else
            alert('Bạn chưa nhập đủ thông tin hoặc thông tin chưa hợp lệ !!!');
        //})
    });
    $('.steps1 #js-btn-prev').click(function (event) {
        /* Act on the event */
        $('.booking').show();
        $('#body-contents').hide();

    });
    $('.steps1 #js-btn-next').click(function (event) {
        /* Act on the event */
        if (checkstation() && checkSeat()) {

            $('.steps2').show();
            $('.steps1').hide();
            $('#steps ul li').removeClass('active');
            $('#steps ul li').eq(2).addClass('active');
        }
        else
            alert('Vui lòng chọn ghế và điểm đón');
    });
    $('.steps1 #js-btn-prev').click(function (event) {
        /* Act on the event */
        $('.booking').show();
        $('#body-contents').hide();

    });
    $('.steps2 #js-btn-next').click(function (event) {
        if (checkVal()) {
            $('.steps3').show();
            $('.steps2').hide();
            $('#steps ul li').removeClass('active');
            $('#steps ul li').eq(3).addClass('active');
        }
        else
            alert('Yêu cầu nhập thông tin đầy đủ');

    });
    $('.steps2 #js-btn-prev').click(function (event) {
        console.log('hello');
        /* Act on the event */
        $('.steps1').show();
        $('.steps2').hide();
        $('#steps ul li').removeClass('active');
        $('#steps ul li').eq(1).addClass('active');
    });
    $('#login').click(function () {
        $('ul #dn').css('display', 'disable')
    });
    $('.steps3 #js-btn-prev').click(function (event) {

        /* Act on the event */
        $('.steps2').show();
        $('.steps3').hide();
        $('#steps ul li').removeClass('active');
        $('#steps ul li').eq(2).addClass('active');
    });
    function checkVal() {
        return $('#js-email').val().length > 0 && $('#js-name').val().length > 0 && $('#js-num').val().length > 0 ? true : false;
    }
    function checkstation() {
        return $('#substation option').is(':selected') ? true : false;
    }
    function checkSeat() {
        var money = $('#total').text();
        return Number(money) > 0 ? true : false;

    }
    function checkDate() {
        var dateseclected = $('#txtDate').val().length;
        return dateseclected >0  ? true : false;
    }
    function check_val() {
        if ($('#idDest option').val() === $('#idOrigin option').val())
        {
            return false;
        }
        return true;
    }
    function idDest() {
        return $('#idDest option').is(':selected') ? true : false;
    }
    function idOrigin() {
        return $('#idOrigin option').is(':selected') ? true : false;
    }

});