using System;

namespace name_parser.App
{
    public class Parser 
    {
        public User ParseName(string name)
        {
            var user = new User();
            // name = name.toUpperCase();

            var namePieces = name.Trim('.').Split(' ');

            if(namePieces.Contains('.') && namePieces.Length > 2)
            {
                user.FirstName = namePieces[0];
                user.LastName = namePieces[1];
                user.Suffix = namePieces[2];
            }
            // else if(namePieces.Contains("MR", "MRS", "MISS", "MISSES", "DR") && namePieces.Length > 2)
            // {
            //     user.Prefix = namePieces[0];
            //     user.FirstName = namePieces[1];
            //     user.LastName = namePieces[2];
            // }
            else if(namePieces.Length > 2)
            {
                user.FirstName = namePieces[0];
                user.MiddleName = namePieces[1];
                user.LastName = namePieces[2];
            }else if(namePieces.Length > 1)
            {
                user.FirstName = namePieces[0];
                user.LastName = namePieces[1];
            }


            // user.FirstName = namePieces[0];

            // if(namePieces.Length > 2)
            // {
            //     if(namePieces[2] < 3)
            //     {
            //         user.LastName = namePieces[1];
            //         user.Suffix = namePieces[2];

            //     }else{
            //     user.MiddleName = namePieces[1];
            //     user.LastName = namePieces[2];
            //     }

            // } else if(namePieces.Length > 1)
            // {
            //     user.LastName = namePieces[1];
            // }

            return user;
        }
    }
}