using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Book
    {
        protected int ID =0;
        protected string title= "";
        protected string author = "";
        protected string publisher = "";
        protected int quantity = 0;

        public int getID ()
        {
            return ID;
        }

        public void setID(int value)
        {
            this.ID = value;
        }

        public string getTitle()
        {
            return title;
        }

        public void setTitle(string value)
        {
            this.title = value;
        }

        public string getAuthor()
        {
            return author;
        }

        public void setAuthor(string value)
        {
            this.author = value;
        }

        public string getPublisher()
        {
            return publisher;
        }

        public void setPublisher(string value)
        {
            this.publisher = value;
        }

        public int getQuantity()
        {
            return quantity;
        }

        public void setQuantity(int value)
        {
            this.quantity = value;
        }
    }
}
