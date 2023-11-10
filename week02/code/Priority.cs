/*
 * CSE212 
 * (c) BYU-Idaho
 * 02-Prove - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */
public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: The Enqueue function shall add an item (which contains both data and priority) to the back of the queue.
        // Expected Result: see lightning and 10 at the end of the printed queue...
        Console.WriteLine("Test 1");
        var priorityQueue1 = new PriorityQueue();
        priorityQueue1.Enqueue("fire", 8);
        priorityQueue1.Enqueue("lightning", 10);
        Console.WriteLine(priorityQueue1.ToString());
        // Defect(s) Found: Looks good!

        Console.WriteLine("---------");

        // Test 2
        // Scenario: The Dequeue function shall remove the item with the highest priority and return its value.
        // Expected Result: Value of lightning should be displayed even though it's not at the front of the queue...
        Console.WriteLine("Test 2");
        priorityQueue1.Enqueue("air", 7);
        Console.WriteLine(priorityQueue1.Dequeue());
        // Defect(s) Found: None, works as it should...

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
        // Test 3
        // Scenario: If there are more than one item with the highest priority, then the item closest to the front of the queue will be removed and its value returned.
        // Expected Result: to see lightning printed as it has the same priority as electricity but it was first in line...
        Console.WriteLine("Test 3");
        var priorityQueue2 = new PriorityQueue();
        priorityQueue1.Enqueue("fire", 8);
        priorityQueue1.Enqueue("lightning", 10);
        priorityQueue1.Enqueue("Electricity", 10);
        Console.WriteLine(priorityQueue1.Dequeue());

        // Defect(s) Found: works as it should

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
        // Test 4
        // Scenario: If the queue is empty, then an error message will be displayed.
        // Expected Result: an error message to be displayed saying something along the lines of it being empty
        Console.WriteLine("Test 4");
        var priorityQueue3 = new PriorityQueue();
        Console.WriteLine(priorityQueue3.Dequeue());

        // Defect(s) Found: Again no defects were found and I didn't have to change anything which is weird but it passed all the given tests...

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}