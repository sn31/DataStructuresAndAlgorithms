//BACK-END LOGIC
var numberConverter = function (inputNumber, inputName, strOrder) {
    inputName = (inputName === "") ? "Dave" : inputName;
    if (inputNumber !== "0" && !(parseInt(inputNumber) % 3)) {
        return "I'm sorry, " + inputName + ". I'm afraid I can't do that.";
    }
    else if (inputNumber.includes("1")) {
        return "Boop!";
    }
    else if (inputNumber.includes("0")) {
        return "Beep!";
    }
    else {
        var wholeStr = "";
        for (var i = 0; i <= parseInt(inputNumber); i++) {
            wholeStr += i + ", ";
        }
        
        return ((strOrder ==="ascending") ? wholeStr.slice(0, -2) : wholeStr.slice(0, -2).split(",").reverse().join(","))   ;
    }
}

//FRONT-END LOGIC
$(document).ready(function () {
    $("form#input").submit(function (event) {
        event.preventDefault();
        var inputName = $("#inputName").val();
        var inputNumber = $("#inputNumber").val();
        var strOrder = $('input:radio[name=strOrder]:checked').val(); 
        console.log(strOrder);
        $("#result").show();
        $("#convertedResult").empty();
        $("#convertedResult").append(numberConverter(inputNumber, inputName,strOrder));
        $('body, html').animate({ scrollTop: $("#result").offset().top }, 1000);
    });
});