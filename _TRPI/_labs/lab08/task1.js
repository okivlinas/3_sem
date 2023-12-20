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

let copyUser = { ...user };
let copyNumbers = [ ...numbers ];
let copyUser1 = { ...user1, location: { ...user1.location } };
let copyUser2 = { ...user2, skills: [ ...user2.skills ] };
let copyArray = [ ...array.map(item => ({ ...item })) ];
let copyUser4 = { ...user4, studies: { ...user4.studies, exams: { ...user4.studies.exams } } };
let copyUser5 = {
    ...user5,
    studies: {
      ...user5.studies,
      department: { 
        ...user5.studies.department,
        faculty: { 
            ...user5.studies.department,
        },

        group:{
            ...user5.studies.department,
        }
    },
      exams: {
        ...user5.studies.exams,
        math: {
            ...user5.studies.exams,   
        },
        programming: {
            ...user5.studies.exams,  
        }
      }
    }
  };

console.log(copyUser);
console.log(copyNumbers);
console.log(copyUser1);
console.log(copyUser2);
console.log(copyArray);
console.log(copyUser4);
copyUser5.studies.department.faculty = 'GIT';
console.log(user5);
console.log(copyUser5);