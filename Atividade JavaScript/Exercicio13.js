/*----------------------------------CALCULO DE IMC------------------------------------------------*/
let peso = prompt("Digite seu peso:");
let altura = prompt("Digite sua altura:");
let calculoIMC = (peso * peso) / altura;

if (calculoIMC <= 18.5) {
    console.log("Tu ta so o osso.")
}
if (calculoIMC >= 18.50 && calculoIMC <= 24.99) { console.log("Ta normal" + calculoIMC) }
if (calculoIMC >= 25.00 && calculoIMC <= 29.99) { console.log("Ta com sobrepeso " + calculoIMC) }
if (calculoIMC >= 30.00 && calculoIMC <= 34.99) { console.log("Obeso " + calculoIMC) }
if (calculoIMC >= 35.00 && calculoIMC <= 39.99) { console.log("Obeso 2.0 " + calculoIMC) }