function makeCounter()
{
    let count=0;
    return function(){
    return count++;
   }
}
let counter1=makeCounter();
alert(counter1());
alert(counter1());

let counter2=makeCounter();
alert(counter2());
alert(counter2());
