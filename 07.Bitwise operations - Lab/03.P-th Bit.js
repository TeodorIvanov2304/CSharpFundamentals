// Write a program that prints the bit at position p of the given integer. 
//We use the standard counting: from right to left, starting from 0.

function solve (number, position){

    let shiftedNumber = number >> position;
    let leastSignificantBit = shiftedNumber & 1;
    
    console.log(leastSignificantBit);
    }
    
    solve(512, 0) 