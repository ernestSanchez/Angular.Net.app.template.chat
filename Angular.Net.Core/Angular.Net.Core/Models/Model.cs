using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular.Net.Core.Models
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        {

        }

        public DbSet<Message> Message { get; set; }
    }

    public class Message 
    {
        public int Id { get; set; }
       //el que manda el mensaje
        public string Name { get; set; }
        //el texto del mensaje
        public string Text { get; set; }
    }
}
