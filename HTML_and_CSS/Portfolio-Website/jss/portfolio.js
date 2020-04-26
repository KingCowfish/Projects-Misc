//function for prompt to properly fill out form
function validateForm() {
    var x = document.forms["myForm"]["name"].value;
    var y = document.forms["myForm"]["email"].value;
    var z = document.forms["myForm"]["message"].value;
    if (x == "") {
        alert("Please fill in your name.");
        return false;
    }
    if (y == "") {
        alert("Please fill in your email address.");
        return false;
    }
    if (z == "") {
        alert("Please fill in your message.");
        return false;
    }
}

//opening and closing popup form
function openForm() {
    document.getElementById("contact").style.display = "block";
  }
  function closeForm() {
    document.getElementById("contact").style.display = "none";
  }


//slideshow functions
var slideIndex = 1;
showSlides(slideIndex);

// Next/previous controls
var slideIndex = 1;
showSlides(slideIndex);

function plusSlides(n) {
  showSlides(slideIndex += n);
}

function currentSlide(n) {
  showSlides(slideIndex = n);
}

function showSlides(n) {
  var i;
  var slides = document.getElementsByClassName("mySlides");
  var dots = document.getElementsByClassName("dot");
  if (n > slides.length) {slideIndex = 1}    
  if (n < 1) {slideIndex = slides.length}
  for (i = 0; i < slides.length; i++) {
      slides[i].style.display = "none";  
  }
  for (i = 0; i < dots.length; i++) {
      dots[i].className = dots[i].className.replace(" active", "");
  }
  slides[slideIndex-1].style.display = "block";  
  dots[slideIndex-1].className += " active";
}