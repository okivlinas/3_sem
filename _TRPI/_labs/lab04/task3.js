//task_3
let products = new Map();

function addProducts(id, name, col, price){
    products.set(id, {name, col, price});
}
function removeByID(id){
    products.delete(id);
}
function removeByName(name) {
    for (let [id, product] of products) {
      if (product.name === name) {
        products.delete(id);
      }
    }
}
function updateCol(id, newCol) {
    if (products.has(id)) {
      const product = products.get(id);
      product.col = newCol;
      products.set(id, product);
    }
}
function updatePrice(id, newPrice) {
    if (products.has(id)) {
      const product = products.get(id);
      product.price = newPrice;
      products.set(id, product);
    }
}
function getProductCount() {
    return products.size;
}
function getTotalPrice() {
    let totalPrice = 0;
    for (const product of products.values()) {
      totalPrice += product.col * product.price;
    }
    return totalPrice;
}

// Пример использования функций
addProducts(1, "Телефон", 2, 100);
addProducts(2, "Ноутбук", 1, 500);
addProducts(3, "Телевизор", 3, 200);

console.log(getProductCount()); // 3
console.log(getTotalPrice()); // 1300

removeByID(2);
console.log(getProductCount()); // 2
console.log(getTotalPrice()); // 800

removeByName("Телефон");
console.log(getProductCount()); // 1
console.log(getTotalPrice()); // 600

updateCol(3, 5);
console.log(getTotalPrice()); // 1000

updatePrice(3, 250);
console.log(getTotalPrice()); // 1250