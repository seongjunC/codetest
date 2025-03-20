using System;

public class Solution {
    public int solution(int hp) {
        int answer = 0;
        int load = hp / 5;
        hp %= 5;
        int soldier = hp/3;
        hp %= 3;
        int worker = hp / 1;
        answer = load + soldier + worker;
        return answer;
    }
}