// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


function verificarIntento() {
    let intento = document.getElementById('intento').value;
    let palabra = document.getElementById('palabra').value;
    let resultado = ""; 
    console.log(palabra)
    for (i = 0; i < palabra.length; i++) {
        if (palabra[i].toUpperCase() === intento.toUpperCase()) {
            resultado += intento.toUpperCase() ;
        }
        else {
            resultado += document.getElementById('incongitas').innerText[i];
        }


    }
    if(resultado == document.getElementById('incongitas').innerText){
document.getElementById('intentos').innerText--;
    }
    if (!resultado.includes("_")) {
        document.getElementById('estado').innerText = 'GANASTE'
        document.getElementById('estado').style.color = 'green';
        document.getElementById('boton').disabled = true;


    }
    if (document.getElementById('intentos').innerText == 0){
          document.getElementById('estado').innerText = 'PERDISTE'
        document.getElementById('estado').style.color = 'red';
        document.getElementById('boton').disabled = true;
    }
    console.log(resultado);
    document.getElementById('incongitas').innerText = resultado;

}