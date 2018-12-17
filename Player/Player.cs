using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    class Player
    {
        const int MAX_VOLUME = 100;
        const int MIN_VOLUME = 0;
        private int _volume;
        public int Volume
        {
            get
            {
                return (_volume);
            }
            private set
            {
                if(value < MIN_VOLUME)
                {
                    _volume = MIN_VOLUME;
                }
                else if(value > MAX_VOLUME)
                {
                    _volume = MAX_VOLUME;
                }
                else
                {
                    _volume = value;
                }
            }

        }
        public Song[] Songs;
        public bool Locked;
        public bool Playing;

        public Player()
        {
            Volume = 0;
            Locked = false;
            Playing = false;
        }

        public void VolumeUp()
        {
            if(Volume<100)
            {
                Volume++;
                Console.WriteLine($"Volume up to {Volume}");
            }
            else
            {
                Console.WriteLine($"Volume is maximum");
            }
            
        }
        public void VolumeDown()
        {
            if(Volume>0)
            {
                Volume--;
                Console.WriteLine($"Volume down to {Volume}");
            }
            else
            {
                Console.WriteLine($"Volume is maximum");
            }
            
        }
        public void VolumeChange(int step)
        {
           Volume += step;
        }
        public void Play()
        {
            Console.WriteLine($"Player is playing: {Songs[0].Name}");
            Playing = true;
        }
        public void Stop()
        {
            Console.WriteLine($"Player has stopped.");
            Playing = false;
        }
        public void Lock()
        {
            Console.WriteLine($"Player is locked.");
            Locked = true;
        }
        public void Unlock()
        {
            Console.WriteLine($"Player is unlocked.");
            Locked = false;
        }
    }
}
