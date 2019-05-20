var i=0;
var locate;
function seatClick() {
	i++;
	var seat= document.getElementsByClassName('seat');
	if(i%2!=0){
		this.classList.add('selected');
	}
	else{
		this.classList.remove('selected');
	}
}