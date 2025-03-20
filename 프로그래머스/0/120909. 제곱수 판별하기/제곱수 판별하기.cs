using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int k = 1;
        while(true){
            int kPow = k * k;
            if(kPow == n){
                answer = 1;
                break;
            }
            else if(kPow > n){
                answer = 2;
                break;
            }
            k++;
        }
        return answer;
    }
}