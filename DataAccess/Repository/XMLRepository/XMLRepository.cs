using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccess.Repository
{
    public abstract class XMLRepository
    {
        public string FilePath { get; set; }

        private XDocument xmlDocument { get; set; }

        public XMLRepository(string filePath)
        {
            FilePath = filePath;
        }

        public void Open()
        {
            xmlDocument = XDocument.Load(FilePath);           
        }

        //public IEnumerable<> ReadCollection()
        //{
        //    return xmlDocument.Root.Elements;
        //}

       
    }
}
