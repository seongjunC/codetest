using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        int strLen = my_string.Length;
        for (int i = 0; i<strLen; i++){
            char strChar = my_string[i];
            if (strChar != 'a' && strChar != 'e' && strChar !='i' && strChar != 'o' && strChar !='u'){
                answer += strChar;
            }
                
        }
        return answer;
    }
}