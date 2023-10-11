// You are given a positive integer number and one binary digit B (0 or 1). 
// Your task is to write a program that finds the number of 
// binary digits (B) in a given integer.

function solve (number, digit) {
    let count = 0;
    while(number>0){
        let remainder = number % 2;
        number = Math.floor(number/2) // number /= 2 in C# 

        if(remainder === digit){
            count++;
        }
        
    }
    console.log(count);
}

solve(20,0);