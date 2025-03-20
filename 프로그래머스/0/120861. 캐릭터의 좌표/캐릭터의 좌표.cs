using System;

public class Solution {
    struct Position{
        public int x;
        public int y;
    }
    public int[] solution(string[] keyinput, int[] board) {
        Position pos;
        pos.x = 0;
        pos.y = 0;
        int[] answer = new int[2];
        foreach(string key in keyinput){
            if(key == "up"){
                if(pos.y < board[1]/2){
                    pos.y += 1;
                }
            }
            else if(key == "down"){
                if(pos.y > -board[1]/2){
                    pos.y -= 1;
                }
            }
            else if(key == "left"){
                if(pos.x > -board[0]/2){
                    pos.x -= 1;
                }
            }
            else if(key == "right"){
                if(pos.x < board[0]/2){
                    pos.x += 1;
                }
            }
        }
        answer[0] = pos.x;
        answer[1] = pos.y;
        return answer;
    }
}