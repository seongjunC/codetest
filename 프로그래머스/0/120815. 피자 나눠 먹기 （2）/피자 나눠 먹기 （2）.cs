using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int k = 1;
        while(true){
            if((n*k)%6 == 0){
                answer = n*k/6;
                break;
            }
            k++;
        }
        return answer;
    }
}