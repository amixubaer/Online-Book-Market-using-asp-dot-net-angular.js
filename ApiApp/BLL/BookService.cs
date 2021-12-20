using AutoMapper;
using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BookService
    {
        public static void Add(BookModel b)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<BookModel, Book>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Book>(b);
            DataAccessFactory.BookDataAcess().Add(data);
        }

        public static void Edit(BookModel b)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<BookModel, Book>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Book>(b);
            DataAccessFactory.BookDataAcess().Edit(data);
        }

        public static void Delete(BookModel b)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<BookModel, Book>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Book>(b);
            DataAccessFactory.BookDataAcess().Delete(data);
        }


        public static List<BookModel> GetAll()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Book, BookModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.BookDataAcess();
            var data = mapper.Map<List<BookModel>>(da.GetAll());
            return data;
        }

        public static List<BookModel> GetByUsername(string src)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Book, BookModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.BookDataAcess();
            var data = mapper.Map<List<BookModel>>(da.GetByUsername(src));
            return data;
        }


        public static BookModel GetOne(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Book, BookModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.BookDataAcess();
            var data = mapper.Map<BookModel>(da.GetOne(id));
            return data;
        }

        public static List<BookModel> SrcBook(string src)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Book, BookModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.BookDataAcess();
            var data = mapper.Map<List<BookModel>>(da.SrcBook(src));
            return data;
        }
    }
}
