// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// Tests GC.GetGeneration(null)..should throw exception: System.ArgumentNullException

using System;
using Xunit;

public class Test_GetGeneration_fail
{
    [Fact]
    public static int TestEntryPoint()
    {
        Object obj1 = new Object();

        Console.WriteLine("This test should throw an exception!");
        Console.WriteLine("Generation: " + GC.GetGeneration(obj1));

        int[] array = new int[25];
        array = null;

        try
        {
            Console.WriteLine("Generation: " + GC.GetGeneration(array));
        }
        catch (ArgumentNullException e)
        {
            Console.WriteLine("Expected exception thrown: {0}", e);
            Console.WriteLine("Test for GetGeneration() passed!");
            return 100;
        }
        catch (Exception e)
        {
            Console.WriteLine("Unexpected exception thrown:");
            Console.WriteLine(e);
        }

        Console.WriteLine("Test for GetGeneration() failed!");
        return 1;
    }
}
