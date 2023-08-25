using System;
using PocOnStateDP.Model;

namespace PocOnStateDP
{
    class Program
    {
        static void Main(string[] args)
        {
            AudioPlayer audioPlayer = new AudioPlayer();

            audioPlayer.Change();
            audioPlayer.Change();
            audioPlayer.Change();

        }
    }
}
