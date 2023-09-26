namespace CustomCustomStack.tests;


public class CustomStackTest
{
    [Fact]
    public void Creation()
    {
        CustomStack<int> s = new CustomStack<int>(3);
        Assert.Equal(0, s.Size);
    }

    [Fact]
    public void Push_Pop()
    {
        CustomStack<int> s = new CustomStack<int>(3);

        s.Push(1);
        s.Push(2);
        s.Push(3);
        int value = s.Pop();

        Assert.Equal(3, value);
        Assert.Equal(2, s.Size);
    }

    [Fact]
    public void Too_Much_Pop()
    {
        CustomStack<int> s = new CustomStack<int>(3);
        Assert.Throws<ExpenditureProhibitedException>(() => s.Pop());
    }

    [Fact]
    public void Too_Much_Push()
    {
        CustomStack<int> s = new CustomStack<int>(3);
        s.Push(1);
        s.Push(2);
        s.Push(3);
        Assert.Throws<ExceededSizeException>(() => s.Push(4));
    }

    [Fact]
    public void Peek_Exception()
    {
        CustomStack<int> s = new CustomStack<int>(3);
        Assert.Throws<ExpenditureProhibitedException>(() => s.Peek());
    }

    [Fact]
    public void Peek_Element()
    {
        CustomStack<int> s = new CustomStack<int>(3);

        s.Push(1);
        s.Push(2);
        int value = s.Peek();

        Assert.Equal(2, value);
        Assert.Equal(2, s.Size);
    }
}