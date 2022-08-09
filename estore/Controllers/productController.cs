using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using estore.Models;

namespace estore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class productController : ControllerBase
    {
        private readonly productContext _context;

        public productController()
        {
            _context = new productContext();
        }
        // GET: api/product
        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<product>>> Getproducts()
        {
            return await _context.products.Select(x => new product()
            {
                productID = x.productID,
                productName = x.productName,
                discount = x.discount,
                price = x.price,
                isSlider = x.isSlider,
                isBestCollection = x.isBestCollection,
                isBestProduct = x.isBestProduct,
                isCategory = x.isCategory,
                isgallery = x.isgallery,
                isLatestOffer = x.isLatestOffer,
                isLatestProduct = x.isLatestProduct,
                productDescription=x.productDescription,
                isAddedToCart=x.isAddedToCart,
                isAddedToCheckout=x.isAddedToCheckout,
                inConfomation=x.inConfomation,
                category=x.category,
                ImageName = x.ImageName,
                ImageUrl = String.Format("{0}://{1}{2}/img{3}", Request.Scheme, Request.Host, Request.PathBase, x.ImageName)
            })
                .ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<product>>> selectProducts(int id)
        {
            return await _context.products.Select(x => new product()
            {
                productID = x.productID,
                productName = x.productName,
                discount = x.discount,
                price = x.price,
                isSlider = x.isSlider,
                isBestCollection = x.isBestCollection,
                isBestProduct = x.isBestProduct,
                isCategory = x.isCategory,
                isgallery = x.isgallery,
                isLatestOffer = x.isLatestOffer,
                isLatestProduct = x.isLatestProduct,
                productDescription = x.productDescription,
                isAddedToCart = x.isAddedToCart,
                isAddedToCheckout = x.isAddedToCheckout,
                inConfomation = x.inConfomation,
                category = x.category,
                ImageName = x.ImageName,
                ImageUrl = String.Format("{0}://{1}{2}/img{3}", Request.Scheme, Request.Host, Request.PathBase, x.ImageName)
            }).Where(x=>x.productID==id)
                .ToListAsync();
        
        }
        [HttpGet("cartProduct")]
        public async Task<ActionResult<IEnumerable<product>>> cartProduct()
        {
            return await _context.products.Select(x => new product()
            {
                productID = x.productID,
                productName = x.productName,
                discount = x.discount,
                price = x.price,
                isSlider = x.isSlider,
                isBestCollection = x.isBestCollection,
                isBestProduct = x.isBestProduct,
                isCategory = x.isCategory,
                quantity=x.quantity,
                isgallery = x.isgallery,
                isLatestOffer = x.isLatestOffer,
                isLatestProduct = x.isLatestProduct,
                productDescription = x.productDescription,
                isAddedToCart = x.isAddedToCart,
                isAddedToCheckout = x.isAddedToCheckout,
                inConfomation = x.inConfomation,
                category = x.category,
                ImageName = x.ImageName,
                ImageUrl = String.Format("{0}://{1}{2}/img{3}", Request.Scheme, Request.Host, Request.PathBase, x.ImageName)
            }).Where(x=>x.isAddedToCart==true)
                .ToListAsync();
       
        }
        //GET: api/product/5
        //    [HttpGet("{id}")]
        //public async Task<ActionResult<product>> Getproduct(int id)
        //{
        //    var product = await _context.products.FindAsync(id);

        //    if (product == null)
        //    {
        //        return NotFound();
        //    }

        //    return product;
        //}

        //PUT: api/product/5
        //     To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
            [HttpPut("{id}")]
        public async Task<IActionResult> Putproduct(int id, product product)
        {
            if (id != product.productID)
            {
                return BadRequest();
            }

            _context.Entry(product).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!productExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/product
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<product>> Postproduct(product product)
        {
            _context.products.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getproduct", new { id = product.productID }, product);
        }

        // DELETE: api/product/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteproduct(int id)
        {
            var product = await _context.products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.products.Remove(product);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool productExists(int id)
        {
            return _context.products.Any(e => e.productID == id);
        }
    }
}
