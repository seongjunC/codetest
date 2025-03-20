using System;

public class Solution {
    public string solution(string cipher, int code) {
        string answer = "";
        for (int i = 1; i<= cipher.Length/code; i++){
            answer += cipher[code*i-1];
        }
        return answer;
    }
}