using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        int strLen = my_string.Length;
        for(int i =0; i < strLen; i++){
            answer += my_string[strLen - i -1];
        }
        return answer;
    }
}