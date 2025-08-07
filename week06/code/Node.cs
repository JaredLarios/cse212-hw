public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value > Data)
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        bool isLeft = false;
        bool isRight = false;

        if (value == Data)
            return true;

        if (Right is not null)
            isLeft = Right.Contains(value);

        if (Left is not null)
            isRight = Left.Contains(value);

        return isLeft || isRight;
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        int leftHeight = Left?.GetHeight() ?? 0;
        int rightHeight = Right?.GetHeight() ?? 0;

        return Math.Max(leftHeight, rightHeight) + 1; // Replace this line with the correct return statement(s)
    }
}