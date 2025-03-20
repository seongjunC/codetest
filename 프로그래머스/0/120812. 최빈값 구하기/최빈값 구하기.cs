using System;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        int answerSave = -2;
        Array.Sort(array);
        int numSame = 1;
        int numBefore = -1;
        int numUp = 0;
        int numHigh = -1;
        foreach(int i in array){
            if(i == numBefore){
                numSame += 1;
                if (numUp < numSame){
                    answerSave = i;
                    numHigh = i;
                    numUp = numSame;
                }
                else if (numUp == numSame){
                    answerSave = -1;
                }
                
            }
            else{
                if(answerSave == -2){
                    answerSave = i;
                }
                else if(numUp == 0 && numSame == 1){
                    answerSave = -1;
                }
                numSame = 1;
                numBefore = i;
            }
        }
        answer = answerSave;
        return answer;
    }
}