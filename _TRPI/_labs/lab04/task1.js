//task_1
let products = new Set();

function addProduct(product){
    products.add(product);
}
function removeProduct(product){
    products.delete(product);
}
function isProduct(product){
    return products.has(product);
}
function countOfProduct(){
    return products.size;
}

addProduct("Яблоко");
addProduct("Банан");
addProduct("Кефир");
addProduct("Сок");
console.log(isProduct("Яблоко"));
console.log(isProduct("Сникерс"));
console.log(countOfProduct());
removeProduct("Банан");
console.log(isProduct("Банан"));
console.log(countOfProduct());