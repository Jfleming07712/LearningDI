namespace LearningDI.Interfaces
{
    public interface ITransmission
    {
        int Direction { get; set; }
        void ChangeDirection(string direction);

        int GetDirection();
    }
}