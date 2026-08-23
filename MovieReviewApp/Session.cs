using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReviewApp
{
    public static class Session
    {
        public static int UserId { get; set; }

        public static string UserName { get; set; }

        public static string UserEmail { get; set; }

        public static void Clear()
        {
            UserId = 0;
            UserName = null;
            UserEmail = null;
        }
    }
}