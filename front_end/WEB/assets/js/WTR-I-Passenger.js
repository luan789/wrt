function checkVal(){
	checkName();
	checkNum();
	checkEmail();
	checkAdd();
}
function checkName(){
	var name_Pass= document.getElementById('js-name').value;
	var length_Name= name_Pass.trim().length;
	document.getElementById('val-name').innerHTML= length_Name<=0?"(*)Vui lòng nhập tên hành khách":"";
	return false;
}
function checkNum(){
	var num_Pass= document.getElementById('js-num').value;
	var length_Num= num_Pass.trim().length;
	if(length_Num==0){
		document.getElementById('val-num').innerHTML="(*)Vui lòng nhập số điện thọai";
		return false;
	}
	else{
		if(length_Num>10){
			document.getElementById('val-num').innerHTML="(*)Số điện thoại không đúng.\n 0345194003";
			return false;
		}
		document.getElementById('val-num').innerHTML="";
		return false;
	}
}
function checkEmail(){
	var mail= document.getElementById('js-email');
	var length_Email= mail.value.trim().length;
	var filter = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/; 
	if(length_Email==0){
		document.getElementById('val-mail').innerHTML="(*)Vui lòng nhập email hành khách";
		return false;
	}
	else{
		if (!filter.test(mail.value)) {
             document.getElementById('val-mail').innerHTML="(*)Vui lòng nhập địa chỉ emial hợp lệ.\nExample@gmail.com";
             mail.focus; 
             return false; 
	    }
	    else{
	    	document.getElementById('val-mail').innerHTML="";
	    }
	}
}
function checkAdd(){
	var add_Pass= document.getElementById('js-add').value;
	var length_Add= add_Pass.trim().length;
	document.getElementById('val-add').innerHTML= length_Add<=0?"(*)Vui lòng nhập địa chỉ hành khách":"";
	return false;
}
/*Input number*/
function isNumberKey(evt)
{
	var charCode = (evt.which) ? evt.which : event.keyCode
	if (charCode > 31 && (charCode < 48 || charCode > 57))
	 	return false;
	return true;
}