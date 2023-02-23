namespace GD.Events
{
    public interface IGameEventListener<P>
    {
        public void OnEventRaised(P parameters);
    }
}