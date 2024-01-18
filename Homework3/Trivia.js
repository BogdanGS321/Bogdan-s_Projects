const I1 = 
`Cand s-a scufuncat Titanitcul?
a) 1912
b) 1915
c) 1918
d) 1920`;

const I2 = 
`Cate respiratii are omul zilnic?
a) 16000
b) 12000
c) 20000
d) 24000`;

const I3 = 
`Care este durata de viata a unei libelule?
a) 12 ore
b) 24 ore
c) 30 ore
d) 48 ore`;

const I4 = 
`In ce an a fost fabricat primul camion Tonka?
a) 1945
b) 1949
c) 1951
d) 1947`;

let score = 0;
const scoreParagraph = document.getElementById("score");
scoreParagraph.innerText = `Score: ${score}`;

const Questions = [I1, I2, I3, I4];
let NrIntrebare = 0;


const Intrebare = document.getElementById("IntrebareVariante");
Intrebare.innerText = Questions[NrIntrebare];

function a() {
    if (NrIntrebare == 0) {
        score += 1;
    }
    
    if (NrIntrebare == 3) {
        NrIntrebare = 0;
    } 
    else NrIntrebare += 1;

    Intrebare.innerText = Questions[NrIntrebare];
    scoreParagraph.innerText = `Score: ${score}`;

}

function b() {
    if (NrIntrebare == 2) {
        score += 1;
    }
    
    if (NrIntrebare == 3) {
        NrIntrebare = 0;
    } 
    else NrIntrebare += 1;

    Intrebare.innerText = Questions[NrIntrebare];
    scoreParagraph.innerText = `Score: ${score}`;

}
function c() {
    if (NrIntrebare == 1) {
        score += 1;
    }
    
    if (NrIntrebare == 3) {
        NrIntrebare = 0;
    } 
    else NrIntrebare += 1;

    Intrebare.innerText = Questions[NrIntrebare];
    scoreParagraph.innerText = `Score: ${score}`;

}

function d() {
    if (NrIntrebare == 3) {
        score += 1;
    }
    
    if (NrIntrebare == 3) {
        NrIntrebare = 0;
        score = 0;
    } 
    else NrIntrebare += 1;

    Intrebare.innerText = Questions[NrIntrebare];
    scoreParagraph.innerText = `Score: ${score}`;

}

Intrebare.innerText = Questions[NrIntrebare];
scoreParagraph.innerText = `Score: ${score}`;
