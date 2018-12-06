using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BackEnd.Models
{
	public class BlogContext : DbContext
        {
		public BlogContext(DbContextOptions<BlogContext> options): base(options) { }

		public DbSet<Blog> Blogs { get; set; }
		
		public DbSet<Post> Posts { get; set; }
		
		 protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		             => optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=5432;Database=postgres;User Id=postgres;Password=mysecretpassword");			
		
	}	
	
	public class Blog
	{
		public int BlogId { get; set; }

		public string Url { get; set; }

		public List<Post> Posts { get; set; }
	}

	public class Post
	{
		public int PostId { get; set;}
					    
		public string Title { get; set; }

		public string Content { get; set; }
	
		public int BlogId { get; set; }
	
		public Blog Blog { get; set; }
  	}
}
