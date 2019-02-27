// Create a request variable and assign a new XMLHttpRequest object to it.
var request = new XMLHttpRequest();

// Open a new connection, using the GET request on the URL endpoint
request.open('GET', 'http://localhost:63786/api/ClientPH', true);

request.onload = function () {
  alert("jason");
}


// Send request
request.send();

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

