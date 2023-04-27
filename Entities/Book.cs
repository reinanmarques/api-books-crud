using System.Data;

namespace book_api_crud.Entities;

public class Book
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Title { get; set; } 
    public string? Author { get; set; }

    public void Update(string title, string author)
    {
        Title = title;
        Author = author;
    }
}