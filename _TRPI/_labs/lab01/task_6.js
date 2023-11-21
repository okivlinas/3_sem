let russian = true;
let math = true;
let engl = false;
if(russian && math && engl)
    console.log("Переход на следующий курс");
else if(russian || math || engl)
    console.log("Пересдача");
else 
    console.log("Отчислен");