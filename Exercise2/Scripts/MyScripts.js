$(document).ready(function () {
  $('.imageoptional').change(function () {                
     $('#viewimage').toggle(!this.checked);
  }).change(); 
});

$(document).ready(function () {
    $('.videooptional').change(function () {
        $('#viewvideo').toggle(!this.checked);
    }).change(); 
});