﻿/*
 * CSE212 
 * (c) BYU-Idaho
 * 02-Prove - Problem 1.1
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */
public static class Sorting {
    public static void Run() {
        var numbers = new[] { 3, 2, 1, 6, 4, 9, 8 };
        SortArray(numbers);
        Console.Out.WriteLine("int[]{{{0}}}", string.Join(", ", numbers)); //int[]{1, 2, 3, 4, 6, 8, 9}
    }

    // got an array of ints
    private static void SortArray(int[] data) {
    // we are getting the length of the array and working from the end to the start
    // runs once for every int in array
        for (var sortPos = data.Length - 1; sortPos >= 0; sortPos--) {
        // a nested loop runs start to finish once for every item in array
            for (var swapPos = 0; swapPos < sortPos; ++swapPos) {
                if (data[swapPos] > data[swapPos + 1]) {
                    (data[swapPos + 1], data[swapPos]) = (data[swapPos], data[swapPos + 1]);
                }
            }
        }
    }
}