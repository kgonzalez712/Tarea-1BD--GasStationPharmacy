function activate(element, change) {
	if (element.checked) {
		document.getElementById(change).removeAttribute("disabled");
	}
	else{
		document.getElementById(change).setAttribute("disabled","true");
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