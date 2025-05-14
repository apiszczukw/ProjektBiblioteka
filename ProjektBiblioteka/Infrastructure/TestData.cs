

using ProjektBiblioteka.Model;
using System.Collections.Generic;

namespace ProjektBiblioteka.Infrastructure
{
    public class TestData
    {

        public static List<Authors> GetGeneratedAuthors()
        {
            List<Authors> authorsList = new List<Authors>
        {
            new Authors { Id = 1, Surname = "Orwell", Name = "George", YearOfBirth = 1903 },
            new Authors { Id = 2, Surname = "Austen", Name = "Jane", YearOfBirth = 1775 },
            new Authors { Id = 3, Surname = "Tolkien", Name = "J.R.R.", YearOfBirth = 1892 },
            new Authors { Id = 4, Surname = "Rowling", Name = "J.K.", YearOfBirth = 1965 },
            new Authors { Id = 5, Surname = "Hemingway", Name = "Ernest", YearOfBirth = 1899 },
            new Authors { Id = 6, Surname = "Dickens", Name = "Charles", YearOfBirth = 1812 },
            new Authors { Id = 7, Surname = "Fitzgerald", Name = "F. Scott", YearOfBirth = 1896 },
            new Authors { Id = 8, Surname = "Shelley", Name = "Mary", YearOfBirth = 1797 },
            new Authors { Id = 9, Surname = "Dostoevsky", Name = "Fyodor", YearOfBirth = 1821 },
            new Authors { Id = 10, Surname = "Camus", Name = "Albert", YearOfBirth = 1913 }
        };

            return authorsList;
        }

        public static List<Publishers> GetGeneratedPublishers()
        {
            List<Publishers> publishersList = new List<Publishers>
        {
            new Publishers { Id = 1, Name = "Penguin Random House", Website = "https://www.penguinrandomhouse.com" },
            new Publishers { Id = 2, Name = "HarperCollins", Website = "https://www.harpercollins.com" },
            new Publishers { Id = 3, Name = "Simon & Schuster", Website = "https://www.simonandschuster.com" },
            new Publishers { Id = 4, Name = "Hachette Livre", Website = "https://www.hachette.com" },
            new Publishers { Id = 5, Name = "Macmillan Publishers", Website = "https://us.macmillan.com" }
        };

            return publishersList;
        }
    }
}
