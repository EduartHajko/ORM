
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
                var updatedvalues = (from a in context.Logs
                                     where a.ID == 1
                                     select a).FirstOrDefault();
                
                
                
                
                updatedvalues.Name = "Eduart";
                context.Logs.Update(updatedvalues);
                context.SaveChanges();


                //var students = context.Customers
                //  .FromSql($"select * from cusfefhewihfewihfwo")
                //  .ToList();
            }
            catch (Exception e)
            {
                std.Name = e.Message;
                context.Logs.Add(std);
                context.SaveChanges();
                Console.WriteLine(e.Message);
                throw e;
            }
        }
    }

}

    

