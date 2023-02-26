function changeColor(color) {
    var text= document.getElementById("text");
    text.style.color = color;
}



function increaseFontSize() {
    var text = document.getElementById("text");
    var currentSize = window.getComputedStyle(text, null).getPropertyValue("font-size");
    var newSize = parseInt(currentSize) + 2;
    text.style.fontSize = newSize + "px";
  }
  
  function decreaseFontSize() {
    var text = document.getElementById("text");
    var currentSize = window.getComputedStyle(text, null).getPropertyValue("font-size");
    var newSize = parseInt(currentSize) - 2;
    text.style.fontSize = newSize + "px";
  }