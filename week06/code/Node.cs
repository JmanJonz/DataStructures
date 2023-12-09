using System.Data.SqlTypes;

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

        return false;
    }

    public int GetHeight() {
        // TODO Start Problem 4
        return 0; // Replace this line with the correct return statement(s)
    }
}