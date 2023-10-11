function solve (number, position){

    let shiftedNumber = number >> position;
    let leastSignificantBit = shiftedNumber & 1;
    
    console.log(leastSignificantBit);
    }
    
    solve(512, 0) 