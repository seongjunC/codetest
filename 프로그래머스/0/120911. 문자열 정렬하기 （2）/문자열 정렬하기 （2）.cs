using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        string[] answerArray = new string[my_string.Length];
        int k = 0;
        foreach(char cha in my_string){
            char CharLow = Char.ToLower(cha);
            answerArray[k++] = CharLow.ToString();
        }
        Array.Sort(answerArray);
        foreach(string cha in answerArray){
            answer += cha;
        }
        return answer;
    }
}