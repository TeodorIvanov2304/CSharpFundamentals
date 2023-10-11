//Write a program that prints the bit at position 1 of the given integer. 
//We use the standard counting: from right to left, starting from 0

function solve (number){

let shiftedNumber = number >> 1;
let leastSignificantBit = shiftedNumber & 1;

console.log(leastSignificantBit);
}

solve(13) 