function* movving(){
    let coord = [0, 0];
    let command;
    while(true){
        command = prompt("Enter your command: ");
        if(command == "left"){
            coord[0]-=10;
        }
        else if(command == "right"){
            coord[0]+=10;
        }
        else if(command == "up"){
            coord[1]+=10;
        }
        else if(command == "down"){
            coord[1]-=10;
        }
        else if(command == "exit"){
            break;
        }
        else {
            alert("Unknown kommad");
        }
        yield coord;
    }
}
for(let coords of movving())
{
    alert(coords);
}