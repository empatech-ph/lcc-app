using System;
using System.Collections.Generic;
using System.Text;

namespace LCC.Library
{
    class UtilsLibrary
    {
        public static int getTimestamp()
        {
            return (int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds;
        }
    }
}
