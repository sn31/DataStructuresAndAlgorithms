
$(document).ready(function() {
  $("form#input").submit(function(event) {
    event.preventDefault();
    var countTo = parseInt($("#countTo").val());
    var countBy = parseInt($("#countBy").val());
    var resultArr =[];
    console.log(countTo);
    console.log(countBy);
    if (isNaN(countTo) || isNaN(countBy)) {
      alert("Please enter valid numbers!")
    }
    else if (countBy > countTo){
      alert("The count by number must be smaller than the count to number!")
    }
    else if (countTo < 0){
      for (var i = -countBy; i>=countTo; i-=countBy) {
        resultArr.push(i);
          console.log(i);
      };
    }
    else {
      for (var i=countBy;i<=countTo;i+=countBy) {
        resultArr.push(i);
      }
    }
    for (var i=0; i<resultArr.length;i++) {
      if (i==(resultArr.length-1)) {
        $("#resultList").append(resultArr[i]);
      }
      else {
        $("#resultList").append(resultArr[i] + ",");
      };
    };
  });
});
