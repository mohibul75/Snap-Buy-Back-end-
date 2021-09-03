using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using ServerApp.Model;
using ServerApp.Repository;

namespace ServerApp.Controllers
{
   public class ProductsController: Controller
    {
        private readonly ProductRepository _productRepository = new ProductRepository();

        [HttpPost("api/product/add")]
        public IActionResult Add([FromBody] Products product)
        {

           
            var _addedProduct = _productRepository.Add(product);
            return Ok(_addedProduct);
        }

        [HttpGet("api/product/get")]
        public IActionResult getProduct()
        {
            var product = _productRepository.GetAll();

            return Ok(product);
        }

        [HttpGet("api/product/getById")]
        public IActionResult getById(int productId)
        {
            var product = _productRepository.GetById(productId);

            return Ok(product);
        }

        [HttpGet("api/product/update")]
        public IActionResult update(Products product)
        {
            var obj = _productRepository.Update(product);

            return Ok(obj);
        }

        [HttpGet("api/product/delete")]
        public IActionResult delete(Products product)
        {
            var obj = _productRepository.Delete(product);

            return Ok(obj);
        }

    }
}
