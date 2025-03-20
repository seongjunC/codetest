using System;

public class Solution {
    public int solution(string before, string after) {
        int answer = 0;
        char[] charArrBe = before.ToCharArray();
        char[] charArrAf = after.ToCharArray();
        foreach(char chab in charArrBe){
            for(int i = 0; i<charArrAf.Length; i++){
                if(chab == charArrAf[i]){
                    charArrAf[i] = Char.ToUpper(charArrAf[i]);
                    break;
                }
            }
        }
        string afterS = new string(charArrAf);
        if(after.ToUpper() == afterS){
            answer = 1;
        }
        else{
            answer = 0;
        }
        return answer;
    }
}