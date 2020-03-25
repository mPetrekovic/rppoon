using System;
using System.Collections.Generic;
using System.Text;

namespace LV1
{
    class Note
    {
        private string mText;
        private string mAuthor;
        private int mPriority;
        public Note()
        {
            mText = "Ovo je bilješka";
            mAuthor = "Mihovil Petrekovic";
            mPriority = 3;
        }
        public Note(string text, string author, int priority)
        {
            mText = text;
            mAuthor = author;
            mPriority = priority;
        }
        public Note(string author)
        {
            mText = "biljeska tri";
            mAuthor = author;
            mPriority = 3;
        }
        public void setText(string text)
        {
            mText = text;
        }
        public void setPriority(int priority)
        {
            mPriority = priority;
        }
        public string getText()
        {
            return mText;
        }
        public string getAuthor()
        {
            return mAuthor;
        }
        public string Text
        {
            get { return mText; }
            set { mText = value; }
        }
        public string Author
        {
            get { return mAuthor; }
            set { mAuthor = value; }
        }
        public int Priority
        {
            get { return mPriority; }
            set { mPriority = value; }
        }
        public override string ToString()
        {
            return mText + "\n autor:" + mAuthor;
        }
    }
}
