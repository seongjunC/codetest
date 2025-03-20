using System;

public class Solution {
    public int solution(string[] s1, string[] s2) {
        int answer = 0;
        int s2Len = s2.Length;
        foreach(string i in s1){
            bool isThere = false;
            int k = 0;
            while (!isThere){
                if(i == s2[k]){
                    answer += 1;
                    isThere = true;
                }
                k++;
                if(k == s2Len){
                    break;
                }
            }
        }
        return answer;
    }
}