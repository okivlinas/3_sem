function paralel(a){
    return (b) => {
        return (c) => {
            return a * b * c;
        }
    }
}
console.log(paralel(1)(2)(4));
let constRebro = paralel(3);
console.log(paralel(3));