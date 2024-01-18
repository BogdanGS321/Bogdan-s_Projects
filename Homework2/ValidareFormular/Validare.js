//1. Preia inputurile din campuri
//2. Verifica daca unul din campuri e gol
//3. Verifica validitatea emailului


function submit() {
const inputs = document.getElementsByTagName("input");
 const Email = inputs[0].value;
 const Parola = inputs[1].value;
 const Confirm = inputs[2].value;
 let regula = /^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/;
 let regulaParola = /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$/

 if (Email == null || Parola == null || Confirm == null) {
    alert("Una din campuri este goala.");
 }
 else if (!Email.match(regula)) {
   alert ("Email invalid.")
 }
 else if (!Parola.match(regulaParola)){
   alert ("Parola invalida.")
 }
 else if (Parola != Confirm) {
    alert("Parolele nu se potrivesc.");
 }
 


}
