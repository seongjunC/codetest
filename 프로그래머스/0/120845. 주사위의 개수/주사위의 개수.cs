using System;

public class Solution {
    public int solution(int[] box, int n) {
        int answer = 0;
        int boxX = box[0]/n;
        int boxY = box[1]/n;
        int boxZ = box[2]/n;
        answer = boxX * boxY * boxZ;
        return answer;
    }
}