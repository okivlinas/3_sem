products = {
    shoes: {
        boots: [
            {id: 1, size: 41, color: "Red", price: 120},
            {id: 2, size: 42, color: "Blue", price: 110},
            {id: 3, size: 43, color: "Black", price: 130}
        ],
        sneakers: [
            {id: 4, size: 41, color: "Black", price: 140},
            {id: 5, size: 42, color: "Red", price: 115},
            {id: 6, size: 43, color: "Blue", price: 145}
        ],
        sandals: [
            {id: 7, size: 41, color: "Blue", price: 125},
            {id: 8, size: 42, color: "Black", price: 105},
            {id: 9, size: 43, color: "Red", price: 135}
        ]
    }
}

function custumFilter(shoes, more, less, size, color){
    let result = [];

    Object.entries(shoes).forEach(function([key, value]){
        let items = value;
        for(let item of items){
            if((item.size == size || size == undefined)
            && (item.color == color || color == undefined)
            && (item.price >= more || more == undefined)
            && (item.price <= less || less == undefined)){
                result = [...result, item]; 
        };
        }
    })
    return result
}

let filteredShoue = custumFilter(products.shoes,125, 140, 41, );
console.log(filteredShoue);

newProducts = {
    shoes: {
        boots: [
            {id: 1, size: 41, color: "Red", price: 120, discount: 10, get Price(){return this.price*(1-this.discount/100)}},
            {id: 2, size: 42, color: "Blue", price: 110, discount: 15, get Price(){return this.price*(1-this.discount/100)}},
            {id: 3, size: 43, color: "Black", price: 130, discount: 11, get Price(){return this.price*(1-this.discount/100)}}
        ],
        sneakers: [
            {id: 4, size: 41, color: "Black", price: 140, discount: 12, get Price(){return this.price*(1-this.discount/100)}},
            {id: 5, size: 42, color: "Red", price: 115, discount: 13, get Price(){return this.price*(1-this.discount/100)}},
            {id: 6, size: 43, color: "Blue", price: 145, discount: 15, get Price(){return this.price*(1-this.discount/100)}}
        ],
        sandals: [
            {id: 7, size: 41, color: "Blue", price: 125, discount: 20, get Price(){return this.price*(1-this.discount/100)}},
            {id: 8, size: 42, color: "Black", price: 105, discount: 16, get Price(){return this.price*(1-this.discount/100)}},
            {id: 9, size: 43, color: "Red", price: 135, discount: 17, get Price(){return this.price*(1-this.discount/100)}},
        ]
    }
}

let someShoe = newProducts.shoes.boots[0];
console.log(someShoe.Price);

Object.defineProperty(someShoe, "price", {
    writable: true,
    enumerable: true,
    configurable: false
});

Object.defineProperty(someShoe, "id", {
    writable: true,
    enumerable: false,
    configurable: false
});
console.log(someShoe);
delete someShoe.id;
delete someShoe.color;
console.log(someShoe);

for(s in someShoe){
    console.log(s);
}

function Shoe(id, size, color, price, discount){
    this.id = id, 
    this.size = size,
    this.color = color,
    this.price = price,
    this.discount = discount
};

let allProducts = {
    shoes:{
        boots: [
            new Shoe(1, 41, "Red", 120, 10),
            new Shoe(2, 42, "Blue", 110, 15),
            new Shoe(3, 43, "Black", 130, 11)
        ],
        sneakers: [
            new Shoe(4, 41, "Black", 140, 12),
            new Shoe(5, 42, "Red", 115, 13),
            new Shoe(6, 43, "Blue", 145, 15)
        ],
        sandals: [
            new Shoe(7, 41, "Blue", 125, 20),
            new Shoe(8, 42, "Black", 105, 16),
            new Shoe(9, 43, "Red", 135, 17)
        ]
    }
}