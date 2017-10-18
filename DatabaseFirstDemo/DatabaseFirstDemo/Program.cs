using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancia
            var context = new DatabaseFirstDemoEntities();

            //Nuevo Post
            var post = new Posts()
            {
                Body = "Body",
                DatePublished = DateTime.Now,
                Title = "Title",
                PostID = 1
            };

            //Añadirlo y guardar (esto no guarda en BBDD)
            context.Posts.Add(post);

            //Guardar en BBDD
            context.SaveChanges();
        }
    }
}
