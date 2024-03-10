using QuoteGenerator.Models;
using Microsoft.EntityFrameworkCore;

namespace QuoteGenerator.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
                
        }
        public DbSet<Quote> Quotes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Quote>().HasData(
                new Quote { QuoteId = 1, QuoteText = "You must be the change you wish to see in the world.", Author = "Mahatma Gandhi" },
                new Quote { QuoteId = 2, QuoteText = "Spread love everywhere you go. Let no one ever come to you without leaving happier.", Author = "Mother Teresa" },
                new Quote { QuoteId = 3, QuoteText = "The only thing we have to fear is fear itself.", Author = "Franklin D. Roosevelt" },
                new Quote { QuoteId = 4, QuoteText = "Darkness cannot drive out darkness: only light can do that. Hate cannot drive out hate: only love can do that.", Author = "Martin Luther King Jr." },
                new Quote { QuoteId = 5, QuoteText = "Do one thing every day that scares you.", Author = "Eleanor Roosevelt" },
                new Quote { QuoteId = 6, QuoteText = "Well done is better than well said.", Author = "Benjamin Franklin" },
                new Quote { QuoteId = 7, QuoteText = "The best and most beautiful things in the world cannot be seen or even touched - they must be felt with the heart.", Author = "Helen Keller" },
                new Quote { QuoteId = 8, QuoteText = "It is during our darkest moments that we must focus to see the light.", Author = "Aristotle" },
                new Quote { QuoteId = 9, QuoteText = "Do not go where the path may lead, go instead where there is no path and leave a trail.", Author = "Ralph Waldo Emerson" },
                new Quote { QuoteId = 10, QuoteText = "Be yourself; everyone else is already taken.", Author = "Oscar Wilde" }
                );
        }

    }
}
