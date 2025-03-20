using System;

public class Solution {
    public int solution(string str1, string str2) {
        int answer = 0;
        int isThere = 0;
        isThere = str1.IndexOf(str2);
        if (isThere == -1){
            answer = 2;
        }
        else{
            answer =1;
        }
        return answer;
    }
}