

let salaries = {
    John: 100,
    Ann: 160,
    Pete: 130
    };

let sum = 0;
for (let p in salaries){
    sum += salaries[p];
}

console.log(s);

let menu = {
    width: 200,
    height: 300,
    title: "My menu"
};

function multiplyNumeric(menu){
    for (let k in menu){
        if (typeof menu[k] === 'number'){
            menu[k] = menu[k]*2;
        }
    }
}
multiplyNumeric(menu);

function checkEmailId(str) {
    str = str.toLowerCase();
  
    if (str.includes('@') && str.includes('.')) {
      let atIndex = str.indexOf('@');
      let dotIndex = str.indexOf('.');
      if (atIndex < dotIndex) {
        if (dotIndex - atIndex >= 1) {
          return true;
        }
      }
    }
  
    return false;
  }

function truncate(str, maxlength) {
    if (str.length > maxlength) {
      return str.slice(0, maxlength - 3) + '...';
    } else {
      return str;
    }
}


let arr = ['James','Brennie'];
arr.push('Robert');
arr[2] = 'Calvin';
console.log(arr.shift());

array.unshift('Rose', 'Regal');
