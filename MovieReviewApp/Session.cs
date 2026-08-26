namespace MovieReviewApp
{
    public static class Session
    {
        // =====================================================
        // MAIN SESSION PROPERTIES
        // =====================================================

        public static int UserID { get; set; }

        public static string UserName { get; set; }

        public static string UserEmail { get; set; }

        public static string Role { get; set; }


        // =====================================================
        // COMPATIBILITY PROPERTIES
        // These allow existing code using UserId, FullName,
        // and Email to continue working.
        // =====================================================

        public static int UserId
        {
            get
            {
                return UserID;
            }
            set
            {
                UserID = value;
            }
        }

        public static string FullName
        {
            get
            {
                return UserName;
            }
            set
            {
                UserName = value;
            }
        }

        public static string Email
        {
            get
            {
                return UserEmail;
            }
            set
            {
                UserEmail = value;
            }
        }


        // =====================================================
        // CLEAR SESSION
        // =====================================================

        public static void Clear()
        {
            UserID = 0;
            UserName = null;
            UserEmail = null;
            Role = null;
        }
    }
}