using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        int firstNum = 0;
        int secondNum = 0;
        if(numbers[0]<numbers[1]){
            firstNum = numbers[0];
            secondNum = numbers[1];
        }
        else{
            firstNum = numbers[1];
            secondNum = numbers[0];
        }
        for (int i = 1; i < numbers.Length - 1;i++){
            if(secondNum<numbers[i+1]){
                firstNum = secondNum;
                secondNum = numbers[i+1];
                continue;
            }
            else if (firstNum < numbers[i+1]){
                firstNum = numbers[i+1];
                continue;
            }
        }
        answer = firstNum * secondNum;
        return answer;
    }
}