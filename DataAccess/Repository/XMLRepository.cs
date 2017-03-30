using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using DataAccess.Repository.Repositories.Account;

namespace DataAccess.Repository
{
    public abstract class XMLRepository
    {
        public string FilePath { get; set; }
        public XMLRepository(string filePath)
        {
            FilePath = filePath;
        }

        public XDocument Open()
        {
            return XDocument.Load(FilePath);
        }

        public XElement GetSectionElement(string sectionName)
        {
            var xmlDoc = Open();
            return xmlDoc.Element(sectionName);                   
        }
    }
}
