using Friends.Data.Models;
using Friends.Data.ViewModels;

namespace Friends.Data.Services
{
    public class FriendsService
    {
        private AppDbContext _context;

        public FriendsService(AppDbContext context)
        {
            _context = context;    
        }

        public Friend AddFriend(FriendsVM friend)
        {
            var _friend = new Friend()
            {
                FirstName = friend.FirstName,
                LastName = friend.LastName,
                Email = friend.Email,
                DateOfBirth = friend.DateOfBirth
            };
            _context.Friends.Add(_friend);
            _context.SaveChanges();
            return _friend;
        }

        public List<Friend> GetAllFriends() => _context.Friends.ToList();

        public Friend? GetFriendById(int friendID) => _context.Friends.FirstOrDefault(f => f.ID == friendID);
    }
}
