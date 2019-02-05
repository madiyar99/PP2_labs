var bg = document.getElementById('bg');

var r = 91;
var g = 4;
var b = 30;
var count = true;

function color() {

	if(count == true){
		if(r > 1) {
			r = r - 1;
		}

		if(g < 74) {
			g = g + 1;
		}

		if(b < 90) {
			b = b + 1;
		}

		if(r == 1 && g == 74 && b == 90){
			count = false;
		}
	}

	if(count == false) {
		if(r < 91) {
			r = r + 1;
		}

		if(g > 4) {
			g = g - 1;
		}

		if(b > 30) {
			b = b - 1;
		}

		if(r == 91 && g == 4 && b == 30)	{
			count = true;
		}
	}

	var rgb = 'rgb(' + r + ',' + g + ',' + b + ', 0.6)'; 

	document.getElementById('bg').style.backgroundColor = rgb;

}


setInterval(color, 50);
