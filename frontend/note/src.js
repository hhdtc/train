//creating variable in js
//var let const
var x = 10;
var y = 12;
const z = false;

function funcA(a){
    //return
}

//Adding comments: /* */
var a = new Number(10);

//NaN: Not-a-Number: is a result when convgerting from a
//non-numeric string to a number using number object

var c = new Number('asdf');
console.log(c);
//NaN is not equal to any value, including itself
console.log(NaN === NaN)

//operationgs that involve NaN result in NaN itself.
console.log(NaN+13);

//user defined objects
//object literals

const employee = {
    name : 'John',
    age : 30,
    location: 'Chicago',
    greet: function(){
        return 'Hello my name is' + this.name;
    }
}

console.log(employee.name);
console.log(employee.greet);

function Person(name = 'anjila', age = 23, location = 'Chicago'){
    this.name = name;
    this.age = age;
    this.location = location;
    this.greet = function(){
        return 'asdfasdf';
    }
}

const person1 = new Person('John',30,'New York');
const person2 = new Person();
console.log()

//object.create()
const newPerson = Object.create(person1)
const newEmployee = Object.create(employee);

//classes
class Book{
    constructor(title, author, pages){
        this.title = title,
        this.author = author,
        this.pages = pages
    }

    greeting(){
        console.log('hello from book');
    }
}

const newBook = new Book('dd','dd',2);
console.log(newBook);

class Novel extends Book{
    constructor(title,author,pages,genre){
        super(title,author,pages);
        this.genre = genre;
    }
    displayInfo(){
        console.log("asdfasdf")
    }
}

const novel = new Novel('Harry Potter', 'JK',400,'fantasy');
console.log(novel)
novel.displayInfo();
novel.greet();
novel['name'];

var array = [1,true,{name: 'sarah'},12.33,'Hello'];
console.log(array);
array[1] = 5;
array.push(10);
console.log(array);
array.shift();//remove first element

let ind = 2;
let count = 1;
array.splice(ind,count);//remove from middle

function demo(){
    for(var i = 0; i<array.length; i++){
        if (array[i] === x){
            array.splice(i,1);
        }
    }
}

function validateForm(){
    const username = document.getElementById('username').value;
    const password = document.getElementById('password').value;

    if (username === ""){
        alert("Please enter your username");
        return false;
    }

    if (password === ""){
        alert("Please enter your password");
        return false;
    }
    return true;
}

function resetForm(){
    document.forms['myForm']['username'].value='';
    document.forms['myForm']['password'].value='';
}

const btn = document.querySelector(".btn");
btn.addEventListener('click',()=>{
    document.body.style.backgroundColor = 'orange';
});


document.cookie = "key = value";
document.cookie = "username = John Doe";
document.cokkie = "theme = dark";
console.log(document.cookie);//max size of cookie is 4kB
//can have expieration date
//persistant cookie, not destroyed, until reach expiration date.
//session, delete once the browser is clsoed

//local storage and session
//not send every time.
//session: conly stored on session.
//local storage: store persistant, no expiration date, unless manuall drop
//read by js

localStorage.setItem('key','item');
localStorage.getItem('key');

localStorage.removeItem('key');
localStorage.clear();//clear all local storage.

sessionStorage.setItem('key','item');
sessionStorage.getItem('key');
sessionStorage.removeItem('key');
sessionStorage.clear();

//localstorage: 5mB
//sessionstorage: 10mB


//xhr
//get resource
var oReq = new XMLHttpRequest();
oReq.addEventListener("load",reqListener);
oReq.open("GET","https://jsonplaceholder.typicode.com/posts");

//post
var oReq = new XMLHttpRequest();
oReq.addEventListener("load",reqListener);
oReq.open("POST","https://jsonplaceholder.typicode.com/posts");
oReq.send("title=xhr demo for post request&body=post request body&userId=1&Id=1");
function reqListener(){
    console.log(this.responseText);
}




//callbacks: fucntion that are passed as an argument to other function which are then invoked when a particular task complete
function fetchData(callback){
    setTimeout(()=>{
        const data = "Data fetched successfully";
        callback(data)
    },1000);
}


function handleData(data){
    console.log(data)
}

fetchData(handleData)


//closure: function returns a function
function outerFunction(){
    let outerVariable = "I am from outer function";
    function innerFunction(){
        console.log(outerVariable);
    }
    
    return innerFunction;
}

const innerFunc = outerFunction();


//promises: resolved or rejected
function myPromiseFunction(){
    return new Promise((resolve,reject)=>{
        setTimeout(()=>{
            const randomNumber = Math.random();
            if(randomNumber>0.5){
                resolve(randomNumber);
            }else{
                reject('number is too small');
            }
        },1000)
    })
}

myPromiseFunction().then((result)=>{
    console.log(result)
}).catch((error)=>{
    console.log(error)
})

//fetch api
fetch().then().then().catch()
fetch("url").then((response)=>response.json()).then((json)=>console.log(json))
fetch("url",{method: 'POST',
    body: JSON.stringify({
        title: 'Fetch post requests',
        body: 'This is a body',
        userId: 2
    }),
    header: {
        'Content-type': 'application/json'
    }
}).then((response)=>response.json()).then((json)=>console.log(json))

//create reousrce



//HTTP Request = header + body
//HTTP Response = header + body
//== allow type transfer
//1=='1'
//0==false
//null==undefined

//=== will also examine the type.

