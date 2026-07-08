
// This code defines a class named `producEntity` that represents a product entity with various properties related to the product and its category.
//This is an entity class like products,students,teacher,customers. using extention methods.we can add a method to this class without modifying the original class definition. This is useful for adding functionality to existing classes without changing their source code.
public class producEntity
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string ProductDescription { get; set; }
    public int ProductCategoryId { get; set; }
    public string ProductCategoryName { get; set; }
    public string ProductCategoryDescription { get; set; }
    public decimal ProductPrice { get; set; }
}