let teacherName = "Кудлацкая Марина Федоровна".toLowerCase().split(" ")
let userInput = prompt("имя").toLowerCase().split(" ")

alert(userInput);

if (teacherName[1]==userInput[0])
    alert("Вы угадали")
else if((teacherName[1]+' '+teacherName[2])==(userInput[0]+' '+userInput[1]))
    alert("вы угадали")
else if(JSON.stringify(teacherName)==JSON.stringify(userInput))
    alert("Вы угадали")
else
    alert("Неверно")