using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using VideoRental_DVT.Data;
using VideoRental_DVT.Models;
using VideoRental_DVT.Repo;

namespace VideoRental_DVT.Controllers
{
    public class HomeController : Controller
    {
        private readonly VideoRepo _VideoRepo;
        private readonly AppDbContext _Context;


        public HomeController(AppDbContext context, VideoRepo videoRepo)
        {
            _VideoRepo = videoRepo;
            _Context = context;
        }

        public ViewResult Index(string sortOrder, string searchString)
        {
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
            ICollection<Video> videos = _Context.Videos.ToList();
            if (!String.IsNullOrEmpty(searchString))
            {
                videos =videos.Where(s => s.VideoName.ToLower().Contains(searchString.ToLower())
                                       || s.Director.ToLower().Contains(searchString.ToLower())).ToList();
            }
            switch (sortOrder)
            {
                case "name_desc":
                    videos = videos.OrderByDescending(s => s.VideoName).ToList();
                    break;
                case "Date":
                    videos = videos.OrderBy(s => s.ReturnDate).ToList();
                    break;
                case "date_desc":
                    videos = videos.OrderByDescending(s => s.ReturnDate).ToList();
                    break;
                default:
                    videos = videos.OrderBy(s => s.VideoName).ToList();
                    break;
            }

            return View(videos.ToList());
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Edit(int Id)
        {
            var video = _VideoRepo.GetVideoById(Id);
            return View(video);
        }
        [HttpPost]
        public IActionResult Edit(Video video)
        {
            _VideoRepo.UpdateVideo(video);
            return View(video);
        }
        public IActionResult Delete(int Id)
        {
            var video = _VideoRepo.GetVideoById(Id);
            return View(video);
        }
        [HttpPost]
        public IActionResult Delete(Video video)
        {
            _VideoRepo.Deletevideo(video);
            return View(video);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Video video)
        {
            await _VideoRepo.CreateVideo(video);
            return View(video);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
