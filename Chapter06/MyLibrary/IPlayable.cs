using static System.Console;


namespace MyLibrary.Shared
{
    public interface IPlayable
    {
        void Play();
        void Pause();

        void Stop()
        {
            WriteLine("Default implementation of Stop.");
        }
    }
}