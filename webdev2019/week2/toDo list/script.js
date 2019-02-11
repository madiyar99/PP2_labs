
function create_div(){

	var count = document.getElementById('counter');
	var i = count.innerHTML;

	var note = document.getElementById('form_input'); //note_text
	var block = document.getElementById('content_block');

	var div_init = document.getElementById('note_block');
	var div_curr = div_init.cloneNode(true);
	div_curr.style.display = "block";

	var par = div_curr.firstChild.children[1];
	par.innerHTML = note.value;
	par.id = par.id + i;

	var checkbox = div_curr.firstChild.firstChild;
	checkbox.id = i;

	div_curr.id = div_curr.id + i;
	block.appendChild(div_curr);
	
	i = Number(i);
	count.innerHTML = i + 1;

	var date = getDateNote();
	var right_side = div_curr.children[1];

	right_side.firstChild.innerHTML = date;

}

function delete_div() {

	var target = event.target;

	var parent = target.parentNode.parentNode.parentNode;

	var block = document.getElementById('content_block');

	block.removeChild(parent);

}

function done_note() {
	var target = event.target;

	var id = "par" + target.id;

	var par = document.getElementById(id);

	if(target.checked){
		par.style.textDecoration = "line-through";
		par.style.color = "green";	
	}

	else{
		par.style.textDecoration = "none";
		par.style.color = "black";	
	}

}

function getDateNote() {

	var date = new Date();

	var sec = date.getSeconds();
	var min = date.getMinutes();
	var hours = date.getHours();
	var day = date.getDate();
	var month = date.getMonth();
	var year = date.getFullYear();

	if(sec < 10) 
		sec = "0" + sec;

	else if(min < 10) 
		min = "0" + min;

	else if(hours < 10)
		hours = "0" + hours;

	else if(day < 10)
		day = "0" + day;

	else if(month < 10)
		month = "0" + month;

	else if(year < 10)
		year = "0" + year;

	var dateStr = "Дата добавления: " + hours + ":" + min + ":" + sec + ", " + day + "." + month + "." + year;

	return dateStr;
}

