using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;
using testsinterview;

MergeStringsOrStringInterlace _ = Factory.CreateMergeStringsOrStringInterlace();
CountEvenAndOddNumbersInArray countEvenAndOdd = Factory.CreateCountEvenAndOddNumbersInArray();
GetFirstStringThatDoesNotRepeat getnonerepeatedstring = Factory.CreateGetFirstStringThatDoesNotRepeat();
FindAndReplaceMissingString findAndReplaceMissingString = Factory.FindAndReplaceMissingString();
productEntity FirstproductEntity = new()
{
   ProductId=1, 
    ProductCategoryId = 1,
    ProductPrice = 100,
    ProductCategoryName = "test category",
    ProductCategoryDescription = "this is the test product category description",
    ProductName = "test product",
    ProductDescription = "This is the test product description",
};
//create a list of the productEntity class and add the FirstproductEntity to the list
List<productEntity> productEntityList = new//create a list of the productEntity class and add the FirstproductEntity to the list
List<productEntity>()
{
                FirstproductEntity,
                new() {
                    ProductCategoryId = 2,
                    ProductPrice = 200,
                    ProductCategoryName = " category 2",
                    ProductCategoryDescription = "this is the category description 2",
                    ProductName = " product 2",
                    ProductDescription = "This is the product description 2",
                },
                new() {
                    ProductCategoryId = 3,
                    ProductPrice = 300,
                    ProductCategoryName = " category 3",
                    ProductCategoryDescription = "this is the category description 3",
                    ProductName = " product 3",
                    ProductDescription = "This is the product description 3",
                },
                new() {
                    ProductCategoryId = 4,
                    ProductPrice = 400,
                    ProductCategoryName = " category 4",
                    ProductCategoryDescription = "this is the category description 4",
                    ProductName = " product 4",
                    ProductDescription = "This is the product description 4",
                },
                new() {
                    ProductCategoryId = 5,
                    ProductPrice = 500,
                    ProductCategoryName = " category 5",
                    ProductCategoryDescription = "this is the category description 5",
                    ProductName = " product 5",
                    ProductDescription = "This is the product description 5",
                },
                new() {
                    ProductCategoryId = 6,
                    ProductPrice = 600,
                    ProductCategoryName = " category 6",
                    ProductCategoryDescription = "this is the category description 6",
                    ProductName = " product 6",
                    ProductDescription = "This is the product description 6",
                },
                new() {
                    ProductCategoryId = 7,
                    ProductPrice = 700,
                    ProductCategoryName = " category 7",
                    ProductCategoryDescription = "this is the category description 7",
                    ProductName = " product 7",
                    ProductDescription = "This is the product description 7",
                },
                new() {
                    ProductCategoryId = 8,
                    ProductPrice = 800,
                    ProductCategoryName = " category 8",
                    ProductCategoryDescription = "this is the category description 8",
                    ProductName = " product 8",
                    ProductDescription = "This is the product description 8",
                },
                new() {
                    ProductCategoryId = 9,
                    ProductPrice = 900,
                    ProductCategoryName = " category 9",
                    ProductCategoryDescription = "this is the category description 9",
                    ProductName = " product 9",
                    ProductDescription = "This is the product description 9",
                },
                new() {
                    ProductCategoryId = 10,
                    ProductPrice = 1000,
                    ProductCategoryName = " category 10",
                    ProductCategoryDescription = "this is the category description 10",
                    ProductName = " product 10",
                    ProductDescription = "This is the product description 10",
                },
                new() {
                    ProductCategoryId = 11,
                    ProductPrice = 1100,
                    ProductCategoryName = " category 11",
                    ProductCategoryDescription = "this is the category description 11",
                    ProductName = " product 11",
                    ProductDescription = "This is the product description 11",
                }
            };


Console.ForegroundColor = ConsoleColor.Blue;
// Use ANSI escape codes for bolding text
string startBold = "\u001b[1m";
string endBold = "\u001b[0m";
Console.WriteLine("\n\n\n");
Console.WriteLine($"This is the product details of the {startBold} productEntity class{endBold}\n\n");
Console.WriteLine("below is the results from the extention methed TestproductEntity.GetProductSpecifications()\n\n");

Console.ForegroundColor = ConsoleColor.Green;
//use this mthod to get the product entity by Id

productEntity TestproductEntity = productEntityList.Find(x => x.ProductId ==1); 
Console.WriteLine( TestproductEntity.GetProductSpecifications());
Console.ResetColor();
