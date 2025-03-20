using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        foreach(char cha in my_string){
            if(answer.Contains(cha)){
                continue;
            }
            answer += cha;
        }
        return answer;
    }
}