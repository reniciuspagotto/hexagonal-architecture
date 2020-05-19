﻿using BookStore.Domain.Entities;
using System.Collections.Generic;

namespace BookStore.Domain.Repositories
{
    public interface IBookRepository
    {
        void Save(Book data);
        IEnumerable<Book> GetAll();
    }
}
