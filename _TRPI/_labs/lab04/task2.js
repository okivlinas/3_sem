//task_2
let students = new Set();

function addStudent(student){
    students.add(student);
}
function removeStudent(studentId) {
    students.forEach((student) => {
      if (student.studentId === studentId) {
        students.delete(student);
      }
    });
  }
function filterStudent(group){
    students.forEach((students) => {
        if(students.group == group){
            console.log(students);
        }
    });
}

function sortStudentsByStudentId() {
    return Array.from(students).sort((a, b) => a.studentId - b.studentId);
}

addStudent({ studentId: 1, group: "A", fullName: "Иванов Иван" });
addStudent({ studentId: 2, group: "B", fullName: "Петров Петр" });
addStudent({ studentId: 3, group: "A", fullName: "Сидоров Сидор" });
addStudent({ studentId: 1, group: "C", fullName: "Олегов Олег" });

filterStudent("A");
removeStudent(1);
filterStudent("A");

console.log(sortStudentsByStudentId());