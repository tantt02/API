using API.Model;
using Microsoft.AspNetCore.Mvc;
using System.Net.WebSockets;

namespace API.Controllers
{
	public class SinhVienController : Controller
	{
		readonly private AppDbContext _context;
		public SinhVienController(AppDbContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			return View();
		}

		[HttpGet("find-id")]
		public IActionResult FinId(Guid id)
		{
			var result = _context.sinhViens.Find(id);
			return Ok(result);
		}

		[HttpPost("create-sinh-vien")]
		public IActionResult CreateSinhVien(SinhVien sv)
		{
			var sinhVien = new SinhVien() {
				Id = Guid.NewGuid(),
				Name = sv.Name,
				Description = sv.Description,
				Age = sv.Age,
			};
			_context.Add(sinhVien);
			_context.SaveChanges();
			return Ok();
		}

		[HttpPut("update-sinh-vien")]
		public IActionResult UpdateSinhVien(SinhVien sv)
		{
			var sinhVien = _context.sinhViens.Find(sv.Id);

			sinhVien.Name = sv.Name;
			sinhVien.Description = sv.Description;
			sinhVien.Age = sv.Age;
			_context.sinhViens.Update(sinhVien);
			_context.SaveChanges();
			return Ok();
		}

		[HttpDelete("delete-sinh-vien")]
		public IActionResult DeleteSinhVien(Guid id) {
			var sinhVien = _context.sinhViens.Find(id);
			_context.sinhViens.Remove(sinhVien);
			_context.SaveChanges();
			return Ok();
		} 
	}
}
