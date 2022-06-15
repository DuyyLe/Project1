using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using ProjectAlta.Entity;
namespace ProjectAlta.Respository
{
    public interface IEDocumentRespository
    {
        List<Document> GetAll();
        Document GetById(int docId);
        void Insert(Document document);
        void Update(Document document);
        void Delete(int docId);
        void Save();
    }
}
