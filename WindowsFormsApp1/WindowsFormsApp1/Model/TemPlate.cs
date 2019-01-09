using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSendBirhDayMail.Model
{
    class Template
    {
        private int id;
        private string fileName="";
        private string temPlate = "";

        public Template(int id, string fileName, string temPlate)
        {
            this.id = id;
            this.fileName = fileName ?? throw new ArgumentNullException(nameof(fileName));
            this.temPlate = temPlate ?? throw new ArgumentNullException(nameof(temPlate));
        }
        public int getId() { return this.id; }
        public void setId(int value) { this.id = value; }

        public string getFileName() { return this.fileName; }
        public void setFileName(string value) { this.fileName = value; }

        public string getTemPlate() { return this.temPlate; }
        public void setTemPlate(string value) { this.temPlate = value; }

    }
}
