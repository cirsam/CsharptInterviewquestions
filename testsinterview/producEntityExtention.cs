using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace testsinterview
{
    public static class ProductEntityExtention{
        // This is an extension method for the `producEntity` class that puts to gether the product specifications or details and returns them as a formatted string.
        public static string GetProductSpecifications(this producEntity product)
        {
            return $"Product Name: {product.ProductName}\n" +
                   $"Product Description: {product.ProductDescription}\n" +
                   $"Product Price: {product.ProductPrice:C}\n" +
                   $"Product Category: {product.ProductCategoryName}\n" +
                   $"Category Description: {product.ProductCategoryDescription}";
        }
    }
}
