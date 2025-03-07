// using backend.Database;
// using backend.Models;
// using Microsoft.AspNetCore.Mvc;
//
//
// namespace backend.Controllers
// {
//     [Route("api/[controller]")]
//     [ApiController]
//     public class ImageController : ControllerBase
//     {
//         private readonly AppDbContext _context;
//
//         public ImageController(AppDbContext context)
//         {
//             _context = context;
//         }
//
//         [HttpPost]
//         public async Task<IActionResult> UploadImage(IFormFile file)
//         {
//             if (file == null || file.Length == 0)
//                 return BadRequest("No file uploaded.");
//
//             using (var memoryStream = new MemoryStream())
//             {
//                 await file.CopyToAsync(memoryStream);
//                 var imageEntity = new Image
//                 {
//                     ImageId = Guid.NewGuid(),
//                     ImageData = memoryStream.ToArray(),
//                     ImageName = file.FileName
//                 };
//
//                 _context.Images.Add(imageEntity);
//                 await _context.SaveChangesAsync();
//             }
//
//             return Ok("Image uploaded successfully.");
//         }
//         // Эндпоинт для получения изображения по ID
//         [HttpGet("{id}")]
//         public async Task<byte[]> GetImage(Guid id)
//         {
//             var imageEntity = await _context.Images.FindAsync(id);
//
//             return imageEntity.ImageData.ToArray();
//             
//         }
//     }
// }
