using System;

public class Solution {
    public int Uclid(int a, int b){
        if(b==0){
            return a;
        }
        return Uclid(b, a%b);  
    }
    public int solution(int a, int b) {
        int answer = 0;
        int div = Uclid(a, b);
        a /= div;
        b /= div;
        while(b%2 == 0){
            b /= 2;
        }
        while(b%5 == 0){
            b /= 5;
        }
        if(b == 1){
            answer =1;
        }
        else{
            answer =2;
        }
        return answer;
    }
}