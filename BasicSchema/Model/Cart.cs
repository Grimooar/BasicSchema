using System.Runtime.InteropServices.JavaScript;
using Microsoft.AspNetCore.Http.HttpResults;

namespace BasicSchema.Model;

public class Cart
{
    public  int Id { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public  int UserId { get; set; }
    public  List<Article> Articles { get; set; }
    public decimal Value { get; set; }
}