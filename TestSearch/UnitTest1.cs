using Library.Controllers;
using Library.Data;
using Library.Models;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TestSearch
{
    public class UnitTest1
    {
        [Fact]
        public async Task ShowSearchResult_ReturnsViewResult_WithListOfBooks()
        {
            // Arrange
            var searchString = "search";
            var books = new List<Book>
            {
                new Book { Title = "Book1", Author = "Author1", ISBN = "ISBN1" },
                new Book { Title = "Book2", Author = "Author2", ISBN = "ISBN2" }
            };
            var mockContext = new Mock<ApplicationDbContext>();
            var mockDbSet = new Mock<DbSet<Book>>();

            mockDbSet.As<IQueryable<Book>>().Setup(m => m.Provider).Returns(books.AsQueryable().Provider);
            mockDbSet.As<IQueryable<Book>>().Setup(m => m.Expression).Returns(books.AsQueryable().Expression);
            mockDbSet.As<IQueryable<Book>>().Setup(m => m.ElementType).Returns(books.AsQueryable().ElementType);
            mockDbSet.As<IQueryable<Book>>().Setup(m => m.GetEnumerator()).Returns(books.GetEnumerator());

            mockContext.Setup(c => c.Books).Returns(mockDbSet.Object);

            var controller = new BooksController(mockContext.Object);

            // Act
            var result = await controller.ShowSearchResult(searchString) as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.IsType<List<Book>>(result.Model);
            var model = Assert.IsAssignableFrom<IEnumerable<Book>>(result.Model);
            Assert.Equal(2, model.Count());
        }

    }
}