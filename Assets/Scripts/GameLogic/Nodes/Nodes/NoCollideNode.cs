public class NoCollideNode : Node
{
    protected override void Awake()
    {
        base.Awake();
        CanCollide = false;
    }
}