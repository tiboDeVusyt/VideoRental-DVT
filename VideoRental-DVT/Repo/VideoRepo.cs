using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoRental_DVT.Data;
using VideoRental_DVT.Models;

namespace VideoRental_DVT.Repo
{
    public class VideoRepo
    {
        private readonly AppDbContext _context;

        public VideoRepo(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Video>> GetAllVideos()
        {
            var videos = await _context.Videos.ToListAsync();
            return videos;
        }
        public async Task<Video> CreateVideo(Video video)
        {
            await _context.Videos.AddAsync(video);
            await _context.SaveChangesAsync();
            return video;
        }
        public Video GetVideoById(int Id)
        {
            var video = _context.Videos.FirstOrDefault(d => d.VideoId.Equals(Id));
            return video;
        }
        public Video UpdateVideo(Video video)
        {
            _context.Videos.Update(video);
            _context.SaveChanges();
            return video;
        }
        public Video Deletevideo(Video video)
        {
            _context.Videos.Remove(video);
            _context.SaveChanges();
            return video;
        }
    }
}
