using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreDemo.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                 ID = 1,
                 UserName = "Serhat"
                },
                 new UserComment
                {
                 ID = 2,
                 UserName = "Cihat"
                },
                  new UserComment
                {
                 ID = 3,
                 UserName = "Ahmet"
                },
            };
            return View(commentValues);
        }
    }
}
