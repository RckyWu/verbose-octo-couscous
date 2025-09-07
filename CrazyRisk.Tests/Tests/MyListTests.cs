using CrazyRisk.DataStructures;
using Xunit;

namespace CrazyRisk.Tests;

public class MyListTests
{
    [Fact]
    public void Add_Get_Count_Works()
    {
        var list = new MyList<int>();
        list.Add(10);
        list.Add(20);
        list.Add(30);

        Assert.Equal(3, list.Count);
        Assert.Equal(10, list.Get(0));
        Assert.Equal(20, list.Get(1));
        Assert.Equal(30, list.Get(2));
        Assert.Equal(1, list.IndexOf(20));
        Assert.Equal(-1, list.IndexOf(999));
    }

    [Fact]
    public void Insert_RemoveAt_Works()
    {
        var list = new MyList<string>();
        list.Add("A");
        list.Add("C");
        list.Insert(1, "B");  // A, B, C
        Assert.Equal("B", list.Get(1));

        list.RemoveAt(0);     // B, C
        Assert.Equal(2, list.Count);
        Assert.Equal("B", list.Get(0));
        Assert.Equal("C", list.Get(1));
    }
}
