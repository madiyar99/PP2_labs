var tab_content;
var tabs;
var line_title;
var underLine;

window.onload = function(){
	tab_content = document.getElementsByClassName('tab_content');
	tabs = document.getElementsByClassName('tab');
	line_title = document.getElementsByClassName('line_title');
	underLine = document.getElementsByClassName('underLine');
	CloseTab();
	tab_content[0].style.display = 'block';
	tabs[0].classList.add('active');
	underLine[0].style.display = 'block';
}

function CloseTab(){
	for(var i = 0; i < tab_content.length; i++){
		tab_content[i].style.display = 'none';
		tabs[i].classList.remove('active');
		underLine[i].style.display = "none";
	}
}


document.getElementById('tab-wrapper').onclick = function(target){
	var target = event.target;
	for(var i = 0; i < tabs.length; i++){
		if(target == tabs[i]){
			CloseTab();
			tab_content[i].style.display = 'block';
			target.classList.add('active');
			line_title[0].innerHTML = "Все " + tabs[i].innerHTML;
			underLine[i].style.display = 'block'; 
			break;
		}
	}
}