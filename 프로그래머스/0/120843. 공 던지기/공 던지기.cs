using System;

public class Solution {
    public int solution(int[] numbers, int k) {
        int answer = 0;
        int numLen = numbers.Length;
        int now = -1 + 2*k;
        if(now% numLen != 0){
            answer = now % numLen;
        }
        else{
            answer = numLen;
        }
        return answer;
    }
}