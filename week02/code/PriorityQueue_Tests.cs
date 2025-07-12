using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with the following value and priority: work (3), Play (1), Study (2)
    // Expected Result: Work (3), Study (2), Play (1)
    // Defect(s) Found: Count is not retrieving the amount of items inside the QUEUE and is not deleting the item from queue
    public void TestPriorityQueue_1()
    {
        var work = new PriorityItem("Work", 3);
        var play = new PriorityItem("Play", 1);
        var study = new PriorityItem("Study", 2);

        PriorityItem[] expectedResult = [work, study, play];

        var queue = new PriorityQueue();
        queue.Enqueue(work.Value, work.Priority);
        queue.Enqueue(play.Value, play.Priority);
        queue.Enqueue(study.Value, study.Priority);

        int i = 0;
        while (queue.Count > 0)
        {
            if (i >= expectedResult.Length)
            {
                Assert.Fail("Queue should have ran out of items by now.");
            }

            var item = queue.Dequeue();
            Assert.AreEqual(expectedResult[i].Value, item);
            i++;
        }
    }

    [TestMethod]
    // Scenario: If both tasks have the same priority should be take the first queued and the the second of 
    //           the same priority.
    // Expected Result: Work (3), Buy Meals (2), Study (2), Read (2), Play (1)
    // Defect(s) Found: in Dequeue the same value in highPriorityIndex the comparison 
    //                  between the index priority replace the index for the last greater index priority.
    public void TestPriorityQueue_2()
    {
        var work = new PriorityItem("Work", 3);
        var buyMeals = new PriorityItem("Buy Meals", 2);
        var read = new PriorityItem("Read", 2);
        var study = new PriorityItem("Study", 2);
        var play = new PriorityItem("Play", 1);

        PriorityItem[] expectedResult = [work, buyMeals, study, read, play];

        var queue = new PriorityQueue();
        queue.Enqueue(buyMeals.Value, buyMeals.Priority);
        queue.Enqueue(play.Value, play.Priority);
        queue.Enqueue(study.Value, study.Priority);
        queue.Enqueue(work.Value, work.Priority);
        queue.Enqueue(read.Value, read.Priority);

        int i = 0;
        while (queue.Count > 0)
        {
            if (i >= expectedResult.Length)
            {
                Assert.Fail("Queue should have ran out of items by now.");
            }

            var item = queue.Dequeue();
            Assert.AreEqual(expectedResult[i].Value, item);
            i++;
        }
    }
}