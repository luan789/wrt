$(document).ready(function() {
	$('#js-booking').click(function(event) {
		/* Act on the event */
		$('#body-contents').css('display','block');
		$('.booking').css('display','none');
	});
	$('.steps1 #js-btn-next').click(function(event) {
		/* Act on the event */
		console.log('hello');
		$('.steps2').show();
		$('.steps1').hide();
		$('#steps ul li').removeClass('active');
		$('#steps ul li').eq(2).addClass('active');

	});
	$('.steps1 #js-btn-prev').click(function(event) {
		/* Act on the event */
		$('.booking').show();
		$('#body-contents').hide();

	});


});