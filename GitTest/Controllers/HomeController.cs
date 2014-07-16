using Google.YouTube;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitTest.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var developerKey = "AI39si6XF3VO-VLQqvxF8FdDcEtU1RT7qxPVhonoghzvWyuAHHqBxfN2DdKPUSn5cTqDqPthRH8ZwbBizftvIXpQ-LOarMGwZA";

            YouTubeRequestSettings settings = new YouTubeRequestSettings("youtube", developerKey);
            YouTubeRequest request = new YouTubeRequest(settings);


            Uri videoEntryUrl = new Uri("http://gdata.youtube.com/feeds/api/videos/ADos_xW4_J0");
            Video video = request.Retrieve<Video>(videoEntryUrl);

            return View(video.IsDraft);
        }

    }
}
