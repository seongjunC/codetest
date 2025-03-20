using System;

public class Solution {
    public string solution(int age) {
        string answer = "";
        int numAge = 0;
        int ageDiv = age;
        while (ageDiv != 0){
            ageDiv /= 10;
            numAge++;
        }
        string[] anString = new string[numAge];
        for(int k = 0; k < numAge; k++){
            int i = age % 10;
            age /= 10;
            switch(i){
                case 0:
                    anString[k] = "a";
                    break;
                case 1:
                    anString[k] = "b";
                    break;
                case 2:
                    anString[k] = "c";
                    break;
                case 3:
                    anString[k] = "d";
                    break;
                case 4:
                    anString[k] = "e";
                    break;
                case 5:
                    anString[k] = "f";
                    break;
                case 6:
                    anString[k] = "g";
                    break;
                case 7:
                    anString[k] = "h";
                    break;
                case 8:
                    anString[k] = "i";
                    break;
                case 9:
                    anString[k] = "j";
                    break;
                default:
                    break;
            }
        }
        for(int i = 0; i<anString.Length;i++){
            answer += anString[anString.Length-i-1];
        }
        return answer;
    }
}