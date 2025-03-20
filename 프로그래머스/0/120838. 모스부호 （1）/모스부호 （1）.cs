using System;

public class Solution {
    public string solution(string letter) {
        string answer = "";
        string[] phraseLetter = letter.Split(' ');
        string[] mossLetter ={".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};
        string[] alphabet = {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"};
        foreach(string str in phraseLetter){
             for (int i =0; i<26; i++){
                 if(str == mossLetter[i]){
                     answer += alphabet[i];
                     break;
                 }
             }
        }
        return answer;
    }
}