function createString(defaultParam, userInput, thirdParam) {
    if (typeof thirdParam === 'undefined') {
      thirdParam = defaultParam;
    }
    
    var result = defaultParam + ' ' + userInput + ' ' + thirdParam;
    
    return result;
  }
  
  var defaultParam = 'по умолчанию';
  var userInput = prompt('Введите значение второго параметра:');
  var thirdParam = prompt('Введите значение третьего параметра:');
  
  var resultString = createString(defaultParam, userInput, thirdParam);
  console.log(resultString);