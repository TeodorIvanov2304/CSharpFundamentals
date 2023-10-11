//Write a program that sets the bit at position p to 0. Print the resulting integer.

function solve(number, position){
    let mask = 1 << position;
    mask = ~mask;
    let result = number & mask;
    console.log(result);
}

solve(1313,5);