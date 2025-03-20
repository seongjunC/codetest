using System;

public class Solution {
    public int solution(int i, int j, int k) {
        int answer = 0;
        for( int start = i ; start <= j; start++){
            string intStr = start.ToString();
            foreach(char a in intStr){
                if (a.ToString() == k.ToString()){
                    answer += 1;
                };
            }
        }
        return answer;
    }
}