﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    internal class Music
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public Music Next { get; set; } // Trỏ đến bài hát tiếp theo
    }
}
