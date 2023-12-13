using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System;

public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        // the binarySearchTree class creates a node object and then uses this function calling it on the 
        // root node everytime in order to insert a value and that is all it gives us
        // so this method needs to insert a value only having access to the trees root node and the value that 
        // is to be inserted... it must work it's way through the tree from root node and onward in order to do so
        // check if the current value is = to data and if so just exit the method and don't do anthing 
        // as we don't want duplicates 
            if(value == Data){
                return;
            }
        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                // a recursive call if value needs to be added to the left but it's full it repeats 
                // the insert process over again
                Left.Insert(value);
        }
        else {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                // recursive call to this very function to repeat the input process again having moved one value right
                Right.Insert(value);
        }
    }

    public bool Contains(int value) {
        // use recursion to loop through the tree to where the node should be inserted if it were to be
        // if the current node in the recursive function call is ever = to the value then return true
        // if the current node in the recursive function call is not = to it and where it would go if it were
        // to be inserted then return false as it is nowhere in the tree
        
        if(value == Data){
            return true;
        }else if(value < Data){
            if(Left is null){
                return false;
            }else{
                return Left.Contains(value);
            }
        }else if(value > Data){
            if(Right is null){
                return false;
            }else{
                return Right.Contains(value);
            }
        }
        
        else{
            return false;
        }
    }

    public int GetHeight() {
        // base case we know we have made it as far as we can go when the left or right node is null - doesn't exist
        // in this case just return 1 to account for the current node
            if(Left is null & Right is null){
                return 1;
            }
        // otherwise the repeated smaller subproblem is to get the height of the left and right sub trees and return what ever
        // on is greater
            var leftHeight = 0;
            var rightHeight = 0;
            if(Left is not null & Right is not null){
                leftHeight = Left.GetHeight();
                rightHeight = Right.GetHeight();
            }else if(Left is not null & Right is null){
                leftHeight = Left.GetHeight();
                rightHeight = 0;
            }else{
                leftHeight = 0;
                rightHeight = Right.GetHeight();
            }
            if(leftHeight > rightHeight){
                return 1 + leftHeight;
            }else{
                return 1 + rightHeight;
            }
    }
}