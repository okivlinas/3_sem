let arr = [1, [1, 2, [3, 4]], [2, 4]];

let flattenedArray = arr.reduce((acc, curr) => acc.concat(Array.isArray(curr) ? curr.flat() : curr), []);
console.log(flattenedArray);



let nestedArray = [1, [2, [3, 4]], [5, 6]];

function sumArray(arr) {
  return arr.reduce((acc, curr) => {
    if (Array.isArray(curr)) {
      return acc + sumArray(curr);
    }
    return acc + curr;
  }, 0);
}

let sum = sumArray(nestedArray);
console.log(sum);



let students = [
  { name: 'John', age: 18, groupId: 1 },
  { name: 'Alice', age: 20, groupId: 2 },
  { name: 'Bob', age: 16, groupId: 1 },
  { name: 'Emily', age: 19, groupId: 2 },
  { name: 'David', age: 21, groupId: 3 }
];

  function groupStudentsByAge(students) {
    const result = {};
  
    students.forEach(student => {
      if (student.age > 17) {
        const groupId = student.groupId;
  
        if (result[groupId]) {
          result[groupId].push(student);
        } else {
          result[groupId] = [student];
        }
      }
    }
    );
  
    return result;
  }

let groupedStudents = groupStudentsByAge(students);
console.log(groupedStudents);



let str = "ABC";
let total1 = 0;
let total2 = 0;

for (let i = 0; i < str.length; i++) {
  let charCode = str.charCodeAt(i);
  total1 = total1 * 10 + charCode;

  if (str[i] === "7") {
    total2 = total2 * 10 + 1;
  }
}

let difference = total1 - total2;
console.log(difference);


function extend(...objects) {
    return Object.assign({}, ...objects);
}
  
let obj1 = { a: 1, b: 2 };
let obj2 = { c: 3 };
let obj3 = { d: 4 };
  
let mergedObj = extend(obj1, obj2, obj3);
console.log(mergedObj);



function createTower(numFloors) {
    let tower = [];
  
    for (let i = 1; i <= numFloors; i++) {
      let spaces = " ".repeat(numFloors - i);
      let stars = "*".repeat(i * 2 - 1);
      let floor = spaces + stars + spaces;
      tower.push(floor);
    }
  
    return tower;
}
  
let tower = createTower(3);
console.log(tower);