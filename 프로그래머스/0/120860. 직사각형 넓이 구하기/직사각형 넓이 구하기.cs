using System;

public class Solution {
    public int solution(int[,] dots) {
        int answer = 0;
            int beforeX = 0;
            int beforeY = 0;
            int horiz = 0;
            int verti = 0;
            for (int i = 0; i < 4; i++) { 
                if (i == 0)
                {
                    beforeX = dots[i,0];
                    beforeY = dots[i,1];
                }
                if (beforeX == dots[i,0])
                {
                    horiz = Math.Abs(dots[i,1] - beforeY);
                }
                if (beforeY == dots[i,1])
                {
                    verti = Math.Abs(dots[i,0] - beforeX);
                }
            }
            answer = horiz * verti;
        return answer;
    }
}