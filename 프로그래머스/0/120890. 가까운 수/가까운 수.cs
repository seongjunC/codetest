using System;

public class Solution {
    public int solution(int[] array, int n) {
        int answer = 0;
        int numDif = 0;
        int minDif = 1000;
        int minNum = 0;
        Array.Sort(array, (a,b) => a > b ? -1 : 1);
        foreach(int i in array){
            numDif  = Math.Abs(i - n);
            if (minDif >= numDif){
                minDif = numDif;
                minNum = i;
            }
        }
        answer = minNum;
        return answer;
    }
}