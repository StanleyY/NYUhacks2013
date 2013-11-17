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
        public static int hasVoted = 0; // 1 for gov 2 for mayor
        public static int whichMsg = 0; // 1 for gov 2 for mayor

        //gov globals
        public static int hasVotedg = 0;
        public static int nysGovPos = 3;
        public static int nysGovNeg = 2;
        public static int hasRated = 0;
        public static int upChecked = 0;
        public static int downChecked = 0;
        public static string nysGovMsg = "";
        //mayor globals
        public static int hasVotedm = 0;
        public static int nycMayPos = 2;
        public static int nycMayNeg = 2;
        public static int hasRatedm = 0;
        public static int upCheckedm = 0;
        public static int downCheckedm = 0;
        public static string nycMayorMsg = "";

        public static List<Comment> chosenComments;

        public static List<Comment> nysGovComments = new List<Comment>(new Comment[] { new Comment("I appreciate his efforts for the pro-choice community", 1), new Comment("Progressive and legalized same sex for NYC!!", 1), new Comment("Very reasonable with his tax changes", 1), new Comment("His gun control law is DRACONIAN", 0), new Comment("He wants to start fracking so our water becomes poison", 0) });
        public static List<Comment> nysMayorComments = new List<Comment>(new Comment[] { new Comment("Created 311 and made NYC safer.", 1), new Comment("Didn't take pay", 1), new Comment("Nannying the city to lose weight.", 0), new Comment("Questionable education practices", 0) });
    }

}
