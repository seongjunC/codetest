using System;

public class Solution {
    public int solution(int num, int k) {
        int answer = -1;
        string numStr = num.ToString();
        int x = 1;
        foreach(char cha in numStr){
            if(cha.ToString() == k.ToString()){
                answer = x;
                break;
            }
            x++;
        }
        return answer;
    }
}