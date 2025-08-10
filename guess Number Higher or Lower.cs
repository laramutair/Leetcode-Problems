/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        int left = 1;
        int right = n;
        while (left <= right) {
            int myNum = left + (right - left) / 2;
            int guessN = guess(myNum);
            switch (guessN) {
                case 0:
                    return myNum;
                case 1:
                    left = myNum + 1;
                    break;
                case -1:
                    right = myNum - 1;
                    break;
            }
        }
        return -1; 
    }
}
