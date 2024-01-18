
const a = "img1.jpg";
const b = "img2.jpg";
const c = "img3.jpg";
const d = "img4.jpg";
const imagini = [a, b, c, d];
let i = 0;


function urmatoarea() {
    i += 1;
    if (i > 3) {
        i = 0;
    }
    document.getElementById("image").src = imagini[i];
}

function precedenta() {
    i -= 1;
    if (i < 0) {
        i = 3;
    }
    document.getElementById("image").src = imagini[i];
}

setInterval(urmatoarea, 5000);