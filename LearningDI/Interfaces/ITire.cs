namespace LearningDI.Interfaces
{
    public interface ITire
    {
        void CalcRollSPeed(int RPM, int direction);
        int GetRollSpeed(int RPM, int direction);
    }
}