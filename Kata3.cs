/* Task
An ATM ran out of 10 dollar bills and only has 100, 50 and 20 dollar bills.

Given an amount between 40 and 10000 dollars (inclusive) and assuming that the ATM wants to use as few bills as possible, determinate the minimal number of 100, 50 and 20 dollar bills the ATM needs to dispense (in that order).

Example
For n = 250, the result should be [2, 1, 0].

For n = 260, the result should be [2, 0, 3].

For n = 370, the result should be [3, 1, 1].

Input/Output
[input] integer n Amount of money to withdraw. Assume that n is always exchangeable with [100, 50, 20] bills.
[output] integer array An array of number of 100, 50 and 20 dollar bills needed to complete the withdraw (in that order).

*/

namespace myjinxin
{
    using System;
    
    public class Kata
    {
        public int[] Withdraw(int n){
          int total = n;
          
          int countTwenty = 0, countFifty = 0, countHundred = 0;
          
          while(total > 0){
            
            if(total >= 100 && (total - 100) % 20 == 0 ){
             total -= 100;             
             countHundred++;
            }
            else if(total >= 50 && (total -50) %20 == 0){
             total -= 50;
             countFifty++;
            }
            else if(total >= 20){
             total -= 20;
             countTwenty++;
            }
          }
          
          return new int[] {countHundred,countFifty,countTwenty};
        }
    }
}
