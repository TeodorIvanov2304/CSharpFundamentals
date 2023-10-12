function solve (){

let number = 44444;
let position = 4;
let mask = 7 << position;
let result = 0;
result = number ^ mask;
console.log(result); 

}

solve();