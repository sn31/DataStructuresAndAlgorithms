$(document).ready(function() {
  $("form#input").submit(function(event) {
    event.preventDefault();
    var originalString = $("#originalString").val();
    var vowels = ["a","i","e","u","o","A","I","E","U","O"];
    console.log(originalString);
    var resultString = [];
    for (var i=0; i<originalString.length;i++) {
      if (vowels.includes(originalString[i])) {
        resultString.push("-");
      }
      else {
        resultString.push(originalString[i]);
      }
    }
    $("#resultString").append(resultString);
    $("form#input").hide();
  });
});
