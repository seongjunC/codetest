using System;

public class Solution {
    public int[] solution(int[] numbers, int num1, int num2) {
        int[] answer = new int[] { };
        int numLen = num2-num1+1;
        Array.Resize(ref answer, numLen);
        for (int i = 0; i <  numLen; i++){
            answer[i] = numbers[num1 + i];
        }
        return answer;
    }
}