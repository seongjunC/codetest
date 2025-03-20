using System;

public class Solution {
    public string solution(string my_string, string letter) {
        string answer = "";
        int strLen = my_string.Length;
        int n= 0;
        for (int i = 0; i< strLen; i++){
            if(my_string[i] != letter[0]){
                answer += my_string[i];
            }
        }
        return answer;
    }
}