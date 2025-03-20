using System;

public class Solution {
    public string solution(string bin1, string bin2) {
        string answer = "";
        long binSum = long.Parse(bin1) + long.Parse(bin2);
        string binStr = "";
        while(binSum != 0){
            if(binSum % 10 == 2){
                binStr += 0;
                binSum += 10;
            }
            else if(binSum % 10 == 1){
                binStr += 1;
            }
            else if(binSum % 10 == 0){
                binStr += 0;
            }
            else if(binSum % 10 == 3){
                binStr += 1;
                binSum += 10;
            }
            binSum /= 10;
        }
        char[] binChar = binStr.ToCharArray();
        for(int i = binChar.Length-1; i >= 0;i--){
            answer += binChar[i];
        }
        if(answer == ""){
            answer = "0";
        }
        return answer;
    }
}