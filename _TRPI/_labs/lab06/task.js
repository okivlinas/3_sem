//1.	Имеется массив numbers. Сохранить первый элемент массива в переменную y используя деструктуризацию.
let numbers = [1,2,3,4,5,6]
let [firstNumber] = numbers
console.log(firstNumber)

//2.	Объект user имеет свойства name, age. Создайте объект admin, у которого есть свойства admin и все свойства объекта user. Используйте spread-оператор.
let user = {name: "Oleg", age: 18}
let admin = {admin: true, ...user}
console.log(admin)

//3.	Выполнить деструктуризацию объекта store до 3 уровня вложенности. После этого вывести значения likesCount из массива posts.
// Выполнить фильтрацию массива dialogs – выбрать пользователей с четными id.   
//В массиве messages заменить все сообщения на “Hello user” (использовать метод map).
let store ={
    state:{
        profilePage:
        {
            posts:
            [
                {id: 1, message: 'Hi', likesCount: 12},
                {id: 2, message: 'By', likesCount: 1},
            ],
            newPostText: 'About me',
        },
        dialogsPage:
        {
            dialogs:
            [
                {id: 1, name: 'Valera'},
                {id: 2, name: 'Andrey'},
                {id: 3, name: 'Sasha'},
                {id: 4, name: 'Victord'},
            ],
            message:
            [
                {id: 1, message: 'hi'},
                {id: 2, message: 'hi hi'},
                {id: 3, message: 'hi hi hi'},
            ],
        },
        sidebar:[],
    },
}
let {
    state: {
      profilePage: {
        posts,
      },
      dialogsPage: {
        dialogs,
        message,
      },
    },
  } = store;
  
  let likeCounts = posts.map(post => post.likesCount);
  console.log(likeCounts)

  let filterDialogs = dialogs.filter(item => item.id % 2 === 0)
  console.log(filterDialogs)

  console.log(store.state.dialogsPage.message)

  store.state.dialogsPage.message.map(item => item.message="Hello user")
  console.log(store.state.dialogsPage.message)

  //4.	В массиве tasks хранится список задач. Создать новую задачу task и добавить ее в массив, используя spread оператор.
  let task=[
    {id: 1, title: "HTML&CSS", isDone: true},
    {id: 2, title: "JS", isDone: true},
    {id: 3, title: "ReactJS", isDone: false},
    {id: 4, title: "Rest API", isDone: false},
    {id: 5, title: "GraphQl", isDone: false},
]
let Newtask = {id: 6,title: "SCSS",isDone: false}
task=[...task, Newtask]
console.log(task)
//5.	Массив [1, 2, 3] передайте в качестве параметра функции sumValues. Используйте spread оператор.
function sumValues(x, y, z)
{
    return x + y + z;
}
let array=[1, 2, 3]
console.log(sumValues(...array))