using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        for(int i =1; i<=n; i++){
                int divAble = 0;
                for(int k = 1; k<=i; k++){
                    if(i%k == 0){
                        divAble += 1;
                    }
                }
                if(divAble >=3){
                    answer += 1;
                }
        }
        return answer;
    }
}