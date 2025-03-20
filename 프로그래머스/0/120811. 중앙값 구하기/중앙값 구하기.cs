using System;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        int arrayLen = array.Length;
        for (int i = 0; i<arrayLen; i++){
            for (int j =0; j<arrayLen-1; j++){
                if(array[j]>array[j+1]){
                    int temp = array[j];
                    array[j] = array[j+1];
                    array[j+1] = temp;
                    }
            }
        }
        answer = array[arrayLen/2];
        return answer;
    }
}