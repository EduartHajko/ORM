
using ForingKey;
using ForingKey.Models;
using Microsoft.EntityFrameworkCore;
public class Program
{

    static void Main(string[] args)
    {
        using (CustomerContext context = new CustomerContext())
        {
            var std = new Logs();
            try
            {
                var students = context.Customers
                  .FromSql($"select * from cusfefhewihfewihfwo")
                  .ToList();
            }
            catch (Exception e)
            {
                std.ExceptionName = e.Message;
                context.Logs.Add(std);
                context.SaveChanges();
                Console.WriteLine(e.Message);
                throw e;
            }
        }
    }

}

    

