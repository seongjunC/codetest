using System;

public class Solution {
    public int solution(int balls, int share) {
        int answer = 0;
        double num = 1;
        for(int i = 0; i<share; i++){
            num *= (balls- i);
        }
        for(int i = 0; i<share; i++){
            num /= (share - i);
        }
        answer = (int)num;
        return answer;
    }
}