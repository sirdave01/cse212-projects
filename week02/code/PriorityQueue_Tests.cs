using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue items with different priorities and dequeue them 
    // to verify highest priority is returned first

    // Expected Result: Items are dequeued in descending order of priority 
    // (highest number first), and each item is removed

    // Defect(s) Found: Dequeue does not remove the item, causing the same item to be returned repeatedly; 
    // loop in Dequeue skips the last item

    public void TestPriorityQueue_1()
    // enqueue and dequeue items with different priorities
    // to verify highest priority is returned first
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Dave", 4);
        priorityQueue.Enqueue("Chris", 2); // Lower priority than Dave
        priorityQueue.Enqueue("Dan", 8); // Higher priority than Dave and Chris
        priorityQueue.Enqueue("Emma", 15); // Highest priority

        // expected order of dequeue: Emma, Dan, Dave, Chris

        Assert.AreEqual("Emma", priorityQueue.Dequeue());
        Assert.AreEqual("Dan", priorityQueue.Dequeue());
        Assert.AreEqual("Dave", priorityQueue.Dequeue());
        Assert.AreEqual("Chris", priorityQueue.Dequeue());
        Assert.AreEqual(0, priorityQueue.ToString().Length, "Queue should be empty after all dequeues");

    }

    [TestMethod]
    // Scenario: Attempt to dequeue from an empty queue
    // Expected Result: Throws InvalidOperationException with message "The queue is empty."

    // Defect(s) Found: None (current implementation correctly throws exception)

    public void TestPriorityQueue_2()
    // attempt to dequeue from an empty queue
    // to verify it throws InvalidOperationException with message "The queue is empty."
    {
        var priorityQueue = new PriorityQueue();
        try
        {

            priorityQueue.Dequeue();
            Assert.Fail("Expected InvalidOperationException was not thrown.");
        }
        catch (InvalidOperationException)
        {
            Assert.IsTrue(true, "InvalidOperationException was thrown as expected.");
        }
    }

    // Add more test cases as needed below.

    [TestMethod]
    // Scenario: Enqueue multiple items with the same priority and 
    // verify they are dequeued in order of insertion

    // Expected Result: Items with equal priority are dequeued in FIFO order

    // Defect(s): Dequeue does not remove items, causing repeated returns; loop skips lastregistry

    public void TestPriorityQueue_3()

    // checking same priority order
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Alice", 5);
        priorityQueue.Enqueue("Bob", 5);
        priorityQueue.Enqueue("Charlie", 5);

        // ecpected First In First Out order for same priority (Alice, Bob, Charlie)

        Assert.AreEqual("Alice", priorityQueue.Dequeue());
        Assert.AreEqual("Bob", priorityQueue.Dequeue());
        Assert.AreEqual("Charlie", priorityQueue.Dequeue());
        Assert.AreEqual(0, priorityQueue.ToString().Length, "Queue should be empty after all dequeues");
    }

}