function basicOperation(operation, value1, value2) {
    
    if (operation == "+"){
        return value1 + value2;
    }
    if (operation == "-"){
        return value1 - value2;
    }
    if(operation == "*"){
        return value1 * value2;
    }
    if(operation == "/"){
        return value1 / value2;
    }
    return "Cannot parse the operator."
}
alert(a(3));
let a = function(number){
    let summ = 0;
    for(i = 1; i <= number; i++){
        summ += i ^ 3;
    }
    return summ;
}

function getArithmeticAverage(numbers){
    let result = 0;
    for(i = 0; i < numbers.length; i++){
        result += numbers[i];
    }
    return result / numbers.length;
}

function getReversedEnglishString(str){
    let result = "";
    for (i = str.length; i >= 0; i--){
        if (str[i] > "A" && str[i] < "z")
        result += str[i];
    }
    return result;
}

function getRepeatedString(n, str){
    let result = "";
    for (i = 0; i < n; i++){
        result += str;
    }
    return result;
}

function getArr1MinusArr2(arr1, arr2){
    // for(i = 0; i < arr1.length; i++){
    //     for(j = 0; j < arr2.length; j++){
    //         if(arr1[i] == arr2[j]){
    //             arr1.splice(i, 1);
    //         }
    //     }
    // }
    for(i = 0; i < arr1.length; i++){
        if(arr2.includes(arr1[i])){
            arr1.splice(i, 1);
        }
    }
    return arr1;
}

alert(basicOperation("+", 4, 5));

alert(getArithmeticAverage([1,2,3,4,5]));
alert(getReversedEnglishString("JavaScr53э? ipt"));
alert(getRepeatedString(2, "knock"));
alert(getArr1MinusArr2(["Who", "it", "is", "there", "someone", "?"], ["it", "someone"]));