// See https://aka.ms/new-console-template for more information
using System;

class ObjectTracker
{
    private int data;
    private static int activeObjects = 0;

    public ObjectTracker()
    {
        activeObjects++;
        Console.WriteLine($"Constructor Called. Active Objects: {activeObjects}");
    }

    ~ObjectTracker()
    {
        activeObjects--;
        Console.WriteLine($"Object Destroyed. Active Objects: {activeObjects}");
    }

    public void SetData(int x)
    {
        data = x;
    }

    public void ShowData()
    {
        Console.WriteLine($"Data: {data}");
    }

    public static int GetActiveObjects()
    {
        return activeObjects;
    }
}

class Program
{
    static void CreateAndDestroyObjects()
    {
        ObjectTracker obj1 = new ObjectTracker();
        obj1.SetData(10);

        ObjectTracker obj2 = new ObjectTracker();
        obj2.SetData(20);

        ObjectTracker obj3 = new ObjectTracker();
        obj3.SetData(30);

        Console.WriteLine("\n--- Displaying Data ---");
        obj1.ShowData();
        obj2.ShowData();
        obj3.ShowData();
    }

    static void Main()
    {
        CreateAndDestroyObjects();

        // Force garbage collection to call destructors
        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.WriteLine("\nProgram Ended.");
    }
}

