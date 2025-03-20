using System;

public class Solution {
    public long solution(string numbers) {
        long answer = 0;
        char[] charArr = numbers.ToCharArray();
        for(int i = 0; i<charArr.Length;i++){
            answer *= 10;
            if(charArr[i] == 'z'){
                i += 3;
            }
            else if(charArr[i] == 'o'){
                answer += 1;
                i += 2;
            }
            else if(charArr[i] == 't'){
                if(charArr[i+1] == 'w'){
                    answer += 2;
                    i += 2;
                }
                else{
                    answer += 3;
                    i += 4;
                }
            }
            else if(charArr[i] == 'f'){
                if(charArr[i+1] == 'o'){
                    answer += 4;
                    i += 3;
                }
                else{
                    answer += 5;
                    i += 3;
                }
            }
            else if(charArr[i] == 's'){
                if(charArr[i+1] == 'i'){
                    answer += 6;
                    i += 2;
                }
                else{
                    answer += 7;
                    i += 4;
                }
            }
            else if(charArr[i] == 'e'){
                answer += 8;
                i += 4;
            }
            else if(charArr[i] == 'n'){
                answer += 9;
                i += 3;
            }
        }
        return answer;
    }
}