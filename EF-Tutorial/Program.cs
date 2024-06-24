
using Microsoft.EntityFrameworkCore;

namespace EF_Tutorial;

internal class Program {

    static void Main(string[] args) {

        var context = new AppDbContext();

        var requestlines = context.Requestlines.Include(x => x.Request).Include(x => x.Product).ToList();

        requestlines.ForEach(
            x => Console.WriteLine(
                $"{x.Request!.Description} | {x.Product!.Name} " +
                $" | {x.Quantity} | {x.Product!.Price:C} " +
                $" | {x.Quantity * x.Product!.Price:C} "
        ));
            
        var total = context.Requestlines.Include(x => x.Product).Sum(x => x.Quantity * x.Product!.Price);
        Console.WriteLine($"Total: {total:C}");

    }
}
