            //You are given an array of positive integers in a single line, separated by a space(' '). 
            //All numbers occur an even number of times except one number, 
            //which occurs an odd number of times.Find it using only bitwise operations

function solve(){
// Crating an inputArray
let inputArray = "5 7 2 7 5 2 5".split(' ').map(Number);
let result = 0;
// Create a variable to store the result

// Iterate through the array
for (let i = 0; i < inputArray.length; i++) {
  // Perform XOR on each element of the array
  
  result = result ^ inputArray[i];
}

// Print the resultlet result = 0;

console.log(result);
}
solve();
