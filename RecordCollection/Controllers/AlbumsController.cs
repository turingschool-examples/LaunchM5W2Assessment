using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecordCollection.DataAccess;
using RecordCollection.Models;
using System.Linq;
using System.Threading.Tasks;

namespace RecordCollection.Controllers
{
    public class AlbumsController : Controller
    {
        private readonly RecordCollectionContext _context;

        public AlbumsController(RecordCollectionContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var albums = _context.Albums.ToList();
            return View(albums);
        }

        [Route("Albums/{id:int}")]
        public async Task<IActionResult> Show(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var retrieved = await _context.Albums.FindAsync(id);

            var relatedAlbums = _context.Albums
                .Where(a => a.Artist == retrieved.Artist && a.Id != retrieved.Id)
                .OrderBy(a => a.ReleaseDate);

            var viewModel = new AlbumViewModel
            {
                Album = retrieved,
                RelatedAlbums = relatedAlbums.ToList()
            };

            if (viewModel.RelatedAlbums.Count > 0)
            {
                viewModel.RelatedAlbumsCount = viewModel.RelatedAlbums.Count;
            }
            else
            {
                viewModel.RelatedAlbumsCount = 0;
            }

            return View(viewModel);
        }
    }
}
