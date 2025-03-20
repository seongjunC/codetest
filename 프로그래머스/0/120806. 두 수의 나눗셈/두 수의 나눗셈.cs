using System;

public class Solution {
    public int solution(int num1, int num2) {
        int answer = 0;
        float divNum = (float)num1/ num2; 
        divNum *= 1000;
        answer = (int)divNum;
        return answer;
    }
}