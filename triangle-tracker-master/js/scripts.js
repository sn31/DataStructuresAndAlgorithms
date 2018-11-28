var triangleChecker = function(one, two, three) {
  var max = Math.max(one, two, three);
  var sum = one + two + three;
  if (sum-max <= max)
    return false;
  else
    return true;
}

var triangleIdentifier = function(one, two, three) {
  if (triangleChecker(one, two, three) === true) {
    if (one === two && one === three)
      return "a equilateral triangle";
    else if (one === two || one === three || two === three)
      return "a isosceles triangle";
    else
      return "a scalene triangle";
  }
  else
    return "not a triangle";
}

$(document).ready(function() {
  $("form#input").submit(function(event){
    event.preventDefault();
    var one = parseInt($("input#one").val());
    var two = parseInt($("input#two").val());
    var three = parseInt($("input#three").val());
    $(".card-body p").show();
    if (isNaN(one) || isNaN(two) || isNaN(three)){
      $("span.result").text("Please enter three valid numbers");
      $("span.definition").text("N/A");
    }
    else {
      var triangle = triangleIdentifier(one, two, three);
      $("span.result").text(triangle);
      if (triangle === "a equilateral triangle") {
        $("span.definition").text("All sides are equal.");
      }
      else if (triangle === "a isosceles triangle") {
        $("span.definition").text("Exactly 2 sides are equal.");
      }
      else if (triangle === "a scalene triangle") {
        $("span.definition").text("No sides are equal.");
      }
      else {
        $("span.definition").text("The sum of the lengths of any two sides of a triangle is less than or equal to the length of the third side.");
      }
    }

  });
});
