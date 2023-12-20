let user = {
    name: 'Masha',
    age: 21
};

let numbers = [1, 2, 3];

let user1 = {
    name: 'Masha',
    age: 23,
    location: {
        city: 'Minsk',
        country: 'Belarus'
    }
};

let user2 = {
    name: 'Masha',
    age: 28, 
    skills: ["HTML", "CSS", "JavaScript", "React"]
};

const array = [
    {id: 1, name: 'Vasya', group: 10},
    {id: 2, name: 'Ivan', group: 11},
    {id: 3, name: 'Masha', group: 12},
    {id: 4, name: 'Petya', group: 10},
    {id: 5, name: 'Kira', group: 11},
];

let user4 = {
    name: 'Masha',
    age: 19,
    studies: {
        univirsity: "BSTU",
        speciality: 'designer',
        eyar: 2020,
        exams: {
            maths: true,
            programming: false
        }
    }
};

let user5 = {
    name: 'Masha',
    age: 22, 
    studies: {
        univirsity: "BSTU",
        speciality: 'designer',
        eyar: 2020,
        department: {
            faculty: 'FIT',
            group: 10,
        },
        exams: [
            {maths: true, mark: 8},
            {programming: true, mark: 4},
        ]
    }
};

let user6 = {
    name: 'Masha',
    age: 21, 
    studies: {
        univirsity: "BSTU",
        speciality: 'designer',
        eyar: 2020,
        department: {
            faculty: 'FIT',
            group: 10,
        },
        exams: [
            {
                maths: true, 
                mark: 8,
                professor: {
                    name: 'Ivan Ivanov',
                    degree: 'phD'
                }
            },
            {
                programming: true, 
                mark: 10,
                professor: {
                    name: 'Pert Petrov',
                    degree: 'phD'
                }
            },
        ]
    }
};

let user7 = {
    name: 'Masha',
    age: 20, 
    studies: {
        univirsity: "BSTU",
        speciality: 'designer',
        eyar: 2020,
        department: {
            faculty: 'FIT',
            group: 10,
        },
        exams: [
            {
                maths: true, 
                mark: 8,
                professor: {
                    name: 'Ivan Ivanov',
                    degree: 'phD',
                    articles: [
                        {title: "About HTML", pagesNumber: 3},
                        {title: "About CSS", pagesNumber: 5},
                        {title: "Avout JavaScript", pagesNumber: 1},
                    ]
                }
            },
            {
                programming: true, 
                mark: 10,
                professor: {
                    name: 'Pert Petrov',
                    degree: 'phD',
                    articles: [
                        {title: "About HTML", pagesNumber: 3},
                        {title: "About CSS", pagesNumber: 5},
                        {title: "Avout JavaScript", pagesNumber: 1},
                    ]
                }
            },
        ]
    }
};

let store = {
    state: {
        profilePage: {
            posts: [
                {id: 1, message: "Hi", likesCount: 12},
                {id: 2, message: "By", likesCount: 1},
            ],
            newPostText: "About me",
        },
        dialogsPage: {
            dialogs: [
                {id: 1, name: "Valeria"},
                {id: 2, name: "Andrey"},
                {id: 3, name: "Sasha"},
                {id: 4, name: "Viktor"},
            ],
            messages: [
                {id: 1, text: "hi"},
                {id: 2, text: "hi hi"},
                {id: 3, text: "hi hi hi"},
            ],
        },
        sidebar: [],
    }
}


function deepClone(obj) {
    if (obj === null || typeof obj !== 'object') {
      return obj;
    }
  
    const clone = Array.isArray(obj) ? [] : {};
  
    for (let key in obj) {
      if (obj.hasOwnProperty(key)) {
        clone[key] = deepClone(obj[key]);
      }
    }
  
    return clone;
  }

let userClone = deepClone(user);
let numbersClone = deepClone(numbers);
let user1Clone = deepClone(user1);
let user2Clone = deepClone(user2);
const arrayClone = deepClone(array);
let user4Clone = deepClone(user4);
let user5Clone = deepClone(user5);
let user6Clone = deepClone(user6);
let user7Clone = deepClone(user7);

user5Clone.studies.department.group = 12;
user5Clone.studies.exams[1].mark = 10;
console.log(JSON.stringify(user5Clone, null, 2));
console.log();

user6Clone.studies.exams[0].professor.name = "San Sansich";
console.log(JSON.stringify(user6Clone, null, 2));
console.log();


user7Clone.studies.exams[1].professor.articles[1].pagesNumber = 3;
console.log(JSON.stringify(user7Clone, null, 2));
console.log();


store.state.dialogsPage.messages.map(function(message){
    message.text = "Hello";
})
console.log(JSON.stringify(store, null, 2));
console.log();