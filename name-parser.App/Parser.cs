using System;

namespace name_parser.App
{
    public class Parser 
    {
        public User ParseName(string name)
        {
            var user = new User();

            var namePieces = name.Split(' ');

            user.FirstName = namePieces[0];
            if(namePieces.Length >= 1)
            {
                user.LastName = namePieces[1];
            }

            return user;
        }
    }
}