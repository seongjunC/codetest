using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        int num1 = 0;
        int num2 = 0;
        int mNum1 = 0;
        int mNum2 = 0;
        foreach(int i in numbers){
            if (i <= 0){
                if (mNum1>=i){
                    mNum2 = mNum1;
                    mNum1 = i;
                }
                else if(mNum2 > i){
                    mNum2 = i;
                }
            }
            else{
                if(num1 <= i){
                    num2 = num1;
                    num1 = i;
                }
                else if(num2 < i){
                    num2 = i;
                }
            }
        }
        answer = (num1*num2) > (mNum1* mNum2) ? num1*num2 : mNum1*mNum2;
        if(numbers.Length == 2){
            answer = numbers[0] * numbers[1];
        }
        return answer;
    }
}