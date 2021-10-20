using FirstApiProject.KaniniModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsBookingController : ControllerBase
    {
        public static stationaryContext db = new stationaryContext();



        [HttpGet]
        public async Task<IActionResult> GetAllProductsBookings()
        {
            return Ok(await db.ProductsBookings.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> AddProductsBooking(ProductsBooking e)
        {
            db.ProductsBookings.Add(e);
            await db.SaveChangesAsync();
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProductsBooking(int id, ProductsBooking e)
        {
            using (var db = new stationaryContext())
            {
                db.Entry(e).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return Ok(e);
            }
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteProductsBooking(int id)
        {
            ProductsBooking e = db.ProductsBookings.Find(id);
            db.ProductsBookings.Remove(e);
            await db.SaveChangesAsync();
            return Ok();
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<ProductsBooking>> Getid(int id)
        {
            ProductsBooking e = await db.ProductsBookings.FindAsync(id);
            return Ok(e);
        }


    }
}
