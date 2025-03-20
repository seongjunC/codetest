using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int fac = 1;
        int k = 1;
        while(fac <= n){
            fac *= ++k;
        }
        answer = k-1;
        return answer;
    }
}