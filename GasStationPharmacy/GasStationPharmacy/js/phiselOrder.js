function activate(element, change) {
	if (element.checked) {
		document.getElementById(change).removeAttribute("disabled")
		document.getElementById(change).value = 1;
	}
	else{
		document.getElementById(change).setAttribute("disabled","true");
		document.getElementById(change).value = '';
	}
}

function updateRecipe(){
	if(document.getElementById("update").checked){
		document.getElementById("update_recipe").style.display = "block";
	}
	else{
		document.getElementById("update_recipe").style.display = "none";
	}
}

function eliminateRecipe(){
	if(document.getElementById("eliminate").checked){
		document.getElementById("eliminate_recipe").style.display = "block";
	}
	else{
		document.getElementById("eliminate_recipe").style.display = "none";
	}
}

function check(){
	var medicines = document.getElementsByClassName('medicine');
	var count = 0;
	for(i = 0; i < medicines.length; i++){
		if(medicines[i].checked != true){
			count++;
		}
	}
	if(count < medicines.length){
		return true;
	}
	else{
		alert("You need to choose at least one medication!");
		return false;
	}
}

function checkUpdate(){
	var medicines = document.getElementsByClassName('medicineUpdate');
	var count = 0;
	for(i = 0; i < medicines.length; i++){
		if(medicines[i].checked != true){
			count++;
		}
	}
	if(count < medicines.length){
		return true;
	}
	else{
		alert("You need to choose at least one medication!");
		return false;
	}
}