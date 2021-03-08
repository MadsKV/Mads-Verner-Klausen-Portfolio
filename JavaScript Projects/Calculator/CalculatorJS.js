var input = parseInt(document.getElementById("input").value);
var input2 = parseInt(document.getElementById("input2").value);

function add() {
  var x = parseInt(document.getElementById("input").value);
  var y = parseInt(document.getElementById("input2").value);

  var result = x + y;
  document.getElementById("output").value = result;
}
function minus() {
  var x = parseInt(document.getElementById("input").value);
  var y = parseInt(document.getElementById("input2").value);
  var input;
  var input2;

  var result = x - y;
  document.getElementById("output").value = result;
}
function multiply() {
  var x = parseInt(document.getElementById("input").value);
  var y = parseInt(document.getElementById("input2").value);
  input;
  input2;

  var result = x * y;
  document.getElementById("output").value = result;
}
function divide() {
  var x = parseInt(document.getElementById("input").value);
  var y = parseInt(document.getElementById("input2").value);
  input;
  input2;

  var result = x / y;
  document.getElementById("output").value = result;
}
function modulo() {
  var x = parseInt(document.getElementById("input").value);
  var y = parseInt(document.getElementById("input2").value);
  input;
  input2;

  var result = x % y;
  document.getElementById("output").value = result;
}


//Active ones
function insert(num) {
  document.form.textview.value = document.form.textview.value + num;
}
function equal() {
  var exp = document.form.textview.value;
  if (exp) {
    document.form.textview.value = eval(exp);
  }
}
function clear() {
  document.form.textview.value = "";
}
function back() {
  var exp = document.form.textview.value;
  document.form.textview.value = exp.substring(0, exp.length - 1);
}
