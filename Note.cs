using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv1
{
    class Note
    {
        private String text;
        private String author;
        private int importance;

        public string Text
        {
            get { return this.text; }
            set { this.text = value; }
        }

        public string Author
        {
            get { return this.author; }
            private set { this.author = value; }
        }

        public int Priority
        {
            get { return this.importance; }
            set { this.importance = value; }
        }

        public String getText()
        {
            return this.text;
        }

        public String getAuthor()
        {
            return this.author;
        }

        public int getImportance()
        {
            return this.importance;
        }

        public void setText(String text)
        {
            this.text = text;
        }

        public void setPriority(int importance)
        {
            this.importance = importance;
        }

        public Note()
        {
            this.text = "LV1-RPPOON";
            this.author = "Nikola Medarić";
            this.importance = 3;
        }

        public Note(string text)
        {
            this.text = text;
            this.author = "Nikola Medarić";
            this.importance = 3;
        }

        public Note(string text, int importance)
        {
            this.text = text;
            this.author = "Nikola Medarić";
            this.importance = importance;
        }

        public override string ToString()
        {
            return this.text + this.author + this.importance;
        }
    }
}
