using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliTicker
{
    public static class Globals
    {
        public static string test = "test";
        public static int number = 1;
        public static int currentRating = 50;
        public static int hasVoted = 0;
        public static int nysGovPos = 3;
        public static int nysGovNeg = 2;
        public static int hasRated = 0;
        public static int upChecked = 0;
        public static int downChecked = 0;
        public static string nysGovMsg = "";

        public static List<Comment> nysGovComments = new List<Comment>(new Comment[] { new Comment("I appreciate his efforts for the pro-choice community", 1), new Comment("Progressive and legalized same sex for NYC!!", 1), new Comment("Very reasonable with his tax changes", 1), new Comment("His gun control law is DRACONIAN", 0), new Comment("He wants to start fracking so our water becomes poison", 0) });

    }

}
