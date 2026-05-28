// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


function verificarIntento(){
let intento = document.getElementById('intento');
let palabra = document.getElementById('palabra');
let i = 0;
let encontrado = false;
while(i<palabra.length && !encontrado)
encontrado = palabra[i] === intento
}
if(encontrado){
    document.getElementById('incongitas').innerHTML[i](palabra[i])
}