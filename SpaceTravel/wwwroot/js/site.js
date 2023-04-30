// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

let container = document.querySelector('.container');
let btn = document.getElementById('spin');
let number = Math.ceil(Math.random() * 1000);

btn.onclick = function () {
  container.style.transform = "rotate(" + number + "deg)"
  number += Math.ceil(Math.random() * 1000);
}