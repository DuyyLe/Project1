using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using ProjectAlta.DBContext;
using ProjectAlta.Entity;
using ProjectAlta.Respository;
namespace ProjectAlta.Respository
{
    public class DocumentRespository : IEDocumentRespository
    {
        private readonly Context con;


        public DocumentRespository(Context context)
        {
            con = context;
        }

        public void Delete(int docId)
        {
            Document document = con.Documents.Find(docId);
            con.Documents.Remove(document);
        }

        public List<Document> GetAll()
        {
            return con.Documents.ToList();
        }

        public Document GetById(int docId)
        {
            return con.Documents.Find(docId);
        }

        public void Insert(Document document)
        {
            con.Documents.Add(document);
        }

        public void Save()
        {
            con.SaveChanges();
        }

        public void Update(Document document)
        {
            con.Entry(document).State = EntityState.Modified;
        }
    }
}
