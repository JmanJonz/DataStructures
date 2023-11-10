/*
 * CSE212 
 * (c) BYU-Idaho
 * 04-Teach - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */

/// <summary>
/// Maintain a Customer Service Queue.  Allows new customers to be 
/// added and allows customers to be serviced.
/// </summary>
public class CustomerService {
    public static void Run() {
        // Example code to see what's in the customer service queue:
        // var cs = new CustomerService(10);
        // Console.WriteLine(cs);

        // Test Cases

        // Test 1
        // Scenario: 
        // Expected Result: The user shall specify the maximum size of the Customer Service Queue when it is created. If the size is invalid (less than or equal to 0) then the size shall default to 10.
        Console.WriteLine("Test 1");
        var customerService1 = new CustomerService(-1);
            if(customerService1._maxSize != 10){
                Console.WriteLine("Failed");
            }
        var customerService2 = new CustomerService(0);
            if(customerService2._maxSize != 10){
                Console.WriteLine("Failed");
            }
    

        // Defect(s) Found: 

        Console.WriteLine("=================");

        // Test 2
        // Scenario: 
        // Expected Result: The AddNewCustomer method shall enqueue a new customer into the queue.
        // Console.WriteLine("Test 2");
        //     var currentCount = customerService1._queue.Count;
        //                         Console.WriteLine(currentCount);
        //     customerService1.AddNewCustomer();
        //     if(currentCount > customerService1._queue.Count){
        //                                 Console.WriteLine(customerService1._queue.Count);
        //         Console.WriteLine("Failed");
        //     }

        // Console.WriteLine("=================");

        // Add more Test Cases As Needed Below
        // If the queue is full when trying to add a customer, then an error message will be displayed.
        // Console.WriteLine("Test 3");
        //     var customerService3 = new CustomerService(3);
        //         Console.WriteLine(customerService3._maxSize);
        //         customerService3.AddNewCustomer();
        //         customerService3.AddNewCustomer();
        //         customerService3.AddNewCustomer();
        //         if(customerService3._queue.Count > customerService3._maxSize){
        //             Console.WriteLine("Test failed max size was passed and should not have been");
        //         }


        // Console.WriteLine("=================");


        Console.WriteLine("Test 4");
        // The ServeCustomer function shall dequeue the next customer from the queue and display the details.
            var customerService4 = new CustomerService(3);
            customerService4.AddNewCustomer();
            var firstInQueue = customerService4._queue[0];
            Console.WriteLine(firstInQueue);
            customerService4.AddNewCustomer();

            customerService4.ServeCustomer();

            Console.WriteLine(customerService4._queue[0]);

            if(firstInQueue == customerService4._queue[0]){
                Console.WriteLine("Test Failed, first customer was not dequed");
            }
        Console.WriteLine("=================");


        Console.WriteLine("Test 5");

        Console.WriteLine("=================");





    }

    private readonly List<Customer> _queue = new();
    private readonly int _maxSize;


    public CustomerService(int maxSize) {
        if (maxSize <= 0)
            _maxSize = 10;
        else
            _maxSize = maxSize;
    }

    /// <summary>
    /// Defines a Customer record for the service queue.
    /// This is an inner class.  Its real name is CustomerService.Customer
    /// </summary>
    private class Customer {
        public Customer(string name, string accountId, string problem) {
            Name = name;
            AccountId = accountId;
            Problem = problem;
        }

        private string Name { get; }
        private string AccountId { get; }
        private string Problem { get; }

        public override string ToString() {
            return $"{Name} ({AccountId})  : {Problem}";
        }
    }

    /// <summary>
    /// Prompt the user for the customer and problem information.  Put the 
    /// new record into the queue.
    /// </summary>
    private void AddNewCustomer() {
        // Verify there is room in the service queue
        if (_queue.Count >= _maxSize) {
            Console.WriteLine("Maximum Number of Customers in Queue.");
            return;
        }

        Console.Write("Customer Name: ");
        var name = Console.ReadLine()!.Trim();
        Console.Write("Account Id: ");
        var accountId = Console.ReadLine()!.Trim();
        Console.Write("Problem: ");
        var problem = Console.ReadLine()!.Trim();

        // Create the customer object and add it to the queue
        var customer = new Customer(name, accountId, problem);
        _queue.Add(customer);
    }

    /// <summary>
    /// Dequeue the next customer and display the information.
    /// </summary>
    private void ServeCustomer() {
        _queue.RemoveAt(0);
        var customer = _queue[0];
        Console.WriteLine(customer);
    }

    /// <summary>
    /// Support the WriteLine function to provide a string representation of the
    /// customer service queue object. This is useful for debugging. If you have a 
    /// CustomerService object called cs, then you run Console.WriteLine(cs) to
    /// see the contents.
    /// </summary>
    /// <returns>A string representation of the queue</returns>
    public override string ToString() {
        return $"[size={_queue.Count} max_size={_maxSize} => " + String.Join(", ", _queue) + "]";
    }
}