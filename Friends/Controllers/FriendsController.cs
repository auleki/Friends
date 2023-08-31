using Friends.Data.Services;
using Friends.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Friends.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FriendsController : ControllerBase
    {
        public FriendsService _friendsService;

        public FriendsController(FriendsService friendsService)
        {
            _friendsService = friendsService;
        }

        [HttpGet("All")]
        public IActionResult GetFriends()
        {
            var allFriends = _friendsService.GetAllFriends();
            return Ok(allFriends);
        }

        [HttpGet("{id}")]
        public IActionResult GetFriend(int id) 
        {
            var book = _friendsService.GetFriendById(id);
            return Ok(book);
        }

        [HttpPost("NewFriend")]
        public IActionResult AddBook([FromBody]FriendsVM friend)
        {
            var newBook = _friendsService.AddFriend(friend);
            return Ok(newBook);
        }
    }
}
