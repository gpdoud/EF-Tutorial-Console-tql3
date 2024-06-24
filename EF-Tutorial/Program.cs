
using Microsoft.EntityFrameworkCore;

namespace EF_Tutorial;

internal class Program {

    static void Main(string[] args) {

        var context = new AppDbContext();

        var requests = context.Requests.Include(x => x.User).ToList();

        requests.ForEach(x => Console.WriteLine($"{x.Description} | {x.User!.Username}"));

    }
}
