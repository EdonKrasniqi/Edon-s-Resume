var mybutton = document.getElementById("myBtnScroll");

window.onscroll = function() {scrollFunction()};
// This function is for scrollTop button which will appear when you scroll down. 
function scrollFunction() {
  if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
    mybutton.style.display = "block";
  } else {
    mybutton.style.display = "none";
  }
}

function topFunction() {
  document.body.scrollTop = 0;
  document.documentElement.scrollTop = 0;
}