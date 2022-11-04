let myNum = 53211235;
let num = myNum;
let reversedNum = 0;




while (num >= 1) {
   let digit = num % 10;
   reversedNum = reversedNum * 10 + digit
   num = (num - num % 10) / 10;
}

console.log(reversedNum);
if (reversedNum == myNum) {
   console.log(myNum + " It is polindrome number");
} else {
   console.log(myNum + " It isn't polindrome number");
}